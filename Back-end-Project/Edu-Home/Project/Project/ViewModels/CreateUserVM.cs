using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.ViewModels
{
    public class CreateUserVM
    {
        [Required, StringLength(50)]
        public string Fullname { get; set; }
        [Required, StringLength(50)]
        public string Username { get; set; }
        [Required, EmailAddress, StringLength(100), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, StringLength(200), DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, StringLength(200), Compare(nameof(Password)), DataType(DataType.Password)]
        public string CheckPassword { get; set; }
        public string Role { get; set; }
    }
}
