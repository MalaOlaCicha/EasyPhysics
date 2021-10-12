using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using EasyPhysics_.Pages;
using EasyPhysics_.CollectionViewModel;

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

        /*
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
        */
    }
}
