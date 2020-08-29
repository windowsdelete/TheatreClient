namespace TheatreClient
{
    partial class InsertDolzhnosti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertDolzhnosti));
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.insertButton = new MetroFramework.Controls.MetroButton();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.labelName = new MetroFramework.Controls.MetroLabel();
            this.nameText = new MetroFramework.Controls.MetroTextBox();
            this.labelZP = new MetroFramework.Controls.MetroLabel();
            this.ZPText = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(318, 157);
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
            this.insertButton.Location = new System.Drawing.Point(154, 157);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(158, 23);
            this.insertButton.TabIndex = 17;
            this.insertButton.Text = "Добавить";
            this.insertButton.Visible = false;
            this.insertButton.Click += new System.EventHandler(this.btnAction);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updateButton.Location = new System.Drawing.Point(37, 157);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(111, 23);
            this.updateButton.TabIndex = 16;
            this.updateButton.Text = "Правка";
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.btnAction);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(21, 60);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 19);
            this.labelName.TabIndex = 19;
            this.labelName.Text = "Название";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(95, 60);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(120, 23);
            this.nameText.TabIndex = 20;
            // 
            // labelZP
            // 
            this.labelZP.AutoSize = true;
            this.labelZP.Location = new System.Drawing.Point(21, 101);
            this.labelZP.Name = "labelZP";
            this.labelZP.Size = new System.Drawing.Size(26, 19);
            this.labelZP.TabIndex = 21;
            this.labelZP.Text = "ЗП";
            // 
            // ZPText
            // 
            this.ZPText.Location = new System.Drawing.Point(95, 101);
            this.ZPText.Name = "ZPText";
            this.ZPText.Size = new System.Drawing.Size(120, 23);
            this.ZPText.TabIndex = 22;
            // 
            // InsertDolzhnosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 203);
            this.Controls.Add(this.ZPText);
            this.Controls.Add(this.labelZP);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.updateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InsertDolzhnosti";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "InsertDolzhnosti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroButton insertButton;
        private MetroFramework.Controls.MetroButton updateButton;
        private MetroFramework.Controls.MetroLabel labelName;
        private MetroFramework.Controls.MetroTextBox nameText;
        private MetroFramework.Controls.MetroLabel labelZP;
        private MetroFramework.Controls.MetroTextBox ZPText;
    }
}