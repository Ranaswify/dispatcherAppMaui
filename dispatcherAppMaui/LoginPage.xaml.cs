using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;


namespace dispatcherAppMaui
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginPageViewModel();

        }
    }
}