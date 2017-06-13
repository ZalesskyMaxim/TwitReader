using System;

using Xamarin.Forms;

namespace TwitReader.View.Base
{
    public class BasePage : ContentPage
    {
        public BasePage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

