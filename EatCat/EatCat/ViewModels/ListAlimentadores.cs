using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EatCat.ViewModels
{
    public class ListAlimentadores
    {
        public ObservableCollection<Alimentador> Alimentadores
        {
            get;
            set;
        }

        public ListAlimentadores()
        {
                this.Alimentadores = new ObservableCollection<Alimentador>();
            this.Alimentadores.Add(new Alimentador{IdAlimentador = 1, NomeAlimentador = "Margot", StatusPrato = true, StatusReservatorio = false});
            this.Alimentadores.Add(new Alimentador{ IdAlimentador = 2, NomeAlimentador = "Docinho", StatusPrato = true, StatusReservatorio = false });
            this.Alimentadores.Add(new Alimentador{ IdAlimentador = 3, NomeAlimentador = "Marcela", StatusPrato = false, StatusReservatorio = false });
            this.Alimentadores.Add(new Alimentador{ IdAlimentador = 4, NomeAlimentador = "Rockefeller", StatusPrato = true, StatusReservatorio = false });
            this.Alimentadores.Add(new Alimentador{ IdAlimentador = 5, NomeAlimentador = "Betoveen", StatusPrato = true, StatusReservatorio = false });
        }
    }
}
