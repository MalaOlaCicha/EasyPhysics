using System;
using EasyPhysics_.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace EasyPhysics_
{
    public partial class App : Application
    {
        public static string DatabaseLocation = string.Empty;
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
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
