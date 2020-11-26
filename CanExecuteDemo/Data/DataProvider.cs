using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanExecuteDemo.Data
{
    class DataProvider
    {
        private static List<Model.Person> _Persons;
        public static IEnumerable<Model.Person> Persons
        {
            get
            {
                if (_Persons == null)
                {
                    _Persons = new List<Model.Person>
                    {
                        new Model.Person() { FamilyName = "Green", GivenName = "Maria", Gender = 1 },
                        new Model.Person() { FamilyName = "Green", GivenName = "Peter", Gender = 2 }
                    };
                }
                return _Persons;
            }
        }


    }
}
