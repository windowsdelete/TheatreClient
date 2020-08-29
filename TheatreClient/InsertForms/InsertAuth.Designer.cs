namespace TheatreClient.InsertForms
{
    partial class InsertAuth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertAuth));
            this.labelLogin = new MetroFramework.Controls.MetroLabel();
            this.labelPass = new MetroFramework.Controls.MetroLabel();
            this.labelRole = new MetroFramework.Controls.MetroLabel();
            this.roleCombo = new MetroFramework.Controls.MetroComboBox();
            this.loginText = new MetroFramework.Controls.MetroTextBox();
            this.loginPass = new MetroFramework.Controls.MetroTextBox();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.insertButton = new MetroFramework.Controls.MetroButton();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(23, 60);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(47, 19);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Логин";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(23, 103);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(54, 19);
            this.labelPass.TabIndex = 1;
            this.labelPass.Text = "Пароль";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(23, 148);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(38, 19);
            this.labelRole.TabIndex = 2;
            this.labelRole.Text = "Роль";
            // 
            // roleCombo
            // 
            this.roleCombo.FormattingEnabled = true;
            this.roleCombo.ItemHeight = 23;
            this.roleCombo.Items.AddRange(new object[] {
            "Администратор",
            "Пользователь",
            "Гость",
            "root"});
            this.roleCombo.Location = new System.Drawing.Point(83, 148);
            this.roleCombo.Name = "roleCombo";
            this.roleCombo.Size = new System.Drawing.Size(179, 29);
            this.roleCombo.TabIndex = 3;
            // 
            // loginText
            // 
            this.loginText.Location = new System.Drawing.Point(83, 60);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(179, 23);
            this.loginText.TabIndex = 4;
            // 
            // loginPass
            // 
            this.loginPass.Location = new System.Drawing.Point(83, 103);
            this.loginPass.Name = "loginPass";
            this.loginPass.Size = new System.Drawing.Size(179, 23);
            this.loginPass.TabIndex = 5;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(352, 191);
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
            this.insertButton.Location = new System.Drawing.Point(138, 191);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(208, 23);
            this.insertButton.TabIndex = 17;
            this.insertButton.Text = "Добавить";
            this.insertButton.Visible = false;
            this.insertButton.Click += new System.EventHandler(this.btnAction);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updateButton.Location = new System.Drawing.Point(21, 191);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(111, 23);
            this.updateButton.TabIndex = 16;
            this.updateButton.Text = "Правка";
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.btnAction);
            // 
            // InsertAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 237);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.loginPass);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.roleCombo);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InsertAuth";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "InsertAuth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel labelLogin;
        private MetroFramework.Controls.MetroLabel labelPass;
        private MetroFramework.Controls.MetroLabel labelRole;
        private MetroFramework.Controls.MetroComboBox roleCombo;
        private MetroFramework.Controls.MetroTextBox loginText;
        private MetroFramework.Controls.MetroTextBox loginPass;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroButton insertButton;
        private MetroFramework.Controls.MetroButton updateButton;
    }
}