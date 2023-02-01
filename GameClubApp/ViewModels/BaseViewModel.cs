using GameClubApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClubApp.ViewModels
{
    public class BaseViewModel
    {
       protected IDataStore DataStore { get; }

        public BaseViewModel(IDataStore dataStore)
        {
            DataStore = dataStore;
        }
        public BaseViewModel()
        {
          
        }
    }
}
