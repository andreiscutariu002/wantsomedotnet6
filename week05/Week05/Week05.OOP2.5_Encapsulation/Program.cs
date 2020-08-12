using System;

namespace Week05.OOP2._5_Encapsulation
{
    using System.Collections.Generic;

    public class User
    {
        private string userName;

        private string password;

        public string Password2 { get; private set; }

        private List<string> oldPasswords;

        public User(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
            this.oldPasswords = new List<string>();
        }

        public void ChangePassword(string oldPassword, string newPassword)
        {
            if (CheckPassword(oldPassword))
            {
                StoreOldPassword(oldPassword);

                this.password = newPassword;
            }
        }

        private bool CheckPassword(string oldPassword)
        {
            if (this.password == oldPassword)
            {
                return true;
            }

            return false;
        }

        private void StoreOldPassword(string oldPassword)
        {
            this.oldPasswords.Add(oldPassword);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("1234", "2134");

            user.ChangePassword("2134", "1234");

            var p = user.Password2;

            // error due to private set
            //user.Password2 = "new password";

            Console.WriteLine("Hello World!");
        }
    }
}
