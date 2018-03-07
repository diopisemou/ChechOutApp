using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChechOutApp.Models;
using ChechOutApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChechOutApp
{
	public partial class MainPage : ContentPage
	{
        public int PayementStep  ;
	    string inimgsource = "inactive_dot.png";
	    string acimgsource = "active_dot.png";

        public MainPage()
		{
			InitializeComponent();

            List< PayementOption> PayementOptions = new List<PayementOption>()
            {
                new PayementOption {ImageSource1 = "credit_card.png", Name = "Credit Card", Price = 0},
                new PayementOption {ImageSource1 = "bank_transfer.png", Name = "Bank Transfer", Price = 0},
            };

		    List<DeliveryOption> DeliveryOptions = new List<DeliveryOption>()
		    {
		        new DeliveryOption {ImageSource1 = "normal_shipping.png", Name = "Express", Price = 30},
		        new DeliveryOption {ImageSource1 = "express_shipping.png", Name = "Normal", Price = 10},
		    };

		    this.PayementStep = 0;

		    Step3Image.Source = this.acimgsource;
		    Step2Image.Source = this.acimgsource;
		    Step3Image.Source = this.acimgsource;

            switchsteps(this.PayementStep);
		    FirstPage a = new FirstPage();
		    CheckOutContentHolder.Content = a.Content;
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

	    private void switchsteps(int pstep,int backbtn = 0)
	    {
	        
	        switch (pstep)
	        {
                case 0:   
                    Step1Image.Source = this.acimgsource;
                    Step2Image.Source = this.acimgsource;
                    Step3Image.Source = this.acimgsource;
                    NextButton.Text = "NEXT";
                    pstep++;
                    this.PayementStep = pstep;
                    FirstPage a = new FirstPage();
                    CheckOutContentHolder.Content = a.Content;
                    //DisplayAlert("Etape =>"+pstep, "Etape 1 Effectue step = " + this.PayementStep, "Ok");
                    //this.payementStep = this.payementStep + backbtn;
                    if (this.PayementStep > 3 || this.PayementStep < 0)
                        this.PayementStep = 0;
                    break;
                case 1:
                    
                   
                    Step1Image.Source = this.inimgsource;
                    NextButton.Text = "NEXT";
                    pstep++;
                    this.PayementStep = pstep;
                    SecondPage aa = new SecondPage();
                    CheckOutContentHolder.Content = aa.Content;
                    //DisplayAlert("Etape 1", "Etape 1 Effectue step = "+this.PayementStep, "Ok");
                    if (this.PayementStep > 3 || this.PayementStep < 0)
                        this.PayementStep = 0;
                    break;
	            case 2:
	                
                    
	                Step2Image.Source = this.inimgsource;
	                NextButton.Text = "PAY";
	                pstep++;
                    this.PayementStep = pstep;
	                ThirdPage aaa = new ThirdPage();
	                CheckOutContentHolder.Content = aaa.Content;
	                //DisplayAlert("Etape 2", "Etape 2 Effectue step = " + this.PayementStep, "Ok");
                    if (this.PayementStep > 3 || this.PayementStep < 0)
	                    this.PayementStep = 0;
                    break;
	            case 3:
                    
	                Step3Image.Source = this.inimgsource;
	                NextButton.Text = "FINISH";
	                pstep++;
                    this.PayementStep = pstep;
	                //DisplayAlert("Etape 3", "Etape 3 Effectue step = " + this.PayementStep, "Ok");
                    if (this.PayementStep > 3 || this.PayementStep < 0)
	                    this.PayementStep = 0;
                    break;
                default:
                    DisplayAlert("Erreur", "Erreur dans le processus de paiment", "Ok");
                    break;

            }
	    }

	    private void BackButton_OnPressed(object sender, EventArgs e)
	    {
	        //DisplayAlert("BackButton", "BackButton Pressed", "Ok");
	        int pstep = this.PayementStep - 2;
            switchsteps(pstep);
        }

	    private void NextButton_OnPressed(object sender, EventArgs e)
	    {
            //DisplayAlert("NextButton", "NextButton Pressed", "Ok");
	        int pstep = this.PayementStep;
            switchsteps(pstep);
            

	    }
	}
}
