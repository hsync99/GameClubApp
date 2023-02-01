using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameClubApp.Models;
namespace GameClubApp.Services
{
    public interface IDataStore
    {
        Task<Users> Register(Users user);
        Task<Users> Logon(string username, string password);
    }
}
