using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MalluConnect.Pages
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }
		void OnBackToLoginTextTapped(object sender, EventArgs args)
		{
			Navigation.PopModalAsync( true);
		}
		void Register_Clicked(object sender, System.EventArgs e)
		{
			Application.Current.MainPage = new HomePage();
		}
    }
}
