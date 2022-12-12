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
    public partial class EditItem : Form
    {
        public EditItem()
        {
            InitializeComponent();
        }

        string ProductType;
        string Model;
        string Chip;
        int Year;

        public Item GetEditedItem()
        {
            Item item = new Item(ProductType, Model, Chip, Year);
            return item;
        }

        public void SetNewValues(Item item)
        {
            ProductType = item.ProductType;
            Model = item.Model;
            Chip = item.Chip;
            Year = item.Year;
        }

        private void EditItem_Load(object sender, EventArgs e)
        {
            prodTypeTextBox.Text = ProductType;
            modelTextBox.Text = Model;
            chipTextBox.Text = Chip;
            YearNumericUpDown.Value = Year;
        }

        private void editButton_Click_1(object sender, EventArgs e)
        {
            string cur_PorductType = ProductType;
            string cur_Model = Model;
            string cur_Chip = Chip;
            int cur_Year = Year;

            ProductType = prodTypeTextBox.Text;
            Model = modelTextBox.Text;
            Chip = chipTextBox.Text;
            Year = Convert.ToInt32(YearNumericUpDown.Value);

            DialogResult dialogResult = 0;
            if (cur_PorductType == ProductType && cur_Model == Model && cur_Chip == Chip && cur_Year == Year)
            {
                dialogResult = MessageBox.Show("You didnt change anything. Are you sure you want to continue?", "Edit", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }

            if (ProductType == "" || Model == "" || Chip == "" )
                MessageBox.Show("Make sure all fields are full");
            else if(ProductType != "" && Model != "" && Chip != "" && dialogResult != DialogResult.No)
            this.Close();
        }
    }
}
