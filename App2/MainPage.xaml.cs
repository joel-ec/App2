using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Handle_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SecondPage());
        }
        private async void Handle_Clicked1(object sender, EventArgs f)
        {
            await Navigation.PushAsync(new ThirdPage());
        }
        private async void Handle_Clicked2(Object sender, EventArgs g)
        {
            await Navigation.PushAsync(new FourthPage());
        }
    }
}
