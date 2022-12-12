using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katelabb4
{
    class Helper
    {

        public Item getItemFromDataGrid(DataGridView dataGridView, int index)
        {
            string productType = Convert.ToString(dataGridView.Rows[index].Cells[0].Value);
            string model = Convert.ToString(dataGridView.Rows[index].Cells[1].Value);
            string chip = Convert.ToString(dataGridView.Rows[index].Cells[2].Value);
            int year = Convert.ToInt32(dataGridView.Rows[index].Cells[3].Value);

            Item item = new Item(productType, model, chip, year);
            return item;

        }

        public List<Item> SearchProductType(List<Item> items, string prodType)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (prodType != items[i].ProductType)
                {
                    items.RemoveAt(i);
                    i--;
                }
            }
            return items;
        }

        public List<Item> SearchModel(List<Item> items, string model)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (model != items[i].Model)
                {
                    items.RemoveAt(i);
                    i--;
                }
            }
            return items;
        }

        public List<Item> SearchChip(List<Item> items, string chip)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (chip != items[i].Chip) // не блін Дейл
                {
                    items.RemoveAt(i);
                    i--;
                }
            }
            return items;
        }

        public List<Item> SearchYear(List<Item> items, int year)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (year != items[i].Year)
                {
                    items.RemoveAt(i);
                    i--;
                }
            }
            return items;
        }

    }
}
