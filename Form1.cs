using System.Windows.Forms;

namespace katelabb4
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ItemsList Items = new ItemsList();
        ListToDataGrid ListToDataGrid = new ListToDataGrid();
        SearchItemsList searchItems = new SearchItemsList();
        Helper helper = new Helper();
        int selectedRow;
        bool IsSaved = false;
        bool findItem = false;

        //додавання в таблицю
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItem item = new AddItem();
            item.ShowDialog();
            if (item.GetNewItem() == null) return; //форма була закрита
            Items.AddToList(item.GetNewItem());
            ListToDataGrid.AddRows(dataGridView1, item.GetNewItem());
            IsSaved = false;
        }

        //видалення з таблиці
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Items.itemsList.Count == 0)
            {
                MessageBox.Show("Your table is empty. Add something first");
                return;
            }
            Item item = helper.getItemFromDataGrid(dataGridView1, selectedRow);
            Items.DeleteItemFromList(item);
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            for (int i = 0; i < Items.itemsList.Count; i++)
                ListToDataGrid.AddRows(dataGridView1, Items.itemsList[i]);
            IsSaved = false;
        }

        //редагування продукту з таблиці
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Items.itemsList.Count == 0)
            {
                MessageBox.Show("Add an item first");
                return;
            }
            EditItem item = new EditItem();
            
            if (findItem)
            {
                Item editInSearch = new Item(searchItems.GetByIndex(selectedRow).ProductType, searchItems.GetByIndex(selectedRow).Model, searchItems.GetByIndex(selectedRow).Chip, searchItems.GetByIndex(selectedRow).Year);
                int index = Items.GetIndex(editInSearch);
                item.SetNewValues(editInSearch);
                item.ShowDialog();
                Items.EditList(item.GetEditedItem(), index);
                searchItems.EditList(item.GetEditedItem(), selectedRow);
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                for (int i = 0; i < searchItems.SearchedItems.Count; i++)
                    ListToDataGrid.AddRows(dataGridView1, searchItems.SearchedItems[i]);
            }
            else
            {
                item.SetNewValues(Items.GetByIndex(selectedRow));
                item.ShowDialog();
                Items.EditList(item.GetEditedItem(), selectedRow);
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                for (int i = 0; i < Items.itemsList.Count; i++)
                    ListToDataGrid.AddRows(dataGridView1, Items.itemsList[i]);
            }
            IsSaved = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = dataGridView1.CurrentCell.RowIndex;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (Items.itemsList.Count == 0)
            {
                MessageBox.Show("The table is empty. Add something first");
                return;
            }
            if (prodTypeCheckBox.Checked == false && chipCheckBox.Checked == false && chipCheckBox.Checked == false && yearCheckBox.Checked == false)
            {
                MessageBox.Show("Choose filters to complete search");
                return;

            }
            findItem = true;
            List<Item> item = new List<Item>();
            searchItems.SearchedItems.Clear();
            foreach (var itemItem in Items.itemsList)
            { 
                item.Add(itemItem);
            }
            if (prodTypeCheckBox.Checked == true)
            {
                if (prodTypeTextBox.Text == "")
                {
                    MessageBox.Show("Please type product type to complete search");
                    return;
                }
               item = helper.SearchProductType(item, prodTypeTextBox.Text);
            } 
            if (modelCheckBox.Checked == true)
            {
                if (modelTextBox.Text == "")
                {
                    MessageBox.Show("Please type a model to complete search");
                    return;
                }
                item = helper.SearchModel(item, modelTextBox.Text);
            }
            if (chipCheckBox.Checked == true)
            {
                if (chipTextBox.Text == "")
                {
                    MessageBox.Show("Please type chip to complete search");
                    return;
                }
                item = helper.SearchChip(item, chipTextBox.Text);
            }
            if (yearCheckBox.Checked == true)
            {
                item = helper.SearchYear(item, Convert.ToInt32(YearNumericUpDown.Value));
            }
            searchItems.setSearchedList(item);
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            for (int i = 0; i < searchItems.SearchedItems.Count; i++)
            {
                ListToDataGrid.AddRows(dataGridView1, searchItems.SearchedItems[i]);
            }

        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            if (findItem == false)
            {
                MessageBox.Show("You have nothing to reset. This is your original table");
                return;
            }
            prodTypeCheckBox.Checked = false;
            prodTypeTextBox.Text = "";
            modelCheckBox.Checked = false;
            modelTextBox.Text = "";
            chipCheckBox.Checked = false;
            chipTextBox.Text = "";
            yearCheckBox.Checked = false;
            YearNumericUpDown.Value = 1970;
            findItem = false;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            foreach (var list in Items.itemsList)
            {
                ListToDataGrid.AddRows(dataGridView1, list);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            Desearializator desearializator = new Desearializator(saveFileDialog.FileName);
            Items.itemsList.Clear();
            Items.itemsList = desearializator.Deserealize();
            if (Items.itemsList == null)
                return;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            foreach (var item in Items.itemsList)
                ListToDataGrid.AddRows(dataGridView1, item);
            IsSaved = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Items.itemsList.Count == 0)
            {
                MessageBox.Show("Table is empty. Add something first");
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON File|*.json";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            Searializator searializator = new Searializator(saveFileDialog.FileName);
            searializator.Serialize(Items.itemsList);
            IsSaved = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Items.itemsList.Count == 0)
            {
                MessageBox.Show("The table is empty");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear the table", "Delete all", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Items.itemsList.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsSaved == false && Items.itemsList.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("You didn`t save your table. Are you sure you want to exit", "Exit", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    return;
                }
                else if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}