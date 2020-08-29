namespace TheatreClient
{
    partial class InsertAutors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertAutors));
            this.labelAutor = new MetroFramework.Controls.MetroLabel();
            this.autorText = new MetroFramework.Controls.MetroTextBox();
            this.labelCountry = new MetroFramework.Controls.MetroLabel();
            this.labelVek = new MetroFramework.Controls.MetroLabel();
            this.countryText = new MetroFramework.Controls.MetroTextBox();
            this.vekText = new MetroFramework.Controls.MetroTextBox();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.insertButton = new MetroFramework.Controls.MetroButton();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(23, 60);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(46, 19);
            this.labelAutor.TabIndex = 0;
            this.labelAutor.Text = "Автор";
            // 
            // autorText
            // 
            this.autorText.Location = new System.Drawing.Point(75, 60);
            this.autorText.Name = "autorText";
            this.autorText.Size = new System.Drawing.Size(157, 23);
            this.autorText.TabIndex = 1;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(23, 93);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(53, 19);
            this.labelCountry.TabIndex = 2;
            this.labelCountry.Text = "Страна";
            // 
            // labelVek
            // 
            this.labelVek.AutoSize = true;
            this.labelVek.Location = new System.Drawing.Point(23, 130);
            this.labelVek.Name = "labelVek";
            this.labelVek.Size = new System.Drawing.Size(30, 19);
            this.labelVek.TabIndex = 3;
            this.labelVek.Text = "Век";
            // 
            // countryText
            // 
            this.countryText.Location = new System.Drawing.Point(75, 93);
            this.countryText.Name = "countryText";
            this.countryText.Size = new System.Drawing.Size(157, 23);
            this.countryText.TabIndex = 4;
            // 
            // vekText
            // 
            this.vekText.Location = new System.Drawing.Point(75, 130);
            this.vekText.Name = "vekText";
            this.vekText.Size = new System.Drawing.Size(157, 23);
            this.vekText.TabIndex = 5;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(259, 179);
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
            this.insertButton.Location = new System.Drawing.Point(142, 179);
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
            this.updateButton.Location = new System.Drawing.Point(25, 179);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(111, 23);
            this.updateButton.TabIndex = 16;
            this.updateButton.Text = "Правка";
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.btnAction);
            // 
            // InsertAutors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 217);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.vekText);
            this.Controls.Add(this.countryText);
            this.Controls.Add(this.labelVek);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.autorText);
            this.Controls.Add(this.labelAutor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InsertAutors";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "InsertAutors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel labelAutor;
        private MetroFramework.Controls.MetroTextBox autorText;
        private MetroFramework.Controls.MetroLabel labelCountry;
        private MetroFramework.Controls.MetroLabel labelVek;
        private MetroFramework.Controls.MetroTextBox countryText;
        private MetroFramework.Controls.MetroTextBox vekText;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroButton insertButton;
        private MetroFramework.Controls.MetroButton updateButton;
    }
}