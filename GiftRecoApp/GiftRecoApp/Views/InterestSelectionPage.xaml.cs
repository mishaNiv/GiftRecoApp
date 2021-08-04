using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GiftRecoApp.Models;
using GiftRecoApp.ViewModels;

namespace GiftRecoApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InterestSelectionPage : ContentPage
    {
        private InterestSelectionViewModel _viewModel;

        public InterestSelectionPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new InterestSelectionViewModel();

s            MyListView.ItemsSource = _viewModel.Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            string testArr = InterestSelectionViewModel.ISViewModel(sender, e);

            //CheckBox cb = (CheckBox)sender;

            //if (e.Value == false)
            //{
            //this.selectedCount--;
            //}
            //else
            //{
            //this.selectedCount++;
            //}

            //string bc = (string)cb.BindingContext;

            lbl_selectedCount.Text = testArr;

            
        }
    }
}
