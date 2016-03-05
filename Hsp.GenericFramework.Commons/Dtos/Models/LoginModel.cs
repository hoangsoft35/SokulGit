using System.ComponentModel.DataAnnotations;

namespace Hsp.GenericFramework.Commons.Dtos.Models
{
    public class LoginModel
    {
        [Required]
        [Display(Name = "User name ")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
