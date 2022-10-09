using System;
using Xamarin.Forms;

namespace EasyPhysics_
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }        

        private async void Kinematyka_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.KinematykaPage());
        }
        private async void Termodynamika_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.TermodynamikaPage());
        }

        private async void Optyka_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.OptykaPage());
        }

        private async void Magnetyzm_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.MagnetyzmPage());
        }

        private async void Elektrycznosc_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.ElektrycznoscPage());
        }

        private async void Drgania_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.DrganiaPage());
        }
    }
}
