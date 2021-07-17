using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using GiftRecoApp.Models;
using Xamarin.Forms;

namespace GiftRecoApp.ViewModels
{
    public class ItemViewModel : BaseViewModel
    {
        private Item _item;

        private string text;
        private string description;
        private string tags;

        public ItemViewModel(Item item)
        {
            this._item = item;

            text = item.Text;
            description = item.Description;
            
            foreach(String s in item.Tags)
            {
                tags += "#" + s + ",";
            }

            tags = tags.Remove(tags.Length - 1, 1);
        }

        public Item RealItem
        {
            get => this._item;
            set => SetProperty(ref _item, value);
        }
        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public string Tags
        {
            get => tags;
            set => SetProperty(ref tags, value);
        }
    }
}
