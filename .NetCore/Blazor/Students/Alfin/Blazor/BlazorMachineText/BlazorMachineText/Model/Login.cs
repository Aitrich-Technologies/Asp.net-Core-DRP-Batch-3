using System.ComponentModel.DataAnnotations;

namespace BlazorMachineText.Model
{
    public class Login
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
