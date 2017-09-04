using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace EatCat.ViewModels
{
    public class Alimentador : BaseViewModel
    {
        private bool _statusReservatorio;
        private string _nomeAlimentador;
        private int _idAlimentador;
        private bool _statusPrato;
        public ICommand NavegarCommand { get; private set; }
        private readonly Services.INavigationService _navigationService;
        private readonly Services.IMessageService _messageService;

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

        public Alimentador()
        {
            this.NavegarCommand = new Command(Navegar);
            this._messageService = DependencyService.Get<Services.IMessageService>();
            this._navigationService = DependencyService.Get<Services.INavigationService>();
        }

        private void Navegar()
        {
            this._messageService.ShowAsync("teste");
        }
    }
}
