namespace TheatreClient
{
    partial class InsertSpektakli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertSpektakli));
            this.labelName = new MetroFramework.Controls.MetroLabel();
            this.labelZhanry = new MetroFramework.Controls.MetroLabel();
            this.labelAudit = new MetroFramework.Controls.MetroLabel();
            this.labelGroup = new MetroFramework.Controls.MetroLabel();
            this.labelAutor = new MetroFramework.Controls.MetroLabel();
            this.nameText = new MetroFramework.Controls.MetroTextBox();
            this.zhanryCombo = new MetroFramework.Controls.MetroComboBox();
            this.auditCombo = new MetroFramework.Controls.MetroComboBox();
            this.groupCombo = new MetroFramework.Controls.MetroComboBox();
            this.autorCombo = new MetroFramework.Controls.MetroComboBox();
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
            // labelZhanry
            // 
            this.labelZhanry.AutoSize = true;
            this.labelZhanry.Location = new System.Drawing.Point(23, 108);
            this.labelZhanry.Name = "labelZhanry";
            this.labelZhanry.Size = new System.Drawing.Size(44, 19);
            this.labelZhanry.TabIndex = 1;
            this.labelZhanry.Text = "Жанр";
            // 
            // labelAudit
            // 
            this.labelAudit.AutoSize = true;
            this.labelAudit.Location = new System.Drawing.Point(23, 160);
            this.labelAudit.Name = "labelAudit";
            this.labelAudit.Size = new System.Drawing.Size(74, 19);
            this.labelAudit.TabIndex = 2;
            this.labelAudit.Text = "Аудитория";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(23, 209);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(52, 19);
            this.labelGroup.TabIndex = 3;
            this.labelGroup.Text = "Группа";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(23, 266);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(46, 19);
            this.labelAutor.TabIndex = 4;
            this.labelAutor.Text = "Автор";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(97, 60);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(177, 23);
            this.nameText.TabIndex = 5;
            // 
            // zhanryCombo
            // 
            this.zhanryCombo.FormattingEnabled = true;
            this.zhanryCombo.ItemHeight = 23;
            this.zhanryCombo.Location = new System.Drawing.Point(97, 108);
            this.zhanryCombo.Name = "zhanryCombo";
            this.zhanryCombo.Size = new System.Drawing.Size(177, 29);
            this.zhanryCombo.TabIndex = 6;
            // 
            // auditCombo
            // 
            this.auditCombo.FormattingEnabled = true;
            this.auditCombo.ItemHeight = 23;
            this.auditCombo.Location = new System.Drawing.Point(103, 160);
            this.auditCombo.Name = "auditCombo";
            this.auditCombo.Size = new System.Drawing.Size(171, 29);
            this.auditCombo.TabIndex = 7;
            // 
            // groupCombo
            // 
            this.groupCombo.FormattingEnabled = true;
            this.groupCombo.ItemHeight = 23;
            this.groupCombo.Location = new System.Drawing.Point(103, 209);
            this.groupCombo.Name = "groupCombo";
            this.groupCombo.Size = new System.Drawing.Size(171, 29);
            this.groupCombo.TabIndex = 8;
            // 
            // autorCombo
            // 
            this.autorCombo.FormattingEnabled = true;
            this.autorCombo.ItemHeight = 23;
            this.autorCombo.Location = new System.Drawing.Point(103, 256);
            this.autorCombo.Name = "autorCombo";
            this.autorCombo.Size = new System.Drawing.Size(171, 29);
            this.autorCombo.TabIndex = 9;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(263, 310);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 23);
            this.deleteButton.TabIndex = 21;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.btnAction);
            // 
            // insertButton
            // 
            this.insertButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insertButton.Location = new System.Drawing.Point(146, 310);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(111, 23);
            this.insertButton.TabIndex = 20;
            this.insertButton.Text = "Добавить";
            this.insertButton.Visible = false;
            this.insertButton.Click += new System.EventHandler(this.btnAction);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updateButton.Location = new System.Drawing.Point(29, 310);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(111, 23);
            this.updateButton.TabIndex = 19;
            this.updateButton.Text = "Правка";
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.btnAction);
            // 
            // InsertSpektakli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 356);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.autorCombo);
            this.Controls.Add(this.groupCombo);
            this.Controls.Add(this.auditCombo);
            this.Controls.Add(this.zhanryCombo);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelAudit);
            this.Controls.Add(this.labelZhanry);
            this.Controls.Add(this.labelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InsertSpektakli";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "InsertSpektakli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel labelName;
        private MetroFramework.Controls.MetroLabel labelZhanry;
        private MetroFramework.Controls.MetroLabel labelAudit;
        private MetroFramework.Controls.MetroLabel labelGroup;
        private MetroFramework.Controls.MetroLabel labelAutor;
        private MetroFramework.Controls.MetroTextBox nameText;
        private MetroFramework.Controls.MetroComboBox zhanryCombo;
        private MetroFramework.Controls.MetroComboBox auditCombo;
        private MetroFramework.Controls.MetroComboBox groupCombo;
        private MetroFramework.Controls.MetroComboBox autorCombo;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroButton insertButton;
        private MetroFramework.Controls.MetroButton updateButton;
    }
}