namespace TheatreClient
{
    partial class InsertTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertTickets));
            this.dateBuy = new System.Windows.Forms.DateTimePicker();
            this.labelSpec = new MetroFramework.Controls.MetroLabel();
            this.specCombo = new MetroFramework.Controls.MetroComboBox();
            this.costText = new MetroFramework.Controls.MetroTextBox();
            this.labelCost = new MetroFramework.Controls.MetroLabel();
            this.labelDate = new MetroFramework.Controls.MetroLabel();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.insertButton = new MetroFramework.Controls.MetroButton();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // dateBuy
            // 
            this.dateBuy.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateBuy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBuy.Location = new System.Drawing.Point(70, 164);
            this.dateBuy.Name = "dateBuy";
            this.dateBuy.Size = new System.Drawing.Size(172, 20);
            this.dateBuy.TabIndex = 9;
            this.dateBuy.Value = new System.DateTime(2019, 10, 27, 12, 15, 34, 0);
            // 
            // labelSpec
            // 
            this.labelSpec.AutoSize = true;
            this.labelSpec.Location = new System.Drawing.Point(23, 60);
            this.labelSpec.Name = "labelSpec";
            this.labelSpec.Size = new System.Drawing.Size(70, 19);
            this.labelSpec.TabIndex = 10;
            this.labelSpec.Text = "Спектакль";
            // 
            // specCombo
            // 
            this.specCombo.FormattingEnabled = true;
            this.specCombo.ItemHeight = 23;
            this.specCombo.Location = new System.Drawing.Point(99, 60);
            this.specCombo.Name = "specCombo";
            this.specCombo.Size = new System.Drawing.Size(143, 29);
            this.specCombo.TabIndex = 11;
            // 
            // costText
            // 
            this.costText.Location = new System.Drawing.Point(70, 114);
            this.costText.Name = "costText";
            this.costText.Size = new System.Drawing.Size(172, 23);
            this.costText.TabIndex = 12;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(23, 114);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(41, 19);
            this.labelCost.TabIndex = 13;
            this.labelCost.Text = "Цена";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(27, 164);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(37, 19);
            this.labelDate.TabIndex = 14;
            this.labelDate.Text = "Дата";
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(346, 206);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 23);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.btnAction);
            // 
            // insertButton
            // 
            this.insertButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insertButton.Location = new System.Drawing.Point(131, 206);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(209, 23);
            this.insertButton.TabIndex = 16;
            this.insertButton.Text = "Добавить";
            this.insertButton.Visible = false;
            this.insertButton.Click += new System.EventHandler(this.btnAction);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updateButton.Location = new System.Drawing.Point(14, 206);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(111, 23);
            this.updateButton.TabIndex = 15;
            this.updateButton.Text = "Правка";
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.btnAction);
            // 
            // InsertTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 252);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.costText);
            this.Controls.Add(this.specCombo);
            this.Controls.Add(this.labelSpec);
            this.Controls.Add(this.dateBuy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InsertTickets";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "InsertTickets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateBuy;
        private MetroFramework.Controls.MetroLabel labelSpec;
        private MetroFramework.Controls.MetroComboBox specCombo;
        private MetroFramework.Controls.MetroTextBox costText;
        private MetroFramework.Controls.MetroLabel labelCost;
        private MetroFramework.Controls.MetroLabel labelDate;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroButton insertButton;
        private MetroFramework.Controls.MetroButton updateButton;
    }
}