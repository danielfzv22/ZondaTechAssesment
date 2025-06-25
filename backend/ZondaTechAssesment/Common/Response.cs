namespace ZondaTechAssesment.Common
{
    public class Response<T>
    {
        public T? Data { get; set; }

        public bool Success { get; set; } = true;

        public string Message { get; set; } = string.Empty;

        public Response() { }

        public Response(T data)
        {
            Data = data;
        }

        public Response(string message, bool success = false)
        {
            Message = message;
            Success = success;
        }
    }

}
