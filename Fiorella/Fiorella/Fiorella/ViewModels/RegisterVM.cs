using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.ViewModels
{
    public class RegisterVM
    {
        [Required(ErrorMessage ="Required Username")]
        public string Username { get; set; }
        [Required(ErrorMessage="Required Email"),DataType(DataType.EmailAddress,ErrorMessage ="Please, enter your email in correct form"),EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage ="Add your password"),DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage ="Please, confirm password"), DataType(DataType.Password),Compare(nameof(Password),ErrorMessage="Please, confirm password")]
        public string Confirm_password { get; set; }
    }
}
