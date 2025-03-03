using Microsoft.Maui.Controls;
using System;

namespace MAUISignUpProfile_Abimbomj.Views
{
    public partial class SignupPage : ContentPage
    {
        public SignupPage()
        {
            InitializeComponent();
        }

        private async void OnSignupClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string email = EmailEntry.Text;
            string password = PasswordEntry.Text;
            string confirmPassword = ConfirmPasswordEntry.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                ErrorLabel.Text = "All fields are required.";
                ErrorLabel.IsVisible = true;
                return;
            }

            if (password != confirmPassword)
            {
                ErrorLabel.Text = "Passwords do not match.";
                ErrorLabel.IsVisible = true;
                return;
            }

            // Navigate to ProfilePage with query parameters
            await Shell.Current.GoToAsync($"//profile?username={Uri.EscapeDataString(username)}&email={Uri.EscapeDataString(email)}");
        }
    }
}
