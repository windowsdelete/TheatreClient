namespace TheatreClient
{
    partial class InsertRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertRoles));
            this.labelName = new MetroFramework.Controls.MetroLabel();
            this.nameText = new MetroFramework.Controls.MetroTextBox();
            this.labelRost = new MetroFramework.Controls.MetroLabel();
            this.rostText = new MetroFramework.Controls.MetroTextBox();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.insertButton = new MetroFramework.Controls.MetroButton();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(23, 60);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 19);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(97, 60);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(156, 23);
            this.nameText.TabIndex = 1;
            // 
            // labelRost
            // 
            this.labelRost.AutoSize = true;
            this.labelRost.Location = new System.Drawing.Point(23, 105);
            this.labelRost.Name = "labelRost";
            this.labelRost.Size = new System.Drawing.Size(36, 19);
            this.labelRost.TabIndex = 2;
            this.labelRost.Text = "Рост";
            // 
            // rostText
            // 
            this.rostText.Location = new System.Drawing.Point(97, 105);
            this.rostText.Name = "rostText";
            this.rostText.Size = new System.Drawing.Size(156, 23);
            this.rostText.TabIndex = 3;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(248, 152);
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
            this.insertButton.Location = new System.Drawing.Point(131, 152);
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
            this.updateButton.Location = new System.Drawing.Point(14, 152);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(111, 23);
            this.updateButton.TabIndex = 13;
            this.updateButton.Text = "Правка";
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.btnAction);
            // 
            // InsertRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 198);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.rostText);
            this.Controls.Add(this.labelRost);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.labelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InsertRoles";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "InsertRoles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel labelName;
        private MetroFramework.Controls.MetroTextBox nameText;
        private MetroFramework.Controls.MetroLabel labelRost;
        private MetroFramework.Controls.MetroTextBox rostText;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroButton insertButton;
        private MetroFramework.Controls.MetroButton updateButton;
    }
}