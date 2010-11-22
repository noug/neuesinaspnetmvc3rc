using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace NewInMVC3.Models
{
    public class NewPersonModel
    {
        [Remote("ValidateUser", "Validation",
            ErrorMessage = "Name darf keine Leerstellen enthalten")]
        [Required]
        public string Name { get; set; }

        [Remote("ValidatePassword", "Validation",
            HttpMethod = "post",
            ErrorMessage = "Das Kennwort ist zu kurz",
            Fields="PasswordConfirm,Name"
            )]
        [Required]
        public string Password { get; set; }

        [Compare("Password")]
        public string PasswordConfirm { get; set; }
    }
}