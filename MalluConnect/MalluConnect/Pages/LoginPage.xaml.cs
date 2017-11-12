using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MalluConnect.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        void OnSignUpTextTapped(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new RegisterPage(),true);
        }

        void SignIn_Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new HomePage();
        }
    }
}
