using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace katelabb4
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        string ProductType;
        string Model;
        string Chip;
        int Year;

        private void addButton_Click(object sender, EventArgs e)
        {
            ProductType = prodTypeTextBox.Text;
            Model = modelTextBox.Text;
            Chip = chipTextBox.Text;
            Year = Convert.ToInt32(YearNumericUpDown.Value);

            if (ProductType == "" || Model == "" || Chip == "")
                MessageBox.Show("Make sure all fields are full");
            else
                this.Close();
        }

        public Item GetNewItem()
        {
            if(Year == 0) // перевіряємо чи користувач не натиснув кнопку виходу з форми
            {
                return null;
            }
            Item item = new Item(ProductType, Model, Chip, Year);
            return item;
        }
    }
}
