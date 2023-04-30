using System.ComponentModel;
using Translate.ViewModels;
using Xamarin.Forms;

namespace Translate.Views
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