
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



        private void  ListViewDispenser_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            //HttpClient cliente = new HttpClient();
            //JObject jobject = new JObject();
            //jobject.Add("IdAlimentador", ((Alimentador)e.Item).IdAlimentador);

            //cliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJleHAiOjE0ODYwNDkxNTcsImlhdCI6MTQ4NjA0MTk1NywidXNyIjoianQifQ.pkyG43xiEhDtUHLxuycYv156FGuvNh6nDKQ07kGcaGk");
            ////cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(""));
            ////cliente.DefaultRequestHeaders.AcceptCharset.Add(new StringWithQualityHeaderValue(""));
            //var conteudo = new StringContent(jobject.ToString(), Encoding.UTF8, "application/json");
            //HttpResponseMessage mensMessage = await cliente.PostAsync("https://api.thinger.io/v2/users/Michel/devices/dispenser/abrir_fechar", conteudo);

            //((Alimentador) e.Item).NavegarCommand((Alimentador) e.Item);


            //DisplayAlert("Teste", "Você clicou no item - " + ((Alimentador)e.Item).NomeAlimentador, "Ok", "Cancel");
        }
    }
}
