namespace TheatreClient
{
    partial class InsertGiveZvanie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertGiveZvanie));
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.insertButton = new MetroFramework.Controls.MetroButton();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.labelRab = new MetroFramework.Controls.MetroLabel();
            this.labelZvanie = new MetroFramework.Controls.MetroLabel();
            this.labelGive = new MetroFramework.Controls.MetroLabel();
            this.labelKonkurs = new MetroFramework.Controls.MetroLabel();
            this.rabCombo = new MetroFramework.Controls.MetroComboBox();
            this.zvanieCombo = new MetroFramework.Controls.MetroComboBox();
            this.konkursText = new MetroFramework.Controls.MetroTextBox();
            this.dateGive = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(334, 247);
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
            this.insertButton.Location = new System.Drawing.Point(155, 247);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(173, 23);
            this.insertButton.TabIndex = 17;
            this.insertButton.Text = "Добавить";
            this.insertButton.Visible = false;
            this.insertButton.Click += new System.EventHandler(this.btnAction);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updateButton.Location = new System.Drawing.Point(38, 247);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(111, 23);
            this.updateButton.TabIndex = 16;
            this.updateButton.Text = "Правка";
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.btnAction);
            // 
            // labelRab
            // 
            this.labelRab.AutoSize = true;
            this.labelRab.Location = new System.Drawing.Point(23, 60);
            this.labelRab.Name = "labelRab";
            this.labelRab.Size = new System.Drawing.Size(67, 19);
            this.labelRab.TabIndex = 19;
            this.labelRab.Text = "Работник";
            // 
            // labelZvanie
            // 
            this.labelZvanie.AutoSize = true;
            this.labelZvanie.Location = new System.Drawing.Point(23, 106);
            this.labelZvanie.Name = "labelZvanie";
            this.labelZvanie.Size = new System.Drawing.Size(54, 19);
            this.labelZvanie.TabIndex = 20;
            this.labelZvanie.Text = "Звание";
            // 
            // labelGive
            // 
            this.labelGive.AutoSize = true;
            this.labelGive.Location = new System.Drawing.Point(23, 150);
            this.labelGive.Name = "labelGive";
            this.labelGive.Size = new System.Drawing.Size(86, 19);
            this.labelGive.TabIndex = 21;
            this.labelGive.Text = "Дата выдачи";
            // 
            // labelKonkurs
            // 
            this.labelKonkurs.AutoSize = true;
            this.labelKonkurs.Location = new System.Drawing.Point(23, 187);
            this.labelKonkurs.Name = "labelKonkurs";
            this.labelKonkurs.Size = new System.Drawing.Size(58, 19);
            this.labelKonkurs.TabIndex = 22;
            this.labelKonkurs.Text = "Конкурс";
            // 
            // rabCombo
            // 
            this.rabCombo.FormattingEnabled = true;
            this.rabCombo.ItemHeight = 23;
            this.rabCombo.Location = new System.Drawing.Point(96, 60);
            this.rabCombo.Name = "rabCombo";
            this.rabCombo.Size = new System.Drawing.Size(191, 29);
            this.rabCombo.TabIndex = 23;
            // 
            // zvanieCombo
            // 
            this.zvanieCombo.FormattingEnabled = true;
            this.zvanieCombo.ItemHeight = 23;
            this.zvanieCombo.Location = new System.Drawing.Point(96, 106);
            this.zvanieCombo.Name = "zvanieCombo";
            this.zvanieCombo.Size = new System.Drawing.Size(191, 29);
            this.zvanieCombo.TabIndex = 24;
            // 
            // konkursText
            // 
            this.konkursText.Location = new System.Drawing.Point(96, 187);
            this.konkursText.Name = "konkursText";
            this.konkursText.Size = new System.Drawing.Size(191, 23);
            this.konkursText.TabIndex = 25;
            // 
            // dateGive
            // 
            this.dateGive.CustomFormat = "yyyy-MM-dd ";
            this.dateGive.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateGive.Location = new System.Drawing.Point(115, 150);
            this.dateGive.Name = "dateGive";
            this.dateGive.Size = new System.Drawing.Size(172, 20);
            this.dateGive.TabIndex = 26;
            this.dateGive.Value = new System.DateTime(2019, 10, 27, 20, 31, 0, 0);
            // 
            // InsertGiveZvanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 293);
            this.Controls.Add(this.dateGive);
            this.Controls.Add(this.konkursText);
            this.Controls.Add(this.zvanieCombo);
            this.Controls.Add(this.rabCombo);
            this.Controls.Add(this.labelKonkurs);
            this.Controls.Add(this.labelGive);
            this.Controls.Add(this.labelZvanie);
            this.Controls.Add(this.labelRab);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.updateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InsertGiveZvanie";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "InsertGiveZvanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroButton insertButton;
        private MetroFramework.Controls.MetroButton updateButton;
        private MetroFramework.Controls.MetroLabel labelRab;
        private MetroFramework.Controls.MetroLabel labelZvanie;
        private MetroFramework.Controls.MetroLabel labelGive;
        private MetroFramework.Controls.MetroLabel labelKonkurs;
        private MetroFramework.Controls.MetroComboBox rabCombo;
        private MetroFramework.Controls.MetroComboBox zvanieCombo;
        private MetroFramework.Controls.MetroTextBox konkursText;
        private System.Windows.Forms.DateTimePicker dateGive;
    }
}