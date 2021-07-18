using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using GiftRecoApp.Models;
using Xamarin.Forms;

//currently this page is identical to InterestSelectionViewModel, but was created incase the Interest class includes an [] of subinterests

namespace GiftRecoApp.ViewModels
{
      public class InterestViewModel : BaseViewModel
    {
        private Interest _interest;

        private string interest;

        public InterestViewModel(Interest pInterest)
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
