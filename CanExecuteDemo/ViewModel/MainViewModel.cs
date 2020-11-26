using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanExecuteDemo.ViewModel
{
    class MainViewModel
    {
        private MainViewModel()
        {
        }

        public IEnumerable<PersonView> PersonViews { 
            get {
                return from PersonModel in Data.DataProvider.Persons select new PersonView(PersonModel);
            }
        }
        private static MainViewModel _Instance;
        public static MainViewModel Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new MainViewModel();
                }
                return _Instance;
            }
        }

    }

}
