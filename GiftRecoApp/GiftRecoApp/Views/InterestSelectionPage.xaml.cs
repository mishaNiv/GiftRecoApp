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

            MyListView.ItemsSource = _viewModel.Items;
        }
        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            string testArr = this._viewModel.OnCheckedChanged(sender, e);
            lbl_selectedCount.Text = testArr;
        }
    }
}
