using System;
using System.Collections.Generic;

namespace BankLib
{
    public class LoginUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserLogin(string name, string password)
        {
            List<LoginUser> login = new List<LoginUser>()
            {
                new LoginUser {UserName = "Ram", Password = "Ram123"},
            };
            string result = "";
            foreach (var u in login)
            {
                if ((u.UserName == name) && (u.Password == password))
                {
                    result = "Login Succesfull";
                }
                else
                {
                    result = "Login UnSuccesfull";
                }
            }
            return result;
        }
    }
}
