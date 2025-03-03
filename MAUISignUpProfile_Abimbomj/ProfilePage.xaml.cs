using Microsoft.Maui.Controls;
using System;

namespace MAUISignUpProfile_Abimbomj.Views
{
    [QueryProperty(nameof(Username), "username")]
    [QueryProperty(nameof(Email), "email")]
    public partial class ProfilePage : ContentPage
    {
        private string username = string.Empty;
        private string email = string.Empty;

        public string Username
        {
            set
            {
                username = Uri.UnescapeDataString(value);
                UsernameLabel.Text = username;
            }
        }

        public string Email
        {
            set
            {
                email = Uri.UnescapeDataString(value);
                EmailLabel.Text = email;
            }
        }

        public ProfilePage()
        {
            InitializeComponent();
        }

        private async void OnSignOutClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//signup");
        }
    }
}
