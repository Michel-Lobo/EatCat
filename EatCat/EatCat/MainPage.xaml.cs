
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
            this.Navigation.RemovePage(this);
            listViewDispenser.ItemSelected += (s, e) =>
            {
                listViewDispenser.SelectedItem = null;
            };
        }



        private void  ListViewDispenser_OnSelectedItem(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new PageDispenser());
       


        //    //DisplayAlert("Teste", "Você clicou no item - " + ((Alimentador)e.Item).NomeAlimentador, "Ok", "Cancel");
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PageDispenser());
        }
    }
}
