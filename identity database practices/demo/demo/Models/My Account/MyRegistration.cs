using System.ComponentModel.DataAnnotations;

namespace demo.Models.My_Account
{
    public class MyRegistration
    {
        [Required]
        public string UserName {get;set;}
        [Required]
        public string Password { get; set; }
    }
}
