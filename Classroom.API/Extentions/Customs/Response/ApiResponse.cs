namespace Classroom.API.Extentions.Customs.Response
{
    public class ApiResponse<T>
    {
        public int Code { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public List<string> Errors { get; set; }

        // list of errors
        public ApiResponse(List<string> errors , int code)
        {
            Code = code;
            Errors = new List<string>();
        }

        // get all data success
        public ApiResponse(T data, int code ,string message = null)
        {
            Code = code;
            IsSuccess = true;
            Message = message;
            Data = data;
        }

        // list of errorrs with message 
        public ApiResponse(string message, int code, List<string> errors = null)
        {
            Code = code;
            IsSuccess = false;
            Message = message;
            Data = default;
            Errors = errors ?? new List<string>();
        }
    }
}
