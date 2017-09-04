using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EatCat.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;

namespace EatCat
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageDispenser : ContentPage
	{
		public PageDispenser ()
		{
			InitializeComponent ();
		    BindingContext = new Alimentador();
		}

        private async void btnServirComida_Clicked(object sender, EventArgs e)
        {
            HttpClient cliente = new HttpClient();
            JObject jobject = new JObject();
            jobject.Add("in", true);

            cliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJleHAiOjE1MDI3NjIyNjgsImlhdCI6MTUwMjc1NTA2OCwidXNyIjoiTWljaGVsIn0.9yzuQiI81M2IKdprVI0OxDRP1SaNeOoyLTLVd0ehKhc");
            //cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(""));
            //cliente.DefaultRequestHeaders.AcceptCharset.Add(new StringWithQualityHeaderValue(""));
            var conteudo = new StringContent(jobject.ToString(), Encoding.UTF8, "application/json");
            HttpResponseMessage mensMessage = await cliente.PostAsync("https://api.thinger.io/v2/users/Michel/devices/Dispenser/servo/abrir_fechar", conteudo);
            
            //    //((Alimentador) e.Item).NavegarCommand((Alimentador) e.Item);
        }
    }
}