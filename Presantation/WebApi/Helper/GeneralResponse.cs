namespace WebApi.Helper
{
    public class GeneralResponse<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        public static GeneralResponse<T> SuccessResponse(T data, string message = "Success")
        {
            return new GeneralResponse<T> { Success = true, Message = message, Data = data };
        }

        public static GeneralResponse<T> FailureResponse(string message)
        {
            return new GeneralResponse<T> { Success = false, Message = message, Data = default };
        }
    }
}
