using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginDemoApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Después del login nos direccionamos al HOME

            MainPage = MainPage = new NavigationPage(new MainPage());

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
