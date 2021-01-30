using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;


namespace UserApplication
{
    class User
    {
        
        private int id { get; set; }
        private string email, login, pass;
        
        public string Login { get; set; }

        public string Pass { get; set; }

        public string Email { get; set; }

        public User() { }
        public User(string login, string pass, string email)
        {
            this.Login = login;
            this.Pass = pass;
            this.Email = email;

        }
    }
}
