using System;
using Xamarin.Forms;

namespace ChatbotUI.Views
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Logged In", "Successfull", "OK");
        }

    }
}
