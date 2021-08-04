using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class BaseResponse
    {
        public List<string> Errors { get; set; }

        public bool HasError { get; set; }
        public bool IsSuccessFul { get; set; }
    }

}
