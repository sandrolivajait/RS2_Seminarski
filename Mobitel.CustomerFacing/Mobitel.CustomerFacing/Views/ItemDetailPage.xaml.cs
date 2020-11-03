using System.ComponentModel;
using Xamarin.Forms;
using Mobitel.CustomerFacing.ViewModels;

namespace Mobitel.CustomerFacing.Views
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