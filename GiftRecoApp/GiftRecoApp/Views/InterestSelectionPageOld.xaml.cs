using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiftRecoApp.Models;
using GiftRecoApp.ViewModels;
using GiftRecoApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GiftRecoApp.Views
{
    public partial class InterestSelectionPage : ContentPage
    {
        InterestSelectionPage _viewModel;

        public InterestSelectionPage()
        {
            //InitializeComponent();

            BindingContext = _viewModel = new InterestSelectionPage();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}