using BlazorMobileUWPHybridTest.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace BlazorMobileUWPHybridTest.Views
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