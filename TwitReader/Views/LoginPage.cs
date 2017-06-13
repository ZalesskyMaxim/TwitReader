﻿using System;
using TwitReader.ViewModels;
using Xamarin.Forms;

namespace TwitReader.View
{
    public class LoginPage : ContentPage
    {
        public LoginPage()
        {
            BindingContext = new LoginViewModel();
            Entry userNameEntry = new Entry { Placeholder = "Username" };
            userNameEntry.SetBinding(Entry.TextProperty, nameof(LoginViewModel.UserName));
            Entry passEntry = new Entry { Placeholder = "Password", IsPassword = true};
            passEntry.SetBinding(Entry.TextProperty, nameof(LoginViewModel.Password));
            Button loginButton = new Button { Text = "Login"};
            Content = new StackLayout
            {
                Children = {
                    new Label 
                    {
                        VerticalTextAlignment = TextAlignment.Start, 
                        HorizontalTextAlignment = TextAlignment.Center, 
                        Text = "Login Page" 
                    },
                    userNameEntry,
                    passEntry, 
                    loginButton
                }
            };
        }
    }
}
