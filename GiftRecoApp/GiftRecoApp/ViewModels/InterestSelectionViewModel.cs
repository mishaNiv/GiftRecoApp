using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using GiftRecoApp.Models;
using Xamarin.Forms;

namespace GiftRecoApp.ViewModels
{
    public class InterestSelectionViewModel : BaseViewModel
    {
        public Interest _interest;
        public static Interest[] selectedInterests = new Interest[3];
        public string interests;

        public ObservableCollection<string> Items { get; set; }


        public InterestSelectionViewModel()
        {
            Items = new ObservableCollection<string>
            {
                "Item 1",
                "Item 2",
                "Item 3",
                "Item 4",
                "Item 5"
            };
        }

        public static string ISViewModel(object sndr, CheckedChangedEventArgs e)
        {
            CheckBox cb = (CheckBox)sndr;
            int tCount = 0;
            int arrCount = 0;
            Interest[] temp = new Interest[selectedInterests.Length - 1];
            string sReturn = "";

            if (e.Value == false)
            {
                for (int i = 0; i < selectedInterests.Length - 1; i++)
                {
                    if (selectedInterests[i].interest.Equals((string)cb.BindingContext))
                    {
                        continue;                        
                    }
                    else
                    {
                        temp[tCount] = selectedInterests[i];
                        tCount++;
                    }
                }

                selectedInterests = temp;
            }
            else
            {
                selectedInterests[arrCount] = new Interest((string)cb.BindingContext);
                arrCount++;
            }
            
            for (int i = 0; i < selectedInterests.Length - 1; i++)
            {
                sReturn += selectedInterests[i].interest;
            }
                return sReturn;
        }

        public Interest[] Interests
        {
            get => selectedInterests;
            set => SetProperty(ref selectedInterests, value);
        }
    }
}
