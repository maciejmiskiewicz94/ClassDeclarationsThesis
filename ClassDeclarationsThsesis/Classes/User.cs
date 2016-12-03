using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassDeclarationsThsesis.Classes
{
    public class User
    {
        public string name;
        public string surname;
        public int user_id;
        public int user_type;
        public string email;
        public string password;
        public User(string name, string surname, int user_id, int user_type, string email, string password)
        {
            this.name = name;
            this.surname = surname;
            this.user_id = user_id;
            this.user_type = user_type;
            this.email = email;
            this.password = password;
        }
        public string setPassword(string password)
        {
            this.password = password;
            return password;
        }
    }
}