namespace API.Errors
{
    public class ApiException
    {
        public ApiException(int statusCode, string message=null, string detials=null){
            StatusCode = statusCode;
            Message = message;
            Details = detials;
        }
        public int StatusCode {get; set;}

        public string Message {get; set;}
        public string Details {get;set;}


    }
}