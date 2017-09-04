using System;
using System.Collections.Generic;
using System.Text;

namespace EatCat.ViewModels
{
    public class UserViewModel: BaseViewModel
    {
        private string _nome;
        private string _email;
        private string _token;

        public string Token
        {
            get { return _token; }
            set { _token = value; OnPropertyChanged(); }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; OnPropertyChanged(); }
        }

        public string Nome {
            get { return _nome; }
            set { _nome = value; OnPropertyChanged(); } }

    }
}
