﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Blazor_Catalogo.Shared.Models
{
    public class UserInfo
    {
        [Required(ErrorMessage ="Informe o email")]
        [EmailAddress(ErrorMessage = "Formato do email inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Informe a senha")]
        public string Password { get; set; }
    }
}