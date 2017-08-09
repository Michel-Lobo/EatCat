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
        public ICommand AbrirCommand { get; private set; }
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
                AbrirCommand = new Command(AbrirPortaDispenser);
                this._messageService = DependencyService.Get<Services.IMessageService>();
        }

        private async void AbrirPortaDispenser()
        {
            await _messageService.ShowAsync("Teste");
        }
    }
}
