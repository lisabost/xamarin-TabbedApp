using System;
using System.Collections.Generic;
using System.ComponentModel;
using TabbedApp.Models;
using TabbedApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedApp.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}