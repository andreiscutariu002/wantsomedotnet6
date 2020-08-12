using System;

namespace Week05.OOP2._0_Classes
{
    // Plase read: https://github.com/TelerikAcademy/Object-Oriented-Programming/tree/master/Topics/01.%20Defining-Classes-Part-1
    class Program
    {
        static void Main(string[] args)
        {
            // instance
            var user = new User("andreisct");

            var userName = user.GetUserName();
            user.SetUserName("new");

            var userNameV2 = user.UserName;
            user.UserName = "new2";

            Console.WriteLine(userName);

            var username3 = user.UserNameV3;
            user.UserNameV3 = "new3";
        }
    }

    public class Employee
    {
        public string Cnp { get; set; }

        public string Salary { get; set; }
    }

    // class 
    class User
    {
        // private field
        private string username;

        // constructor
        public User(string username)
        {
            this.username = username;
        }

        // v1 metoda de get
        public string GetUserName()
        {
            return this.username;
        }

        // v1
        public void SetUserName(string newUserName)
        {
            this.username = newUserName;
        }

        // v2 propritate de get si set pentru username field
        public string UserName
        {
            get { return this.username; }  // v2
            set { this.username = value; } // v2 // value = valoare asignata cand se face = pe propritate (e.g. new2)
        }

        // v3 Automatic Properties
        public string UserNameV3 { get; set; } //v3
        // get => pot sa citesc valuarea lui UserNameV3 in alta variabila
        // set => pot sa scriu o noua valuare pe UserNameV3
    }
}

