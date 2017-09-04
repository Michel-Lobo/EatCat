using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EatCat.ViewModels
{
    public class LoginViewModel: BaseViewModel
    {
        private string _userName;
        private string _password;
        public ICommand LogarCommand { get; private set; }
        public UserViewModel User { get; private set; }
        private readonly Services.INavigationService _navigationService;
        private readonly Services.IMessageService _messageService;

        public string Password
        {
            get { return _password; }
            set { _password = value; OnPropertyChanged(); }
        }


        public string UserName
        {
            get { return _userName; }
            set { _userName = value; OnPropertyChanged(); }
        }
        public LoginViewModel()
        {
            this.LogarCommand = new Command(LogarAsync);
        }

        private async void LogarAsync()
        {
            HttpClient cliente = new HttpClient();
            JObject jobject = new JObject();
            jobject.Add("username", UserName);
            jobject.Add("password", Password);
            jobject.Add("grant_type", "password");

            //cliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJleHAiOjE1MDI3NjIyNjgsImlhdCI6MTUwMjc1NTA2OCwidXNyIjoiTWljaGVsIn0.9yzuQiI81M2IKdprVI0OxDRP1SaNeOoyLTLVd0ehKhc");
            //cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(""));
            //cliente.DefaultRequestHeaders.AcceptCharset.Add(new StringWithQualityHeaderValue(""));
            var conteudo = new StringContent("grant_type=password&username=" + UserName + "&password=" + Password, Encoding.UTF8, "application/x-www-form-urlencoded");
            try{
                Task<HttpResponseMessage> mensMessage = cliente.PostAsync("http://10.0.0.101/painel_iot_auth/token", conteudo);
                string resultado = await mensMessage.Result.Content.ReadAsStringAsync();
                string token = JsonConvert.DeserializeObject<UserViewModel>(mensMessage.Result.Content.ToString()).Token;
            }
            catch(HttpRequestException ex)
            {

            }
                        
        }
    }
} 
