using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NAControl.Api.Models
{
    public class ApiUsuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string ConfirmaSenha { get; set; }
    }
}