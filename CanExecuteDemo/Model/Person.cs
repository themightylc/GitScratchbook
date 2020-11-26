using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanExecuteDemo.Model
{
    class Person: ObservableObject
    {
        
        public string GivenName { get; set; }
        public string FamilyName { get; set; }

        private int _Gender = 0;
        public int Gender { get { return _Gender; } set { this.Set(() => Gender, ref _Gender, value);  } }
    }
}
