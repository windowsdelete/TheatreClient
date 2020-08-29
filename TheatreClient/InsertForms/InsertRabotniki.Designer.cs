namespace TheatreClient
{
    partial class InsertRabotniki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertRabotniki));
            this.labelF = new MetroFramework.Controls.MetroLabel();
            this.labelI = new MetroFramework.Controls.MetroLabel();
            this.labelO = new MetroFramework.Controls.MetroLabel();
            this.labelBDate = new MetroFramework.Controls.MetroLabel();
            this.labelPol = new MetroFramework.Controls.MetroLabel();
            this.labelRost = new MetroFramework.Controls.MetroLabel();
            this.fText = new MetroFramework.Controls.MetroTextBox();
            this.iText = new MetroFramework.Controls.MetroTextBox();
            this.oText = new MetroFramework.Controls.MetroTextBox();
            this.polText = new MetroFramework.Controls.MetroTextBox();
            this.rostText = new MetroFramework.Controls.MetroTextBox();
            this.dateBirth = new System.Windows.Forms.DateTimePicker();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.insertButton = new MetroFramework.Controls.MetroButton();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // labelF
            // 
            this.labelF.AutoSize = true;
            this.labelF.Location = new System.Drawing.Point(23, 60);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(65, 19);
            this.labelF.TabIndex = 0;
            this.labelF.Text = "Фамилия";
            // 
            // labelI
            // 
            this.labelI.AutoSize = true;
            this.labelI.Location = new System.Drawing.Point(23, 102);
            this.labelI.Name = "labelI";
            this.labelI.Size = new System.Drawing.Size(35, 19);
            this.labelI.TabIndex = 1;
            this.labelI.Text = "Имя";
            // 
            // labelO
            // 
            this.labelO.AutoSize = true;
            this.labelO.Location = new System.Drawing.Point(23, 141);
            this.labelO.Name = "labelO";
            this.labelO.Size = new System.Drawing.Size(65, 19);
            this.labelO.TabIndex = 2;
            this.labelO.Text = "Отчество";
            // 
            // labelBDate
            // 
            this.labelBDate.AutoSize = true;
            this.labelBDate.Location = new System.Drawing.Point(23, 188);
            this.labelBDate.Name = "labelBDate";
            this.labelBDate.Size = new System.Drawing.Size(103, 19);
            this.labelBDate.TabIndex = 3;
            this.labelBDate.Text = "Дата рождения";
            // 
            // labelPol
            // 
            this.labelPol.AutoSize = true;
            this.labelPol.Location = new System.Drawing.Point(25, 227);
            this.labelPol.Name = "labelPol";
            this.labelPol.Size = new System.Drawing.Size(33, 19);
            this.labelPol.TabIndex = 4;
            this.labelPol.Text = "Пол";
            // 
            // labelRost
            // 
            this.labelRost.AutoSize = true;
            this.labelRost.Location = new System.Drawing.Point(25, 269);
            this.labelRost.Name = "labelRost";
            this.labelRost.Size = new System.Drawing.Size(36, 19);
            this.labelRost.TabIndex = 5;
            this.labelRost.Text = "Рост";
            // 
            // fText
            // 
            this.fText.Location = new System.Drawing.Point(97, 60);
            this.fText.Name = "fText";
            this.fText.Size = new System.Drawing.Size(154, 23);
            this.fText.TabIndex = 6;
            // 
            // iText
            // 
            this.iText.Location = new System.Drawing.Point(97, 98);
            this.iText.Name = "iText";
            this.iText.Size = new System.Drawing.Size(154, 23);
            this.iText.TabIndex = 7;
            // 
            // oText
            // 
            this.oText.Location = new System.Drawing.Point(97, 141);
            this.oText.Name = "oText";
            this.oText.Size = new System.Drawing.Size(154, 23);
            this.oText.TabIndex = 8;
            // 
            // polText
            // 
            this.polText.Location = new System.Drawing.Point(97, 227);
            this.polText.Name = "polText";
            this.polText.Size = new System.Drawing.Size(154, 23);
            this.polText.TabIndex = 9;
            // 
            // rostText
            // 
            this.rostText.Location = new System.Drawing.Point(97, 269);
            this.rostText.Name = "rostText";
            this.rostText.Size = new System.Drawing.Size(154, 23);
            this.rostText.TabIndex = 10;
            // 
            // dateBirth
            // 
            this.dateBirth.CustomFormat = "yyyy-MM-dd ";
            this.dateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBirth.Location = new System.Drawing.Point(132, 188);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(172, 20);
            this.dateBirth.TabIndex = 11;
            this.dateBirth.Value = new System.DateTime(2019, 10, 27, 20, 31, 0, 0);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(334, 320);
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
            this.insertButton.Location = new System.Drawing.Point(140, 320);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(188, 23);
            this.insertButton.TabIndex = 14;
            this.insertButton.Text = "Добавить";
            this.insertButton.Visible = false;
            this.insertButton.Click += new System.EventHandler(this.btnAction);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updateButton.Location = new System.Drawing.Point(23, 320);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(111, 23);
            this.updateButton.TabIndex = 13;
            this.updateButton.Text = "Правка";
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.btnAction);
            // 
            // InsertRabotniki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 366);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dateBirth);
            this.Controls.Add(this.rostText);
            this.Controls.Add(this.polText);
            this.Controls.Add(this.oText);
            this.Controls.Add(this.iText);
            this.Controls.Add(this.fText);
            this.Controls.Add(this.labelRost);
            this.Controls.Add(this.labelPol);
            this.Controls.Add(this.labelBDate);
            this.Controls.Add(this.labelO);
            this.Controls.Add(this.labelI);
            this.Controls.Add(this.labelF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InsertRabotniki";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "InsertRabotniki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel labelF;
        private MetroFramework.Controls.MetroLabel labelI;
        private MetroFramework.Controls.MetroLabel labelO;
        private MetroFramework.Controls.MetroLabel labelBDate;
        private MetroFramework.Controls.MetroLabel labelPol;
        private MetroFramework.Controls.MetroLabel labelRost;
        private MetroFramework.Controls.MetroTextBox fText;
        private MetroFramework.Controls.MetroTextBox iText;
        private MetroFramework.Controls.MetroTextBox oText;
        private MetroFramework.Controls.MetroTextBox polText;
        private MetroFramework.Controls.MetroTextBox rostText;
        private System.Windows.Forms.DateTimePicker dateBirth;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroButton insertButton;
        private MetroFramework.Controls.MetroButton updateButton;
    }
}