namespace TheatreClient
{
    partial class InsertAuditory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertAuditory));
            this.nameAudit = new MetroFramework.Controls.MetroTextBox();
            this.vmestAudit = new MetroFramework.Controls.MetroTextBox();
            this.labelName = new MetroFramework.Controls.MetroLabel();
            this.labelVmest = new MetroFramework.Controls.MetroLabel();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.insertButton = new MetroFramework.Controls.MetroButton();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // nameAudit
            // 
            this.nameAudit.Location = new System.Drawing.Point(175, 60);
            this.nameAudit.Name = "nameAudit";
            this.nameAudit.Size = new System.Drawing.Size(144, 23);
            this.nameAudit.TabIndex = 0;
            // 
            // vmestAudit
            // 
            this.vmestAudit.Location = new System.Drawing.Point(175, 94);
            this.vmestAudit.Name = "vmestAudit";
            this.vmestAudit.Size = new System.Drawing.Size(144, 23);
            this.vmestAudit.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(23, 60);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(136, 19);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Название аудитории";
            // 
            // labelVmest
            // 
            this.labelVmest.AutoSize = true;
            this.labelVmest.Location = new System.Drawing.Point(23, 98);
            this.labelVmest.Name = "labelVmest";
            this.labelVmest.Size = new System.Drawing.Size(86, 19);
            this.labelVmest.TabIndex = 3;
            this.labelVmest.Text = "Вместимость";
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(339, 137);
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
            this.insertButton.Location = new System.Drawing.Point(140, 137);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(193, 23);
            this.insertButton.TabIndex = 14;
            this.insertButton.Text = "Добавить";
            this.insertButton.Visible = false;
            this.insertButton.Click += new System.EventHandler(this.btnAction);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updateButton.Location = new System.Drawing.Point(23, 137);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(111, 23);
            this.updateButton.TabIndex = 13;
            this.updateButton.Text = "Правка";
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.btnAction);
            // 
            // InsertAuditory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 183);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.labelVmest);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.vmestAudit);
            this.Controls.Add(this.nameAudit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InsertAuditory";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Аудитории";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox nameAudit;
        private MetroFramework.Controls.MetroTextBox vmestAudit;
        private MetroFramework.Controls.MetroLabel labelName;
        private MetroFramework.Controls.MetroLabel labelVmest;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroButton insertButton;
        private MetroFramework.Controls.MetroButton updateButton;
    }
}