using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Adopt1Dave.ASP.Models.Forms
{
    public class RegisterForm
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ce champs est requis")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Ce champs est requis")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Ce champ est requis")]
        [EmailAddress]
        [MaxLength(255)]
        public string Email { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "Votre mot de passe doit contenir minimum 8 caractères")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Vos mots de passe ne correspondent pas")]
        [DataType(DataType.Password)]
        public string RePassword { get; set; }

    }
}
