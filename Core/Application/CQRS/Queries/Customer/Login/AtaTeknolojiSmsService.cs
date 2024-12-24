using System.Net;
using System.Text;

namespace Application.CQRS.Queries.Customer.Login
{
    public class AtaTeknolojiSmsService
    {


        public string SmsGonder(string num, int otp)
        {
            //string telNo = "554900094";
            //string mesaj = "Hörmətli istifadəçi 4169********* 52.99 manat abunə haqqı çıxıldı. Bizi seçdiyiniz üçün təşəkkürlər";
            //string mesaj = "Sizin OTP kodunuz: 5498";
            //string mesaj = "Tək olanda yığarsan";           

            var date = DateTime.Now.ToString("yyyy-MM-dd" + " " + "HH.mm.ss");
            #region XML
            string xmlDesen = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n" +
                               "<request>\n" +
                               "<head>\n" +
                               "<operation>submit</operation>\n" +
                               "<login>" + "Master_Class" + @"</login>\n" +
                               "<password>" + "fR4@8MBw!K7" + @"</password>\n" +
                               "<title>" + "MasterClass" + @"</title>\n" +
                               "<scheduled>" + date + @"</scheduled>\n" +
                               "<isbulk>false</isbulk>\n" +
                               "<controlid>" + Guid.NewGuid().ToString() + @"</controlid>\n" +
                               "</head>\n" +
                               "<body>\n" +
                               "<msisdn>" + num + @"</msisdn>\n" +
                               "<message>" + otp + @"</message>\n" +
                               "</body>\n" +
                               "</request>";

            var responseFromServer = sendRequest(xmlDesen);

            return "1";
            #endregion
            //XmlTextReader XML = new XmlTextReader(new StringReader(responseFromServer));
            //while (XML.Read())
            //{
            //    if (XML.Name == "responsecode")
            //    {
            //        s = (XML.ReadString());


            //    }
            //    if (XML.Name == "taskid")
            //    {
            //        taskId = (XML.ReadString());
            //    }
            //    if (s != "" && taskId != "") { break; }
            //}
            //XML.Close();
            //if (s == "000")
            //{
            //    return "Göndərildi," + taskId;
            //}
            //else
            //{
            //    return "Uğursuz";
            //}
        }

        public string sendRequest(string xmlDesen)
        {
            //request
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://sms.atatexnologiya.az/bulksms/api");
            byte[] byteArray = Encoding.UTF8.GetBytes(xmlDesen);
            request.Method = "POST";
            request.ContentType = "application/xml;charset=utf-8";
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            //response
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            return responseFromServer;
        }

    }
}
