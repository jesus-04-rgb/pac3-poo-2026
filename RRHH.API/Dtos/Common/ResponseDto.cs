namespace RRHH.API.Dtos.Employees
{
    public class ResponseDtos<T>
    {
        public int StatusCode { get; set; }

        public bool Status { get; set; }

        public string? Message { get; set; }

        public T? Data { get; set; }   
    }
}