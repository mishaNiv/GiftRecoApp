using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using GiftRecoApp.Models;
using Xamarin.Forms;

namespace GiftRecoApp.ViewModels
{
    public class InterestSelectionViewModel : BaseViewModel
    {
        private Interest _interest;

        private string interest;

        public InterestSelectionViewModel(Interest pInterest)
        {
            this._interest = pInterest;

            interest = _interest.interest;
        }

        public string mainInterest
        {
            get => interest;
            set => SetProperty(ref interest, value);
        }
    }
}
