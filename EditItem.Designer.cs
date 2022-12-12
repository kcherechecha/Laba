namespace katelabb4
{
    partial class EditItem
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
            this.editButton = new System.Windows.Forms.Button();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.chipTextBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.chipLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.prodTypeTextBox = new System.Windows.Forms.TextBox();
            this.prodTypeLabel = new System.Windows.Forms.Label();
            this.YearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.YearNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.editButton.Font = new System.Drawing.Font("Lucida Console", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editButton.Location = new System.Drawing.Point(143, 280);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(218, 46);
            this.editButton.TabIndex = 22;
            this.editButton.Text = "Edit item";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click_1);
            // 
            // modelTextBox
            // 
            this.modelTextBox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modelTextBox.Location = new System.Drawing.Point(321, 97);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(141, 27);
            this.modelTextBox.TabIndex = 20;
            // 
            // chipTextBox
            // 
            this.chipTextBox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chipTextBox.Location = new System.Drawing.Point(321, 148);
            this.chipTextBox.Name = "chipTextBox";
            this.chipTextBox.Size = new System.Drawing.Size(141, 27);
            this.chipTextBox.TabIndex = 19;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearLabel.Location = new System.Drawing.Point(24, 200);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(85, 30);
            this.yearLabel.TabIndex = 18;
            this.yearLabel.Text = "Year";
            // 
            // chipLabel
            // 
            this.chipLabel.AutoSize = true;
            this.chipLabel.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chipLabel.Location = new System.Drawing.Point(24, 143);
            this.chipLabel.Name = "chipLabel";
            this.chipLabel.Size = new System.Drawing.Size(85, 30);
            this.chipLabel.TabIndex = 17;
            this.chipLabel.Text = "Chip";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modelLabel.Location = new System.Drawing.Point(24, 92);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(103, 30);
            this.modelLabel.TabIndex = 16;
            this.modelLabel.Text = "Model";
            // 
            // prodTypeTextBox
            // 
            this.prodTypeTextBox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodTypeTextBox.Location = new System.Drawing.Point(321, 42);
            this.prodTypeTextBox.Name = "prodTypeTextBox";
            this.prodTypeTextBox.Size = new System.Drawing.Size(141, 27);
            this.prodTypeTextBox.TabIndex = 15;
            // 
            // prodTypeLabel
            // 
            this.prodTypeLabel.AutoSize = true;
            this.prodTypeLabel.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prodTypeLabel.Location = new System.Drawing.Point(24, 37);
            this.prodTypeLabel.Name = "prodTypeLabel";
            this.prodTypeLabel.Size = new System.Drawing.Size(229, 30);
            this.prodTypeLabel.TabIndex = 14;
            this.prodTypeLabel.Text = "Product type";
            // 
            // YearNumericUpDown
            // 
            this.YearNumericUpDown.Location = new System.Drawing.Point(321, 200);
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
            this.YearNumericUpDown.TabIndex = 23;
            this.YearNumericUpDown.Value = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 355);
            this.Controls.Add(this.YearNumericUpDown);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.chipTextBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.chipLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.prodTypeTextBox);
            this.Controls.Add(this.prodTypeLabel);
            this.Name = "EditItem";
            this.Text = "EditItem";
            this.Load += new System.EventHandler(this.EditItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.YearNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button editButton;
        private TextBox modelTextBox;
        private TextBox chipTextBox;
        private Label yearLabel;
        private Label chipLabel;
        private Label modelLabel;
        private TextBox prodTypeTextBox;
        private Label prodTypeLabel;
        private NumericUpDown YearNumericUpDown;
    }
}