using System;
using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models
{
    public class IdentityLoginUserViewModel
    {
        [Required]
        [Display(Description = "E-mail", Prompt = "E-mail")]
        public string Email { get; set; }
        [Required]
        [Display(Description = "Senha", Prompt = "Senha")]
        public string Password { get; set; }
    }
}