namespace TheatreClient
{
    partial class Requests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Requests));
            this.tableView = new System.Windows.Forms.DataGridView();
            this.reqCombo = new MetroFramework.Controls.MetroComboBox();
            this.firstParam = new MetroFramework.Controls.MetroTextBox();
            this.secondParam = new MetroFramework.Controls.MetroTextBox();
            this.firstparamLabel = new MetroFramework.Controls.MetroLabel();
            this.secondparamLabel = new MetroFramework.Controls.MetroLabel();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.datestartLabel = new MetroFramework.Controls.MetroLabel();
            this.dateendLabel = new MetroFramework.Controls.MetroLabel();
            this.executeRequest = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableView
            // 
            this.tableView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableView.BackgroundColor = System.Drawing.Color.White;
            this.tableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableView.Location = new System.Drawing.Point(23, 63);
            this.tableView.Name = "tableView";
            this.tableView.Size = new System.Drawing.Size(579, 429);
            this.tableView.TabIndex = 1;
            // 
            // reqCombo
            // 
            this.reqCombo.FormattingEnabled = true;
            this.reqCombo.ItemHeight = 23;
            this.reqCombo.Items.AddRange(new object[] {
            "Получение автора спектакля",
            "Получение даты всех поставленных спектаклей",
            "Получение количества проданных билетов по всем спектаклям",
            "Получение количества проданных билетов по указанному спектаклю",
            "Получение общей суммы вырученных денег за указанный спектакль",
            "Получение сведений о проданных билетов на спектакль за период",
            "Получение списка авторов живших в указанном веке",
            "Получение списка авторов по указанной стране",
            "Получение списка автров спектаклей указанного жанра",
            "Получение списка актеров подходящих на указанную роль",
            "Получение списка актеров со званием за указанный период",
            "Получение списка актеров со званиями по дате рождения",
            "Получение списка актеров со званиями по полу",
            "Получение списка работников для указанного спектакля",
            "Получение списка работников театра по дате рождения",
            "Получение списка работников театра по ЗП",
            "Получение списка работников театра по полу",
            "Получение списка ролей сыгранных актером за определенный период",
            "Получение списка ролей сыгранных указанным актером по автору",
            "Получение списка ролей сыгранных указанным актером по жанру",
            "Получение списка спектаклей по веку",
            "Получение списка спектаклей по жанру",
            "Получение списка спектаклей по стране",
            "Получение списка спектаклей поставленных в определенный период",
            "Получение списка спектаклей указанного автора"});
            this.reqCombo.Location = new System.Drawing.Point(608, 63);
            this.reqCombo.Name = "reqCombo";
            this.reqCombo.Size = new System.Drawing.Size(482, 29);
            this.reqCombo.TabIndex = 2;
            this.reqCombo.SelectedIndexChanged += new System.EventHandler(this.changeInd);
            // 
            // firstParam
            // 
            this.firstParam.Location = new System.Drawing.Point(608, 158);
            this.firstParam.Name = "firstParam";
            this.firstParam.Size = new System.Drawing.Size(482, 23);
            this.firstParam.TabIndex = 3;
            this.firstParam.Visible = false;
            // 
            // secondParam
            // 
            this.secondParam.Location = new System.Drawing.Point(608, 224);
            this.secondParam.Name = "secondParam";
            this.secondParam.Size = new System.Drawing.Size(482, 23);
            this.secondParam.TabIndex = 3;
            this.secondParam.Visible = false;
            // 
            // firstparamLabel
            // 
            this.firstparamLabel.AutoSize = true;
            this.firstparamLabel.Location = new System.Drawing.Point(608, 136);
            this.firstparamLabel.Name = "firstparamLabel";
            this.firstparamLabel.Size = new System.Drawing.Size(120, 19);
            this.firstparamLabel.TabIndex = 4;
            this.firstparamLabel.Text = "Первый параметр";
            this.firstparamLabel.Visible = false;
            // 
            // secondparamLabel
            // 
            this.secondparamLabel.AutoSize = true;
            this.secondparamLabel.Location = new System.Drawing.Point(608, 202);
            this.secondparamLabel.Name = "secondparamLabel";
            this.secondparamLabel.Size = new System.Drawing.Size(117, 19);
            this.secondparamLabel.TabIndex = 5;
            this.secondparamLabel.Text = "Второй параметр";
            this.secondparamLabel.Visible = false;
            // 
            // dateStart
            // 
            this.dateStart.CustomFormat = "yyyy-MM-dd ";
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStart.Location = new System.Drawing.Point(608, 291);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(177, 20);
            this.dateStart.TabIndex = 11;
            this.dateStart.Value = new System.DateTime(2019, 10, 27, 20, 31, 0, 0);
            this.dateStart.Visible = false;
            // 
            // dateEnd
            // 
            this.dateEnd.CustomFormat = "yyyy-MM-dd ";
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnd.Location = new System.Drawing.Point(608, 336);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(177, 20);
            this.dateEnd.TabIndex = 12;
            this.dateEnd.Value = new System.DateTime(2019, 10, 27, 20, 31, 0, 0);
            this.dateEnd.Visible = false;
            // 
            // datestartLabel
            // 
            this.datestartLabel.AutoSize = true;
            this.datestartLabel.Location = new System.Drawing.Point(608, 269);
            this.datestartLabel.Name = "datestartLabel";
            this.datestartLabel.Size = new System.Drawing.Size(84, 19);
            this.datestartLabel.TabIndex = 13;
            this.datestartLabel.Text = "Дата начала";
            this.datestartLabel.Visible = false;
            // 
            // dateendLabel
            // 
            this.dateendLabel.AutoSize = true;
            this.dateendLabel.Location = new System.Drawing.Point(608, 314);
            this.dateendLabel.Name = "dateendLabel";
            this.dateendLabel.Size = new System.Drawing.Size(108, 19);
            this.dateendLabel.TabIndex = 14;
            this.dateendLabel.Text = "Дата окончания";
            this.dateendLabel.Visible = false;
            // 
            // executeRequest
            // 
            this.executeRequest.Location = new System.Drawing.Point(608, 98);
            this.executeRequest.Name = "executeRequest";
            this.executeRequest.Size = new System.Drawing.Size(482, 23);
            this.executeRequest.TabIndex = 15;
            this.executeRequest.Text = "Выполнить!";
            this.executeRequest.Visible = false;
            this.executeRequest.Click += new System.EventHandler(this.execReq);
            // 
            // Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 515);
            this.Controls.Add(this.executeRequest);
            this.Controls.Add(this.dateendLabel);
            this.Controls.Add(this.datestartLabel);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.secondparamLabel);
            this.Controls.Add(this.firstparamLabel);
            this.Controls.Add(this.secondParam);
            this.Controls.Add(this.firstParam);
            this.Controls.Add(this.reqCombo);
            this.Controls.Add(this.tableView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Requests";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Запросы";
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableView;
        private MetroFramework.Controls.MetroComboBox reqCombo;
        private MetroFramework.Controls.MetroTextBox firstParam;
        private MetroFramework.Controls.MetroTextBox secondParam;
        private MetroFramework.Controls.MetroLabel firstparamLabel;
        private MetroFramework.Controls.MetroLabel secondparamLabel;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private MetroFramework.Controls.MetroLabel datestartLabel;
        private MetroFramework.Controls.MetroLabel dateendLabel;
        private MetroFramework.Controls.MetroButton executeRequest;
    }
}