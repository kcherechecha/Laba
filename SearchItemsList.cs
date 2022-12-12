using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katelabb4
{
    public class SearchItemsList
    {
        public List<Item> SearchedItems = new List<Item>();

        public void setSearchedList(List<Item> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                SearchedItems.Add(items[i]);
            }
        }

        public Item GetByIndex(int index)
        {
            return SearchedItems[index];
        }

        public void EditList(Item item, int index)
        {
            SearchedItems[index] = item;
        }
    }
}
