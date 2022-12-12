using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katelabb4
{

    public class ItemsList
    {
        public List<Item> itemsList = new List<Item>();

        public void AddToList(Item item)
        {
            itemsList.Add(item);
        }

        public void DeleteItemFromList(Item item)
        {
            for(int i = 0; i < itemsList.Count; i++)
            {
                if (itemsList[i].ProductType == item.ProductType && itemsList[i].Model == item.Model && itemsList[i].Chip == item.Chip && itemsList[i].Year == item.Year)
                {
                    itemsList.Remove(itemsList[i]);
                    return;
                }
            }
        }

        public int GetIndex(Item item)
        {
            for(int i = 0; i < itemsList.Count; i++)
            {
                if (itemsList[i].ProductType == item.ProductType && itemsList[i].Model == item.Model && itemsList[i].Chip == item.Chip && itemsList[i].Year == item.Year) return i;
            }

            return -1;
        }

        public Item GetByIndex(int index)
        {
            return itemsList[index];
        }

        public void EditList(Item item, int index)
        {
            itemsList[index] = item;
        } 

       
        
    }
}
