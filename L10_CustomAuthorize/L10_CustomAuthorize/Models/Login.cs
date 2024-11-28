﻿using System.ComponentModel.DataAnnotations;

namespace L10_CustomAuthorize.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Email không được để trống")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password không được để trống")]
        public string Password { get; set; }
    }
}
