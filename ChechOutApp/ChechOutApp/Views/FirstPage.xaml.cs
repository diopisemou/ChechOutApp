using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChechOutApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChechOutApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FirstPage : ContentPage
	{
	    public ContentPage previouscontent = new ContentPage();
	    public bool PayementIsSelected = false;
	    public bool DeliveryIsSelected = false;

        public FirstPage ()
		{
			InitializeComponent ();
		    PayementIsSelected = false;
		    DeliveryIsSelected = false;
            ListView lst = new ListView();

		}

	    public FirstPage(ContentPage a)
	    {
	        InitializeComponent();
	        ListView lst = new ListView();
	        PayementIsSelected = false;
	        DeliveryIsSelected = false;
            this.previouscontent = a;
	    }

        private void PayementBankTapGestureRecognizer_OnTapped(object sender, EventArgs e)
	    {
	        Frame senderFrame = (Frame)sender;
	        PayementOption shopi = new PayementOption("Bank Transfert",10,"bank_transfer.png");
	        senderFrame.HasShadow = true;
	        CreditCardFrame.HasShadow = false;
            //ItemPair bk = senderFrame.BindingContext as ItemPair;
	        PayementIsSelected = true;
            DisplayAlert("Frame Tapped ", "Payement Name : " + shopi.Name + " Payement Price : " + shopi.Price, "Ok");
	        
        }

	    private void PayementCreditTapGestureRecognizer_OnTapped(object sender, EventArgs e)
	    {
	        Frame senderFrame = (Frame)sender;
	        PayementOption shopi = new PayementOption("Bank Transfert", 20, "credit_card.png");
	        senderFrame.HasShadow = true;
	        BankTransfertFrame.HasShadow = false;
            //ItemPair bk = senderFrame.BindingContext as ItemPair;
	        PayementIsSelected = true;
            DisplayAlert("Frame Tapped ", "Payement Name : " + shopi.Name + " Payement Price : " + shopi.Price, "Ok");
	    }

        private void DeliveryExpressTapGestureRecognizer_OnTapped(object sender, EventArgs e)
	    {
	        Frame senderFrame = (Frame)sender;
	        DeliveryOption shopi = new DeliveryOption("Express Shipping", 70, "express_shipping.png");
	        senderFrame.HasShadow = true;
	        NormalShippingFrame.HasShadow = false;
            //ItemPair bk = senderFrame.BindingContext as ItemPair;
	        DeliveryIsSelected = true;
            DisplayAlert("Frame Tapped ", "Delivery Name : " + shopi.Name + " Delivery Price : " + shopi.Price, "Ok");
        }

	    private void DeliveryNormalTapGestureRecognizer_OnTapped(object sender, EventArgs e)
	    {
	        Frame senderFrame = (Frame)sender;
	        DeliveryOption shopi = new DeliveryOption("Normal Shipping", 35, "normal_shipping.png");
	        senderFrame.HasShadow = true;
	        ExpressShippingFrame.HasShadow = false;
            //ItemPair bk = senderFrame.BindingContext as ItemPair;
	        DeliveryIsSelected = true;
            DisplayAlert("Frame Tapped ", "Delivery Name : " + shopi.Name + " Delivery Price : " + shopi.Price, "Ok");
	    }
    }
}