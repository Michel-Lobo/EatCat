using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using EatCat.ViewModels;
using Newtonsoft.Json;
using Org.Apache.Http.Client.Methods;
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



        private async Task ListViewDispenser_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            HttpClient cliente = new HttpClient();

            //cliente. = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJleHAiOjE0ODYwNDkxNTcsImlhdCI6MTQ4NjA0MTk1NywidXNyIjoianQifQ.pkyG43xiEhDtUHLxuycYv156FGuvNh6nDKQ07kGcaGk";
            cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(""));
            cliente.DefaultRequestHeaders.AcceptCharset.Add(new StringWithQualityHeaderValue(""));
            HttpRequestMessage mensMessage = await cliente.PostAsync("", new StringContent("", Encoding.UTF8, ""));




            DisplayAlert("Teste", "Você clicou no item - " + ((Alimentador)e.Item).NomeAlimentador, "Ok", "Cancel");
        }
    }
}
