using System.ComponentModel;
using GiftRecoApp.ViewModels;
using Xamarin.Forms;

namespace GiftRecoApp.Views
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