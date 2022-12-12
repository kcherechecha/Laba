using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katelabb4
{
    public class Item
    {
        public string ProductType { get; set; }
        public string Model { get; set; }
        public string Chip { get; set; }
        public int Year { get; set; }

        public Item(string productType, string model, string chip, int year)
        {
            ProductType = productType;
            Model = model;
            Chip = chip;
            Year = year;
        }
    }
}
