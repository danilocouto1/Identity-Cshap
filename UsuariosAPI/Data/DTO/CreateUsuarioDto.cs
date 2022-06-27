﻿using System.ComponentModel.DataAnnotations;

namespace UsuariosAPI.Data.DTO
{
    public class CreateUsuarioDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string PasswordConfirmation { get; set; }
    }
}
