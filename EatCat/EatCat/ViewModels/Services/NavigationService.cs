using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EatCat.ViewModels.Services
{
    public class NavigationService : INavigationService
    {
        public async Task NavigationItem(Alimentador alimentador)
        {
            await EatCat.App.Current.MainPage.Navigation.PushAsync(new PageDispenser(alimentador));
        }
    }
}
