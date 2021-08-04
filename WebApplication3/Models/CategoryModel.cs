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

        [DisplayName("Title"), Required(ErrorMessage ="{0} cannot be empty!"), MaxLength(10,ErrorMessage = "A maximum of {1} characters must be entered in {0}!")]
        public string Title { get; set; }

        [DisplayName("Description"), Required(ErrorMessage = "{0} cannot be empty!"), MinLength(5, ErrorMessage = "At least {1} characters must be entered in {0}!")]
        public string Description { get; set; }

        
        [Range(10,100, ErrorMessage = "A number between {1} and {2} must be entered! ")]
        public int Hit { get; set; }

        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password and password repetition are not the same! ")]
        public string RePassword { get; set; }

    }
}
