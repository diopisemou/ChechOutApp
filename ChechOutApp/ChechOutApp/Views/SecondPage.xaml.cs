using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChechOutApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SecondPage : ContentPage
	{
	    public ContentPage previouscontent = new ContentPage();
	    public bool FormIsValid = false;

        public SecondPage ()
		{
			InitializeComponent ();
		    FormIsValid = false;
        }

	    public SecondPage(ContentPage a)
	    {
	        InitializeComponent();
	        this.previouscontent = a;
	        FormIsValid = false;

        }
    }
}