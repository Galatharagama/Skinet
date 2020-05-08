using System.Collections.Generic;

namespace API.Errors
{
    public class ApivalidationErrorResponse : ApiResponse
    {
        public ApivalidationErrorResponse() : base(400)
        {
        }

        public IEnumerable<string> Errors {get; set; }
    }
}