using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class CategoryModel
    {

        [DisplayName("Title"), Required(ErrorMessage ="{0} cannot be empty!"), MaxLength(10,ErrorMessage = "A maximum of 10 characters must be entered!")]
        public string Title { get; set; }

        [DisplayName("Description"), Required(ErrorMessage = "{0} cannot be empty!"), MinLength(5, ErrorMessage = "At least {1} characters must be entered!"]
        public string Description { get; set; }

    }
}
