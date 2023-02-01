using GameClubApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Realms;
using Windows.Management;

namespace GameClubApp.Services
{
    public class DataStore : IDataStore
    {
       
        public async Task<Users> Logon(string username, string password)
        {
            Models.Realm.Users ruser = new Models.Realm.Users();
            Users u = new Users();
            try
            {
                using (Realm realm = Realm.GetInstance())
                {
                    ruser = realm.All<Models.Realm.Users>().Where(x => x.username == username).First();

                }
                u.id = ruser.id;
                u.username = ruser.username;
                u.email = ruser.email;
                u.password = ruser.password;
                u.name = ruser.name;
            }
            catch (Exception e)
            {
                return null;
            }
            if(password == u.password)
            {
                return u;
            }
            else
            {
                return null;
            }

        }

        public async Task<Users> Register(Users user)
        {
            Users u= new Users();
            
            try
            {
                using (Realm realm = Realm.GetInstance())
                {
                    realm.Write(() =>
                    {
                        realm.Add(new Models.Realm.Users(u), true);
                    });
                }
                return user;
            }

            catch(Exception e)
            {
                throw new Exception();
            }
        }
        public List<Users> GetUsers()
        {
           List<Models.Realm.Users> ulist = new List<Models.Realm.Users>(); 
            List<Users> uiusers = new List<Users>(); 
            Users users= new Users();
            try
            {
                using (Realm realm = Realm.GetInstance())
                {
                   ulist =   realm.All<Models.Realm.Users>().ToList();
                  
                }
            }
            catch (Exception e)
            {
                return null;
            }
            if (ulist.Count > 0)
            {
                foreach(var u in ulist)
                {

                    users.id = u.id ?? "";
                    users.name= u.name ?? "";
                    users.email= u.email ?? "";
                    users.password= u.password ?? "";
                   users.username = u.username ?? "";
                    uiusers.Add(users);
                }

            }
            return uiusers;
        }
        public  Users GetUserById(string id)
        {
            Models.Realm.Users ruser= new Models.Realm.Users();
            Users u = new Users();
            try 
            {
                using (Realm realm = Realm.GetInstance())
                {
                    ruser = realm.All<Models.Realm.Users>().Where(x => x.id == id).First();

                }
                u.id = ruser.id;
                u.username = ruser.username;
                u.email = ruser.email;
                u.password = ruser.password;
                u.name = ruser.name;
            }
            catch (Exception e)
            {
                return null;
            }
              
            return u;    
        }
    }
}
