using System;
using System.Collections.Generic;
using System.Text;

namespace _15022022.Negocio
{
    class LoginService
    {
        string usernameValido = "admin";
        string passwordValido = "nimda";

        public bool check(string username, string password)
        {
            if (usernameValido == username &&
                passwordValido == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
