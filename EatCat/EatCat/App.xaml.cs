using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace EatCat
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            DependencyService.Register<ViewModels.Services.IMessageService, ViewModels.Services.MessageService>();
			MainPage = new NavigationPage(new EatCat.MainPage());
            
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
