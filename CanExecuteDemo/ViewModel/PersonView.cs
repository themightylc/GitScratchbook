using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CanExecuteDemo.ViewModel
{
    class PersonView : ViewModelBase
    {
        private Model.Person _MyModel;

        public PersonView(Model.Person model)
        {
            this._MyModel = model;
        }

        public string GivenName { get { return _MyModel.GivenName; } set { _MyModel.GivenName = value; } }
        public string FamilyName { get { return _MyModel.FamilyName; } set { _MyModel.GivenName = value; } }

        public string Gender
        {
            get
            {
                if (_MyModel.Gender == 0) { return "unknown"; }
                if (_MyModel.Gender == 1) { return "female"; }
                if (_MyModel.Gender == 2) { return "male"; }
                if (_MyModel.Gender == 3) { return "diverse"; }
                return "error";
            }
            set
            {
                if (value == "unknown") _MyModel.Gender = 0;
                if (value == "female") _MyModel.Gender = 1;
                if (value == "male") _MyModel.Gender = 2;
                if (value == "diverse") _MyModel.Gender = 3;
            }
        }

        public ICommand DisplayGenderValueCommand { get { return new RelayCommand(this.DisplayGenderValueExecute, this.DisplayGenderValueCanExecute); } }

        private void DisplayGenderValueExecute()
        {
            MessageBox.Show($"Gender {this.Gender} has a model value of {this._MyModel.Gender}");
        }

        private bool DisplayGenderValueCanExecute()
        {
            return this._MyModel.Gender > 0;
        }
    }
}
