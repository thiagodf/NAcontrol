﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NAControl.WebApi.Models.Account
{
    public class RegisterUserModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}