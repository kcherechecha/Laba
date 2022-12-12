namespace katelabb4
{
    partial class AddItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.prodTypeLabel = new System.Windows.Forms.Label();
            this.prodTypeTextBox = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.chipLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.chipTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.YearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.YearNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // prodTypeLabel
            // 
            this.prodTypeLabel.AutoSize = true;
            this.prodTypeLabel.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodTypeLabel.Location = new System.Drawing.Point(25, 34);
            this.prodTypeLabel.Name = "prodTypeLabel";
            this.prodTypeLabel.Size = new System.Drawing.Size(229, 30);
            this.prodTypeLabel.TabIndex = 0;
            this.prodTypeLabel.Text = "Product type";
            // 
            // prodTypeTextBox
            // 
            this.prodTypeTextBox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodTypeTextBox.Location = new System.Drawing.Point(322, 39);
            this.prodTypeTextBox.Name = "prodTypeTextBox";
            this.prodTypeTextBox.Size = new System.Drawing.Size(141, 27);
            this.prodTypeTextBox.TabIndex = 1;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modelLabel.Location = new System.Drawing.Point(25, 89);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(103, 30);
            this.modelLabel.TabIndex = 2;
            this.modelLabel.Text = "Model";
            // 
            // chipLabel
            // 
            this.chipLabel.AutoSize = true;
            this.chipLabel.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chipLabel.Location = new System.Drawing.Point(25, 140);
            this.chipLabel.Name = "chipLabel";
            this.chipLabel.Size = new System.Drawing.Size(85, 30);
            this.chipLabel.TabIndex = 3;
            this.chipLabel.Text = "Chip";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearLabel.Location = new System.Drawing.Point(25, 197);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(85, 30);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Year";
            // 
            // chipTextBox
            // 
            this.chipTextBox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chipTextBox.Location = new System.Drawing.Point(322, 145);
            this.chipTextBox.Name = "chipTextBox";
            this.chipTextBox.Size = new System.Drawing.Size(141, 27);
            this.chipTextBox.TabIndex = 5;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modelTextBox.Location = new System.Drawing.Point(322, 94);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(141, 27);
            this.modelTextBox.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addButton.Font = new System.Drawing.Font("Lucida Console", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(144, 277);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(202, 49);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Add item";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // YearNumericUpDown
            // 
            this.YearNumericUpDown.Location = new System.Drawing.Point(322, 203);
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
            this.YearNumericUpDown.Size = new System.Drawing.Size(141, 27);
            this.YearNumericUpDown.TabIndex = 14;
            this.YearNumericUpDown.Value = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 354);
            this.Controls.Add(this.YearNumericUpDown);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.chipTextBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.chipLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.prodTypeTextBox);
            this.Controls.Add(this.prodTypeLabel);
            this.Name = "AddItem";
            this.Text = "AddItem";
            ((System.ComponentModel.ISupportInitialize)(this.YearNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label prodTypeLabel;
        private TextBox prodTypeTextBox;
        private Label modelLabel;
        private Label chipLabel;
        private Label yearLabel;
        private TextBox chipTextBox;
        private TextBox modelTextBox;
        private Button addButton;
        private NumericUpDown YearNumericUpDown;
    }
}