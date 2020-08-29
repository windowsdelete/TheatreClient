namespace TheatreClient
{
    partial class InsertSetRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertSetRoles));
            this.dateSet = new System.Windows.Forms.DateTimePicker();
            this.labelRab = new MetroFramework.Controls.MetroLabel();
            this.labelRole = new MetroFramework.Controls.MetroLabel();
            this.labelDate = new MetroFramework.Controls.MetroLabel();
            this.rabCombo = new MetroFramework.Controls.MetroComboBox();
            this.roleCombo = new MetroFramework.Controls.MetroComboBox();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.insertButton = new MetroFramework.Controls.MetroButton();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // dateSet
            // 
            this.dateSet.CustomFormat = "yyyy-MM-dd ";
            this.dateSet.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateSet.Location = new System.Drawing.Point(96, 160);
            this.dateSet.Name = "dateSet";
            this.dateSet.Size = new System.Drawing.Size(180, 20);
            this.dateSet.TabIndex = 10;
            this.dateSet.Value = new System.DateTime(2019, 10, 27, 20, 31, 0, 0);
            // 
            // labelRab
            // 
            this.labelRab.AutoSize = true;
            this.labelRab.Location = new System.Drawing.Point(23, 60);
            this.labelRab.Name = "labelRab";
            this.labelRab.Size = new System.Drawing.Size(67, 19);
            this.labelRab.TabIndex = 11;
            this.labelRab.Text = "Работник";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(23, 112);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(38, 19);
            this.labelRole.TabIndex = 12;
            this.labelRole.Text = "Роль";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(23, 160);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(37, 19);
            this.labelDate.TabIndex = 13;
            this.labelDate.Text = "Дата";
            // 
            // rabCombo
            // 
            this.rabCombo.FormattingEnabled = true;
            this.rabCombo.ItemHeight = 23;
            this.rabCombo.Location = new System.Drawing.Point(96, 60);
            this.rabCombo.Name = "rabCombo";
            this.rabCombo.Size = new System.Drawing.Size(180, 29);
            this.rabCombo.TabIndex = 14;
            // 
            // roleCombo
            // 
            this.roleCombo.FormattingEnabled = true;
            this.roleCombo.ItemHeight = 23;
            this.roleCombo.Location = new System.Drawing.Point(96, 112);
            this.roleCombo.Name = "roleCombo";
            this.roleCombo.Size = new System.Drawing.Size(180, 29);
            this.roleCombo.TabIndex = 15;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(403, 201);
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
            this.insertButton.Location = new System.Drawing.Point(141, 201);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(256, 23);
            this.insertButton.TabIndex = 17;
            this.insertButton.Text = "Добавить";
            this.insertButton.Visible = false;
            this.insertButton.Click += new System.EventHandler(this.btnAction);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updateButton.Location = new System.Drawing.Point(24, 201);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(111, 23);
            this.updateButton.TabIndex = 16;
            this.updateButton.Text = "Правка";
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.btnAction);
            // 
            // InsertSetRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 247);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.roleCombo);
            this.Controls.Add(this.rabCombo);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelRab);
            this.Controls.Add(this.dateSet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InsertSetRoles";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "InsertSetRoles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateSet;
        private MetroFramework.Controls.MetroLabel labelRab;
        private MetroFramework.Controls.MetroLabel labelRole;
        private MetroFramework.Controls.MetroLabel labelDate;
        private MetroFramework.Controls.MetroComboBox rabCombo;
        private MetroFramework.Controls.MetroComboBox roleCombo;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroButton insertButton;
        private MetroFramework.Controls.MetroButton updateButton;
    }
}