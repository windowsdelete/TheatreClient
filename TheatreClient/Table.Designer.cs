namespace TheatreClient
{
    partial class Table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Table));
            this.tableView = new System.Windows.Forms.DataGridView();
            this.insertWindow = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableView
            // 
            this.tableView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableView.BackgroundColor = System.Drawing.Color.White;
            this.tableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableView.Location = new System.Drawing.Point(23, 63);
            this.tableView.Name = "tableView";
            this.tableView.Size = new System.Drawing.Size(554, 385);
            this.tableView.TabIndex = 0;
            this.tableView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectToUpdate);
            // 
            // insertWindow
            // 
            this.insertWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.insertWindow.Location = new System.Drawing.Point(583, 63);
            this.insertWindow.Name = "insertWindow";
            this.insertWindow.Size = new System.Drawing.Size(210, 23);
            this.insertWindow.TabIndex = 1;
            this.insertWindow.Text = "Добавить запись";
            this.insertWindow.Click += new System.EventHandler(this.buttonsAction);
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 471);
            this.Controls.Add(this.insertWindow);
            this.Controls.Add(this.tableView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Table";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Работа с таблицой";
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableView;
        private MetroFramework.Controls.MetroButton insertWindow;
    }
}