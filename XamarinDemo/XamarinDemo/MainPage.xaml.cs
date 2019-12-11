using Android.OS;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinDemo
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        TextView txtNumber;

        int number;

        public MainPage()
        {
            InitializeComponent();

            button.Clicked += Button_Clicked;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string name = entry.Text;
            await DisplayAlert($"Hi {name}!", "Welcome to Xamarin App", "OK");
        }
    }
}
