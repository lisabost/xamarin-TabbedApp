using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedApp.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private async void Bmi_Navigate_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BmiCalculator());
        }

        private async void Personality_Navigation_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TrueFalseQuiz());
        }
    }
}