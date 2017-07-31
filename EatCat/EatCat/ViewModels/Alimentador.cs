using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EatCat.ViewModels
{
    public class Alimentador : BaseViewModel
    {
        private bool _statusReservatorio;
        private string _nomeAlimentador;
        private int _idAlimentador;
        private bool _statusPrato;

        public int IdAlimentador
        {
            get { return _idAlimentador; }
            set
            {
                _idAlimentador = value; 
                OnPropertyChanged();
            }
        }

        public string NomeAlimentador
        {
            get { return _nomeAlimentador; }
            set
            {
                _nomeAlimentador = value;
                OnPropertyChanged();
            }
        }

        public bool StatusReservatorio
        {
            get { return _statusReservatorio; }
            set
            {
                _statusReservatorio = value;
                OnPropertyChanged();
            }
        }

        public bool StatusPrato
        {
            get { return _statusPrato; }
            set
            {
                _statusPrato = value;
                OnPropertyChanged();
            }
        }


    }
}
