namespace TheatreClient
{
    partial class InsertAbonimenty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertAbonimenty));
            this.comboZhanry = new MetroFramework.Controls.MetroComboBox();
            this.textboxCost = new MetroFramework.Controls.MetroTextBox();
            this.labelZhanry = new MetroFramework.Controls.MetroLabel();
            this.labelCost = new MetroFramework.Controls.MetroLabel();
            this.labelBuy = new MetroFramework.Controls.MetroLabel();
            this.labelOut = new MetroFramework.Controls.MetroLabel();
            this.dateBuy = new System.Windows.Forms.DateTimePicker();
            this.dateOut = new System.Windows.Forms.DateTimePicker();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.insertButton = new MetroFramework.Controls.MetroButton();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // comboZhanry
            // 
            this.comboZhanry.FormattingEnabled = true;
            this.comboZhanry.ItemHeight = 23;
            this.comboZhanry.Location = new System.Drawing.Point(73, 73);
            this.comboZhanry.Name = "comboZhanry";
            this.comboZhanry.Size = new System.Drawing.Size(180, 29);
            this.comboZhanry.TabIndex = 0;
            // 
            // textboxCost
            // 
            this.textboxCost.Location = new System.Drawing.Point(73, 116);
            this.textboxCost.Name = "textboxCost";
            this.textboxCost.Size = new System.Drawing.Size(180, 23);
            this.textboxCost.TabIndex = 1;
            // 
            // labelZhanry
            // 
            this.labelZhanry.AutoSize = true;
            this.labelZhanry.Location = new System.Drawing.Point(23, 73);
            this.labelZhanry.Name = "labelZhanry";
            this.labelZhanry.Size = new System.Drawing.Size(44, 19);
            this.labelZhanry.TabIndex = 2;
            this.labelZhanry.Text = "Жанр";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(23, 116);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(41, 19);
            this.labelCost.TabIndex = 3;
            this.labelCost.Text = "Цена";
            // 
            // labelBuy
            // 
            this.labelBuy.AutoSize = true;
            this.labelBuy.Location = new System.Drawing.Point(23, 154);
            this.labelBuy.Name = "labelBuy";
            this.labelBuy.Size = new System.Drawing.Size(91, 19);
            this.labelBuy.TabIndex = 4;
            this.labelBuy.Text = "Дата покупки";
            // 
            // labelOut
            // 
            this.labelOut.AutoSize = true;
            this.labelOut.Location = new System.Drawing.Point(23, 189);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(108, 19);
            this.labelOut.TabIndex = 5;
            this.labelOut.Text = "Дата окончания";
            // 
            // dateBuy
            // 
            this.dateBuy.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateBuy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBuy.Location = new System.Drawing.Point(140, 154);
            this.dateBuy.Name = "dateBuy";
            this.dateBuy.Size = new System.Drawing.Size(172, 20);
            this.dateBuy.TabIndex = 8;
            this.dateBuy.Value = new System.DateTime(2019, 10, 27, 12, 15, 34, 0);
            // 
            // dateOut
            // 
            this.dateOut.CustomFormat = "yyyy-MM-dd ";
            this.dateOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOut.Location = new System.Drawing.Point(140, 189);
            this.dateOut.Name = "dateOut";
            this.dateOut.Size = new System.Drawing.Size(172, 20);
            this.dateOut.TabIndex = 9;
            this.dateOut.Value = new System.DateTime(2019, 10, 27, 20, 31, 0, 0);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updateButton.Location = new System.Drawing.Point(23, 246);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(111, 23);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Правка";
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.btnAction);
            // 
            // insertButton
            // 
            this.insertButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insertButton.Location = new System.Drawing.Point(140, 246);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(227, 23);
            this.insertButton.TabIndex = 11;
            this.insertButton.Text = "Добавить";
            this.insertButton.Visible = false;
            this.insertButton.Click += new System.EventHandler(this.btnAction);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(373, 246);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 23);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.btnAction);
            // 
            // InsertAbonimenty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 308);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dateOut);
            this.Controls.Add(this.dateBuy);
            this.Controls.Add(this.labelOut);
            this.Controls.Add(this.labelBuy);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelZhanry);
            this.Controls.Add(this.textboxCost);
            this.Controls.Add(this.comboZhanry);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InsertAbonimenty";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Абонименты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox comboZhanry;
        private MetroFramework.Controls.MetroTextBox textboxCost;
        private MetroFramework.Controls.MetroLabel labelZhanry;
        private MetroFramework.Controls.MetroLabel labelCost;
        private MetroFramework.Controls.MetroLabel labelBuy;
        private MetroFramework.Controls.MetroLabel labelOut;
        private System.Windows.Forms.DateTimePicker dateBuy;
        private System.Windows.Forms.DateTimePicker dateOut;
        private MetroFramework.Controls.MetroButton updateButton;
        private MetroFramework.Controls.MetroButton insertButton;
        private MetroFramework.Controls.MetroButton deleteButton;
    }
}