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
        public ObservableCollection<string> Items { get; set; }
        
        private int selectedCount = 0;

        private Interest[] temp = new Interest[3];

        public InterestSelectionPage()
        {
            InitializeComponent();

            //InterestSelectionViewModel isvm = this.get

            Items = new ObservableCollection<string>
            {
                "Item 1",
                "Item 2",
                "Item 3",
                "Item 4",
                "Item 5"
            };

            MyListView.ItemsSource = Items;

            //CheckBox cb = new CheckBox();
            //cb.IsChecked = false;
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
