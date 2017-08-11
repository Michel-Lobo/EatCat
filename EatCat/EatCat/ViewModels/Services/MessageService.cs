using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EatCat.ViewModels.Services
{
    public class MessageService: IMessageService
    {
        public async Task ShowAsync(string message)
        {
           await EatCat.App.Current.MainPage.DisplayAlert("EatCat", message, "Ok");
        }

        public MessageService()
        {
                
        }
    }
}
