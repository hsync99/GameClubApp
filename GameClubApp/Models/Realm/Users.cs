using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Realms;
using Windows.Storage;

namespace GameClubApp.Models.Realm
{
    public class Users:RealmObject
    {
        [PrimaryKey]
        public string id { get; set; }
        public string name { get; set; }    
        public string username { get; set; }
        public string password { get; set; }    
        public string email { get; set; }   

        public Users()
        {

        }
        public Users(Models.Users users)
        {
            id = users.id;
            name = users.name;
            username = users.username;
            password = users.password;
            email = users.email;
        }

    }

}
