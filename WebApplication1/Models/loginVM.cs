using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class loginVM
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
