using System.ComponentModel;
using TabbedApp.ViewModels;
using Xamarin.Forms;

namespace TabbedApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}