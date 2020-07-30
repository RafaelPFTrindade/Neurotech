using System;
using System.Collections.Generic;
using System.Text;

namespace Neurotech.Domain.Models
{
    public class AuthenticationVO 
    {
        public AuthenticationVO(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public string Login { get; set; }

        public string Password { get; set; }
    }
}
