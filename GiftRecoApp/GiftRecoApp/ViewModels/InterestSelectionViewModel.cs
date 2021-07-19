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
        public Interest _interest;
        public Interest[] selectedInterests = new Interest[3];
        public string interests;

        public InterestSelectionViewModel()
        {
            
        }

        public Interest[] Interests
        {
            get => selectedInterests;
            set => SetProperty(ref selectedInterests, value);
        }
    }
}
