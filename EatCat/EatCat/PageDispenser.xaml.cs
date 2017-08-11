using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EatCat.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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

	    public PageDispenser(Alimentador alimentador)
	    {
	        InitializeComponent();
	        BindingContext = new Alimentador();
        }
	}
}