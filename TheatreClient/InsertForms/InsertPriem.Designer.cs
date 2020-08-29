namespace TheatreClient
{
    partial class InsertPriem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertPriem));
            this.labelRab = new MetroFramework.Controls.MetroLabel();
            this.labelDolz = new MetroFramework.Controls.MetroLabel();
            this.labelDate = new MetroFramework.Controls.MetroLabel();
            this.rabCombo = new MetroFramework.Controls.MetroComboBox();
            this.dolzCombo = new MetroFramework.Controls.MetroComboBox();
            this.dateCome = new System.Windows.Forms.DateTimePicker();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.insertButton = new MetroFramework.Controls.MetroButton();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // labelRab
            // 
            this.labelRab.AutoSize = true;
            this.labelRab.Location = new System.Drawing.Point(23, 60);
            this.labelRab.Name = "labelRab";
            this.labelRab.Size = new System.Drawing.Size(67, 19);
            this.labelRab.TabIndex = 0;
            this.labelRab.Text = "Работник";
            // 
            // labelDolz
            // 
            this.labelDolz.AutoSize = true;
            this.labelDolz.Location = new System.Drawing.Point(23, 112);
            this.labelDolz.Name = "labelDolz";
            this.labelDolz.Size = new System.Drawing.Size(75, 19);
            this.labelDolz.TabIndex = 1;
            this.labelDolz.Text = "Должность";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(23, 162);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(37, 19);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Дата";
            // 
            // rabCombo
            // 
            this.rabCombo.FormattingEnabled = true;
            this.rabCombo.ItemHeight = 23;
            this.rabCombo.Location = new System.Drawing.Point(96, 60);
            this.rabCombo.Name = "rabCombo";
            this.rabCombo.Size = new System.Drawing.Size(177, 29);
            this.rabCombo.TabIndex = 3;
            // 
            // dolzCombo
            // 
            this.dolzCombo.FormattingEnabled = true;
            this.dolzCombo.ItemHeight = 23;
            this.dolzCombo.Location = new System.Drawing.Point(96, 112);
            this.dolzCombo.Name = "dolzCombo";
            this.dolzCombo.Size = new System.Drawing.Size(177, 29);
            this.dolzCombo.TabIndex = 4;
            // 
            // dateCome
            // 
            this.dateCome.CustomFormat = "yyyy-MM-dd ";
            this.dateCome.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateCome.Location = new System.Drawing.Point(96, 162);
            this.dateCome.Name = "dateCome";
            this.dateCome.Size = new System.Drawing.Size(177, 20);
            this.dateCome.TabIndex = 10;
            this.dateCome.Value = new System.DateTime(2019, 10, 27, 20, 31, 0, 0);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(266, 203);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 23);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.btnAction);
            // 
            // insertButton
            // 
            this.insertButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insertButton.Location = new System.Drawing.Point(149, 203);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(111, 23);
            this.insertButton.TabIndex = 14;
            this.insertButton.Text = "Добавить";
            this.insertButton.Visible = false;
            this.insertButton.Click += new System.EventHandler(this.btnAction);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updateButton.Location = new System.Drawing.Point(32, 203);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(111, 23);
            this.updateButton.TabIndex = 13;
            this.updateButton.Text = "Правка";
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.btnAction);
            // 
            // InsertPriem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 249);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dateCome);
            this.Controls.Add(this.dolzCombo);
            this.Controls.Add(this.rabCombo);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelDolz);
            this.Controls.Add(this.labelRab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InsertPriem";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "InsertPriem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel labelRab;
        private MetroFramework.Controls.MetroLabel labelDolz;
        private MetroFramework.Controls.MetroLabel labelDate;
        private MetroFramework.Controls.MetroComboBox rabCombo;
        private MetroFramework.Controls.MetroComboBox dolzCombo;
        private System.Windows.Forms.DateTimePicker dateCome;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroButton insertButton;
        private MetroFramework.Controls.MetroButton updateButton;
    }
}