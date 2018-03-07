using System;
using System.Collections.Generic;
using System.Text;

namespace ChechOutApp.Models
{
    class PayementOption
    {
        private String name;
        private Int32 price;
        private string ImageSource;
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public string ImageSource1 { get => ImageSource; set => ImageSource = value; }
    }
}
