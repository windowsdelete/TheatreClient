namespace TheatreClient
{
    partial class InsertNaznachenie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertNaznachenie));
            this.labelRab = new MetroFramework.Controls.MetroLabel();
            this.rabCombo = new MetroFramework.Controls.MetroComboBox();
            this.labelGroup = new MetroFramework.Controls.MetroLabel();
            this.groupCombo = new MetroFramework.Controls.MetroComboBox();
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
            // rabCombo
            // 
            this.rabCombo.FormattingEnabled = true;
            this.rabCombo.ItemHeight = 23;
            this.rabCombo.Location = new System.Drawing.Point(96, 60);
            this.rabCombo.Name = "rabCombo";
            this.rabCombo.Size = new System.Drawing.Size(179, 29);
            this.rabCombo.TabIndex = 1;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(23, 112);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(52, 19);
            this.labelGroup.TabIndex = 2;
            this.labelGroup.Text = "Группа";
            // 
            // groupCombo
            // 
            this.groupCombo.FormattingEnabled = true;
            this.groupCombo.ItemHeight = 23;
            this.groupCombo.Location = new System.Drawing.Point(96, 112);
            this.groupCombo.Name = "groupCombo";
            this.groupCombo.Size = new System.Drawing.Size(179, 29);
            this.groupCombo.TabIndex = 3;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(270, 163);
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
            this.insertButton.Location = new System.Drawing.Point(153, 163);
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
            this.updateButton.Location = new System.Drawing.Point(36, 163);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(111, 23);
            this.updateButton.TabIndex = 13;
            this.updateButton.Text = "Правка";
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.btnAction);
            // 
            // InsertNaznachenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 209);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.groupCombo);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.rabCombo);
            this.Controls.Add(this.labelRab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InsertNaznachenie";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "InsertNaznachenie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel labelRab;
        private MetroFramework.Controls.MetroComboBox rabCombo;
        private MetroFramework.Controls.MetroLabel labelGroup;
        private MetroFramework.Controls.MetroComboBox groupCombo;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroButton insertButton;
        private MetroFramework.Controls.MetroButton updateButton;
    }
}