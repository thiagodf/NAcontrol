using System;

namespace NAControl.Business.DTOs
{
    public class UserDTO
    {
        public Guid UseId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}