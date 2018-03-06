using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChechOutApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    private void TapGestureRecognizer_OnTappedHome(object sender, EventArgs e)
	    {
	        DisplayAlert("Home", "Home Button Tapped", "Ok");
	    }

	    private void TapGestureRecognizer_OnTappedSearch(object sender, EventArgs e)
	    {
	        DisplayAlert("Search", "Search Button Tapped", "Ok");
	    }

	    private void TapGestureRecognizer_OnTappedMenu(object sender, EventArgs e)
	    {
	        DisplayAlert("Menu", "Menu Button Tapped", "Ok");
	    }

	    private void TapGestureRecognizer_OnTappedCart(object sender, EventArgs e)
	    {
	        DisplayAlert("Cart", "Cart Button Tapped", "Ok");
	    }

	    private void TapGestureRecognizer_OnTappedAccount(object sender, EventArgs e)
	    {
	        DisplayAlert("Account", "Account Button Tapped", "Ok");
	    }

    }
}
