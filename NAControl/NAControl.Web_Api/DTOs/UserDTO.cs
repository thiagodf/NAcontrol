using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NAControl.Web_Api.DTOs
{
    public class UserDTO
    {
        public Guid UseId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}