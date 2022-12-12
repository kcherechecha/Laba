namespace katelabb4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.chipCheckBox = new System.Windows.Forms.CheckBox();
            this.modelCheckBox = new System.Windows.Forms.CheckBox();
            this.yearCheckBox = new System.Windows.Forms.CheckBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.yearCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chipCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.YearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.prodTypeTextBox = new System.Windows.Forms.TextBox();
            this.chipTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.manageItemsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1106, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // manageItemsToolStripMenuItem
            // 
            this.manageItemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteAllToolStripMenuItem});
            this.manageItemsToolStripMenuItem.Name = "manageItemsToolStripMenuItem";
            this.manageItemsToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.manageItemsToolStripMenuItem.Text = "Manage items";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteAllToolStripMenuItem
            // 
            this.deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
            this.deleteAllToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deleteAllToolStripMenuItem.Text = "Delete all";
            this.deleteAllToolStripMenuItem.Click += new System.EventHandler(this.deleteAllToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // prodTypeCheckBox
            // 
            this.prodTypeCheckBox.AutoSize = true;
            this.prodTypeCheckBox.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodTypeCheckBox.Location = new System.Drawing.Point(26, 90);
            this.prodTypeCheckBox.Name = "prodTypeCheckBox";
            this.prodTypeCheckBox.Size = new System.Drawing.Size(251, 34);
            this.prodTypeCheckBox.TabIndex = 2;
            this.prodTypeCheckBox.Text = "Product Type";
            this.prodTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // chipCheckBox
            // 
            this.chipCheckBox.AutoSize = true;
            this.chipCheckBox.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chipCheckBox.Location = new System.Drawing.Point(26, 209);
            this.chipCheckBox.Name = "chipCheckBox";
            this.chipCheckBox.Size = new System.Drawing.Size(107, 34);
            this.chipCheckBox.TabIndex = 4;
            this.chipCheckBox.Text = "Chip";
            this.chipCheckBox.UseVisualStyleBackColor = true;
            // 
            // modelCheckBox
            // 
            this.modelCheckBox.AutoSize = true;
            this.modelCheckBox.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modelCheckBox.Location = new System.Drawing.Point(26, 151);
            this.modelCheckBox.Name = "modelCheckBox";
            this.modelCheckBox.Size = new System.Drawing.Size(125, 34);
            this.modelCheckBox.TabIndex = 5;
            this.modelCheckBox.Text = "Model";
            this.modelCheckBox.UseVisualStyleBackColor = true;
            // 
            // yearCheckBox
            // 
            this.yearCheckBox.AutoSize = true;
            this.yearCheckBox.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearCheckBox.Location = new System.Drawing.Point(26, 268);
            this.yearCheckBox.Name = "yearCheckBox";
            this.yearCheckBox.Size = new System.Drawing.Size(107, 34);
            this.yearCheckBox.TabIndex = 6;
            this.yearCheckBox.Text = "Year";
            this.yearCheckBox.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.resetButton.Font = new System.Drawing.Font("Lucida Console", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetButton.Location = new System.Drawing.Point(255, 363);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(148, 49);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchButton.Font = new System.Drawing.Font("Lucida Console", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchButton.Location = new System.Drawing.Point(49, 363);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(148, 49);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // yearCol
            // 
            this.yearCol.HeaderText = "Year";
            this.yearCol.MinimumWidth = 6;
            this.yearCol.Name = "yearCol";
            this.yearCol.ReadOnly = true;
            this.yearCol.Width = 125;
            // 
            // chipCol
            // 
            this.chipCol.HeaderText = "Chip";
            this.chipCol.MinimumWidth = 6;
            this.chipCol.Name = "chipCol";
            this.chipCol.ReadOnly = true;
            this.chipCol.Width = 125;
            // 
            // modelCol
            // 
            this.modelCol.HeaderText = "Model";
            this.modelCol.MinimumWidth = 6;
            this.modelCol.Name = "modelCol";
            this.modelCol.ReadOnly = true;
            this.modelCol.Width = 125;
            // 
            // productTypeCol
            // 
            this.productTypeCol.HeaderText = "Product type";
            this.productTypeCol.MinimumWidth = 6;
            this.productTypeCol.Name = "productTypeCol";
            this.productTypeCol.ReadOnly = true;
            this.productTypeCol.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productTypeCol,
            this.modelCol,
            this.chipCol,
            this.yearCol});
            this.dataGridView1.Location = new System.Drawing.Point(513, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(554, 442);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // YearNumericUpDown
            // 
            this.YearNumericUpDown.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YearNumericUpDown.Location = new System.Drawing.Point(292, 270);
            this.YearNumericUpDown.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.YearNumericUpDown.Minimum = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            this.YearNumericUpDown.Name = "YearNumericUpDown";
            this.YearNumericUpDown.Size = new System.Drawing.Size(164, 32);
            this.YearNumericUpDown.TabIndex = 13;
            this.YearNumericUpDown.Value = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            // 
            // prodTypeTextBox
            // 
            this.prodTypeTextBox.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodTypeTextBox.Location = new System.Drawing.Point(292, 92);
            this.prodTypeTextBox.Name = "prodTypeTextBox";
            this.prodTypeTextBox.Size = new System.Drawing.Size(164, 32);
            this.prodTypeTextBox.TabIndex = 14;
            // 
            // chipTextBox
            // 
            this.chipTextBox.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chipTextBox.Location = new System.Drawing.Point(292, 211);
            this.chipTextBox.Name = "chipTextBox";
            this.chipTextBox.Size = new System.Drawing.Size(164, 32);
            this.chipTextBox.TabIndex = 15;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modelTextBox.Location = new System.Drawing.Point(292, 153);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(164, 32);
            this.modelTextBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1106, 527);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.chipTextBox);
            this.Controls.Add(this.prodTypeTextBox);
            this.Controls.Add(this.YearNumericUpDown);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.yearCheckBox);
            this.Controls.Add(this.modelCheckBox);
            this.Controls.Add(this.chipCheckBox);
            this.Controls.Add(this.prodTypeCheckBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MyTableSearch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem manageItemsToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private CheckBox prodTypeCheckBox;
        private CheckBox chipCheckBox;
        private CheckBox modelCheckBox;
        private CheckBox yearCheckBox;
        private Button resetButton;
        private Button searchButton;
        private DataGridViewTextBoxColumn yearCol;
        private DataGridViewTextBoxColumn chipCol;
        private DataGridViewTextBoxColumn modelCol;
        private DataGridViewTextBoxColumn productTypeCol;
        private DataGridView dataGridView1;
        private NumericUpDown YearNumericUpDown;
        private TextBox prodTypeTextBox;
        private TextBox chipTextBox;
        private TextBox modelTextBox;
        private ToolStripMenuItem deleteAllToolStripMenuItem;
    }
}