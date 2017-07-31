using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EatCat.ViewModels;
using Xamarin.Forms;

namespace EatCat
{
	public partial class MainPage : ContentPage
	{
        private  ListAlimentadores _listAlimentadores = new ListAlimentadores();
		public MainPage()
		{
			InitializeComponent();
		    BindingContext = this._listAlimentadores;
		}

	}
}
