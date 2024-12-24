using System.Text;

namespace Application.CQRS.Queries.Customer.Login
{
    public class OtpService
    {
        private readonly Random _random = new Random();

        public int GenerateOtp()
        {
            return _random.Next(100000, 999999);
        }

        public async Task SendOtp(string phone, int otp)
        {
            var xmlRequest = $@"
                <?xml version='1.0' encoding='UTF-8'?>
                <request>
                    <head>
                        <operation>submit</operation>
                        <login> Master_Class </login>
                        <password> fR4@8MBw!K7 </password>
                        <title> MasterClass </title>
                        <bulkmessage> OTP kodunuz: {otp}</bulkmessage>
                        <isbulk>false</isbulk>
                    </head>
                    <body>
                        <msisdn> 994506719999 </msisdn>
                        <message> {otp} </message>
                    </body>
                </request>";

            var content = new StringContent(xmlRequest, Encoding.UTF8, "application/xml");

            try
            {
                HttpClient _httpClient = new HttpClient();
                var response = await _httpClient.PostAsync("https://sms.atatexnologiya.az/bulksms/api", content);

                if (!response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"OTP göndərilməsində xəta: {responseContent}");
                    throw new Exception("OTP göndərilə bilmədi.");
                }
                var responseContent1 = await response.Content.ReadAsStringAsync();

                Console.WriteLine($"OTP {otp} {phone} nömrəsinə göndərildi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Xəta baş verdi: {ex.Message}");
                throw;
            }
        }
    }
}