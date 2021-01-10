using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    public class LoginVM
    {
        [Required,EmailAddress,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, StringLength(200),DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name ="RememberMe")]
        public bool RememberMe { get; set; }
        public string Role { get; set; }
    }
}
