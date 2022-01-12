using dispatcherAppMaui.Models;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace dispatcherAppMaui
{
    internal class LoginPageViewModel : BindableObject
    {
        APIServices userService = new APIServices();
        ICommand loginCommand;
        public ICommand LoginCommand => loginCommand ??= new Command(PostUser);

        private async void PostUser()
        {
            try
            {
                LoginPageModel userModel = new LoginPageModel()
                {
                    username = userNameText,
                    password = passwordEntryText,
                    IsDispatcherLogin = true,
                    grant_type = "password",
                    clientId = "3",
                    secret = "d",
                };
               var result= await userService.PostUserToAPI(userModel);
               
            }
            catch (Exception ex)
            {

            }
           
        }
        string passwordEntryText;
        public string PasswordEntryText

        {
            set
            {
                if (passwordEntryText == value)
                    return;
                passwordEntryText = value;
                OnPropertyChanged();
            }
            get { return passwordEntryText; }
        }

        string userNameText;
        public string UserNameText

        {
            set
            {
                if (userNameText == value)
                    return;
                userNameText = value;
                OnPropertyChanged();
            }
            get { return userNameText; }
        }
    }
}
