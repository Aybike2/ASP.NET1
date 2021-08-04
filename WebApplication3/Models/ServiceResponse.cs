using Newtonsoft.Json;
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public class ServiceResponse<T> : BaseResponse
    {
        [JsonProperty]
        public T Entity { get; set; }

        [JsonProperty]
        public List<T> Entities { get; set; }

        public ServiceResponse()
        {
            Errors = new List<string>();
            Entities = new List<T>();
        }
    }

}
