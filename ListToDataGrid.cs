using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katelabb4
{
    class ListToDataGrid
    {

        public void AddRows(DataGridView dataGridView, Item item)
        {
            dataGridView.Rows.Add(item.ProductType, item.Model, item.Chip, item.Year);
            int index = dataGridView.Rows.Count - 1;
            dataGridView.Rows[index].HeaderCell.Value = Convert.ToString(index + 1); 

        }

    }
}
