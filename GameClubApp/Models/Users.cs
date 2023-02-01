using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClubApp.Models
{
    public  class Users
    {
        public string id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public Users()
        {

        }
        public Users(Models.Realm.Users users)
        {
            id = users.id;
            name = users.name;  
            username = users.username;  
            password = users.password;  
            email = users.email;    

        }
    }
}
