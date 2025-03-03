using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace MAUISignUpProfile_Abimbomj
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState) 
        {
            return new Window(new AppShell());
        }
    }
}
