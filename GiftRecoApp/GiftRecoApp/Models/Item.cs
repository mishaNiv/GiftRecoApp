using System;

namespace GiftRecoApp.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string[] Tags { get; set; }
    }
}