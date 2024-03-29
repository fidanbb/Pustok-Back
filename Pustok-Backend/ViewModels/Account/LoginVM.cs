﻿using System.ComponentModel.DataAnnotations;

namespace Pustok_Backend.ViewModels.Account
{
    public class LoginVM
    {
        [Required]
        public string EmailOrUsername { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool IsRememberMe { get; set; }
    }
}
