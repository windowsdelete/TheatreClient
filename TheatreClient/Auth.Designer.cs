namespace TheatreClient
{
    partial class Auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.logLabel = new MetroFramework.Controls.MetroLabel();
            this.loginTextbox = new MetroFramework.Controls.MetroTextBox();
            this.passLabel = new MetroFramework.Controls.MetroLabel();
            this.passwordTextbox = new MetroFramework.Controls.MetroTextBox();
            this.loginButton = new MetroFramework.Controls.MetroButton();
            this.guestButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(23, 60);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(47, 19);
            this.logLabel.TabIndex = 0;
            this.logLabel.Text = "Логин";
            // 
            // loginTextbox
            // 
            this.loginTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginTextbox.Location = new System.Drawing.Point(92, 60);
            this.loginTextbox.Name = "loginTextbox";
            this.loginTextbox.Size = new System.Drawing.Size(160, 23);
            this.loginTextbox.TabIndex = 1;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(23, 99);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(54, 19);
            this.passLabel.TabIndex = 2;
            this.passLabel.Text = "Пароль";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(92, 99);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(160, 23);
            this.passwordTextbox.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(23, 129);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(251, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Войти";
            this.loginButton.Click += new System.EventHandler(this.checkUser);
            // 
            // guestButton
            // 
            this.guestButton.Location = new System.Drawing.Point(23, 158);
            this.guestButton.Name = "guestButton";
            this.guestButton.Size = new System.Drawing.Size(251, 23);
            this.guestButton.TabIndex = 4;
            this.guestButton.Text = "Войти как гость";
            this.guestButton.Click += new System.EventHandler(this.guestMode);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 199);
            this.Controls.Add(this.guestButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.loginTextbox);
            this.Controls.Add(this.logLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Auth";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel logLabel;
        private MetroFramework.Controls.MetroTextBox loginTextbox;
        private MetroFramework.Controls.MetroLabel passLabel;
        private MetroFramework.Controls.MetroTextBox passwordTextbox;
        private MetroFramework.Controls.MetroButton loginButton;
        private MetroFramework.Controls.MetroButton guestButton;
    }
}