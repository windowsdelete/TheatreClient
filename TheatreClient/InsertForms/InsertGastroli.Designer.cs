namespace TheatreClient
{
    partial class InsertGastroli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertGastroli));
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.insertButton = new MetroFramework.Controls.MetroButton();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.labelCity = new MetroFramework.Controls.MetroLabel();
            this.labelDate = new MetroFramework.Controls.MetroLabel();
            this.labelSpec = new MetroFramework.Controls.MetroLabel();
            this.cityText = new MetroFramework.Controls.MetroTextBox();
            this.specCombo = new MetroFramework.Controls.MetroComboBox();
            this.dateGast = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(270, 227);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 23);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.btnAction);
            // 
            // insertButton
            // 
            this.insertButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insertButton.Location = new System.Drawing.Point(153, 227);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(111, 23);
            this.insertButton.TabIndex = 17;
            this.insertButton.Text = "Добавить";
            this.insertButton.Visible = false;
            this.insertButton.Click += new System.EventHandler(this.btnAction);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updateButton.Location = new System.Drawing.Point(36, 227);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(111, 23);
            this.updateButton.TabIndex = 16;
            this.updateButton.Text = "Правка";
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.btnAction);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(23, 64);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(46, 19);
            this.labelCity.TabIndex = 19;
            this.labelCity.Text = "Город";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(23, 112);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(37, 19);
            this.labelDate.TabIndex = 20;
            this.labelDate.Text = "Дата";
            // 
            // labelSpec
            // 
            this.labelSpec.AutoSize = true;
            this.labelSpec.Location = new System.Drawing.Point(23, 166);
            this.labelSpec.Name = "labelSpec";
            this.labelSpec.Size = new System.Drawing.Size(70, 19);
            this.labelSpec.TabIndex = 21;
            this.labelSpec.Text = "Спектакль";
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(75, 64);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(172, 23);
            this.cityText.TabIndex = 22;
            // 
            // specCombo
            // 
            this.specCombo.FormattingEnabled = true;
            this.specCombo.ItemHeight = 23;
            this.specCombo.Location = new System.Drawing.Point(99, 166);
            this.specCombo.Name = "specCombo";
            this.specCombo.Size = new System.Drawing.Size(148, 29);
            this.specCombo.TabIndex = 23;
            // 
            // dateGast
            // 
            this.dateGast.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateGast.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateGast.Location = new System.Drawing.Point(75, 112);
            this.dateGast.Name = "dateGast";
            this.dateGast.Size = new System.Drawing.Size(172, 20);
            this.dateGast.TabIndex = 24;
            this.dateGast.Value = new System.DateTime(2019, 10, 27, 12, 15, 34, 0);
            // 
            // InsertGastroli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 282);
            this.Controls.Add(this.dateGast);
            this.Controls.Add(this.specCombo);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.labelSpec);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.updateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InsertGastroli";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "InsertGastroli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroButton insertButton;
        private MetroFramework.Controls.MetroButton updateButton;
        private MetroFramework.Controls.MetroLabel labelCity;
        private MetroFramework.Controls.MetroLabel labelDate;
        private MetroFramework.Controls.MetroLabel labelSpec;
        private MetroFramework.Controls.MetroTextBox cityText;
        private MetroFramework.Controls.MetroComboBox specCombo;
        private System.Windows.Forms.DateTimePicker dateGast;
    }
}