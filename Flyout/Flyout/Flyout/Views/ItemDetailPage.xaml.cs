using Flyout.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Flyout.Views
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