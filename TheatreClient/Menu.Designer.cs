namespace TheatreClient
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuTheatre = new System.Windows.Forms.MenuStrip();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приемToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назначениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.званияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выдачаЗванийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСТеатромToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спектаклиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ролиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назначениеНаРольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жанрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гастролиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аудиторииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСБилетамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.билетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.абониментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учётныеЗаписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloLabel = new MetroFramework.Controls.MetroLabel();
            this.lvlLabel = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.clockLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.menuTheatre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuTheatre
            // 
            this.menuTheatre.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникиToolStripMenuItem,
            this.работаСТеатромToolStripMenuItem,
            this.работаСБилетамиToolStripMenuItem,
            this.администрированиеToolStripMenuItem,
            this.запросыToolStripMenuItem});
            this.menuTheatre.Location = new System.Drawing.Point(20, 60);
            this.menuTheatre.Name = "menuTheatre";
            this.menuTheatre.Size = new System.Drawing.Size(870, 24);
            this.menuTheatre.TabIndex = 0;
            this.menuTheatre.Text = "menuTable";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.приемToolStripMenuItem,
            this.работникиToolStripMenuItem,
            this.должностиToolStripMenuItem,
            this.назначениеToolStripMenuItem,
            this.званияToolStripMenuItem,
            this.выдачаЗванийToolStripMenuItem,
            this.группыToolStripMenuItem});
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.сотрудникиToolStripMenuItem.Text = "Работа с сотрудниками";
            // 
            // приемToolStripMenuItem
            // 
            this.приемToolStripMenuItem.Name = "приемToolStripMenuItem";
            this.приемToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.приемToolStripMenuItem.Text = "Прием";
            this.приемToolStripMenuItem.Click += new System.EventHandler(this.selectMenu);
            // 
            // работникиToolStripMenuItem
            // 
            this.работникиToolStripMenuItem.Name = "работникиToolStripMenuItem";
            this.работникиToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.работникиToolStripMenuItem.Text = "Работники";
            this.работникиToolStripMenuItem.Click += new System.EventHandler(this.selectMenu);
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.должностиToolStripMenuItem.Text = "Должности";
            this.должностиToolStripMenuItem.Click += new System.EventHandler(this.selectMenu);
            // 
            // назначениеToolStripMenuItem
            // 
            this.назначениеToolStripMenuItem.Name = "назначениеToolStripMenuItem";
            this.назначениеToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.назначениеToolStripMenuItem.Text = "Назначение";
            this.назначениеToolStripMenuItem.Click += new System.EventHandler(this.selectMenu);
            // 
            // званияToolStripMenuItem
            // 
            this.званияToolStripMenuItem.Name = "званияToolStripMenuItem";
            this.званияToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.званияToolStripMenuItem.Text = "Звания";
            this.званияToolStripMenuItem.Click += new System.EventHandler(this.selectMenu);
            // 
            // выдачаЗванийToolStripMenuItem
            // 
            this.выдачаЗванийToolStripMenuItem.Name = "выдачаЗванийToolStripMenuItem";
            this.выдачаЗванийToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.выдачаЗванийToolStripMenuItem.Text = "Выдача званий";
            this.выдачаЗванийToolStripMenuItem.Click += new System.EventHandler(this.selectMenu);
            // 
            // группыToolStripMenuItem
            // 
            this.группыToolStripMenuItem.Name = "группыToolStripMenuItem";
            this.группыToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.группыToolStripMenuItem.Text = "Группы";
            this.группыToolStripMenuItem.Click += new System.EventHandler(this.selectMenu);
            // 
            // работаСТеатромToolStripMenuItem
            // 
            this.работаСТеатромToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.спектаклиToolStripMenuItem1,
            this.ролиToolStripMenuItem,
            this.назначениеНаРольToolStripMenuItem,
            this.жанрыToolStripMenuItem,
            this.гастролиToolStripMenuItem,
            this.авторыToolStripMenuItem,
            this.аудиторииToolStripMenuItem});
            this.работаСТеатромToolStripMenuItem.Name = "работаСТеатромToolStripMenuItem";
            this.работаСТеатромToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.работаСТеатромToolStripMenuItem.Text = "Работа с театром";
            // 
            // спектаклиToolStripMenuItem1
            // 
            this.спектаклиToolStripMenuItem1.Name = "спектаклиToolStripMenuItem1";
            this.спектаклиToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.спектаклиToolStripMenuItem1.Text = "Спектакли";
            this.спектаклиToolStripMenuItem1.Click += new System.EventHandler(this.selectMenu);
            // 
            // ролиToolStripMenuItem
            // 
            this.ролиToolStripMenuItem.Name = "ролиToolStripMenuItem";
            this.ролиToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ролиToolStripMenuItem.Text = "Роли";
            this.ролиToolStripMenuItem.Click += new System.EventHandler(this.selectMenu);
            // 
            // назначениеНаРольToolStripMenuItem
            // 
            this.назначениеНаРольToolStripMenuItem.Name = "назначениеНаРольToolStripMenuItem";
            this.назначениеНаРольToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.назначениеНаРольToolStripMenuItem.Text = "Назначение на роль";
            this.назначениеНаРольToolStripMenuItem.Click += new System.EventHandler(this.selectMenu);
            // 
            // жанрыToolStripMenuItem
            // 
            this.жанрыToolStripMenuItem.Name = "жанрыToolStripMenuItem";
            this.жанрыToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.жанрыToolStripMenuItem.Text = "Жанры";
            this.жанрыToolStripMenuItem.Click += new System.EventHandler(this.selectMenu);
            // 
            // гастролиToolStripMenuItem
            // 
            this.гастролиToolStripMenuItem.Name = "гастролиToolStripMenuItem";
            this.гастролиToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.гастролиToolStripMenuItem.Text = "Гастроли";
            this.гастролиToolStripMenuItem.Click += new System.EventHandler(this.selectMenu);
            // 
            // авторыToolStripMenuItem
            // 
            this.авторыToolStripMenuItem.Name = "авторыToolStripMenuItem";
            this.авторыToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.авторыToolStripMenuItem.Text = "Авторы";
            this.авторыToolStripMenuItem.Click += new System.EventHandler(this.selectMenu);
            // 
            // аудиторииToolStripMenuItem
            // 
            this.аудиторииToolStripMenuItem.Name = "аудиторииToolStripMenuItem";
            this.аудиторииToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.аудиторииToolStripMenuItem.Text = "Аудитории";
            this.аудиторииToolStripMenuItem.Click += new System.EventHandler(this.selectMenu);
            // 
            // работаСБилетамиToolStripMenuItem
            // 
            this.работаСБилетамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.билетыToolStripMenuItem,
            this.абониментыToolStripMenuItem});
            this.работаСБилетамиToolStripMenuItem.Name = "работаСБилетамиToolStripMenuItem";
            this.работаСБилетамиToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.работаСБилетамиToolStripMenuItem.Text = "Работа с билетами";
            // 
            // билетыToolStripMenuItem
            // 
            this.билетыToolStripMenuItem.Name = "билетыToolStripMenuItem";
            this.билетыToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.билетыToolStripMenuItem.Text = "Билеты";
            this.билетыToolStripMenuItem.Click += new System.EventHandler(this.selectMenu);
            // 
            // абониментыToolStripMenuItem
            // 
            this.абониментыToolStripMenuItem.Name = "абониментыToolStripMenuItem";
            this.абониментыToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.абониментыToolStripMenuItem.Text = "Абонименты";
            this.абониментыToolStripMenuItem.Click += new System.EventHandler(this.selectMenu);
            // 
            // администрированиеToolStripMenuItem
            // 
            this.администрированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.учётныеЗаписиToolStripMenuItem});
            this.администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
            this.администрированиеToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.администрированиеToolStripMenuItem.Text = "Администрирование";
            this.администрированиеToolStripMenuItem.Visible = false;
            // 
            // учётныеЗаписиToolStripMenuItem
            // 
            this.учётныеЗаписиToolStripMenuItem.Name = "учётныеЗаписиToolStripMenuItem";
            this.учётныеЗаписиToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.учётныеЗаписиToolStripMenuItem.Text = "Учётные записи";
            this.учётныеЗаписиToolStripMenuItem.Click += new System.EventHandler(this.selectMenu);
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.запросыToolStripMenuItem.Text = "Запросы";
            this.запросыToolStripMenuItem.Click += new System.EventHandler(this.selectMenu);
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Location = new System.Drawing.Point(552, 84);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(180, 19);
            this.helloLabel.TabIndex = 1;
            this.helloLabel.Text = "Здравствуйте, %username%!";
            // 
            // lvlLabel
            // 
            this.lvlLabel.AutoSize = true;
            this.lvlLabel.Location = new System.Drawing.Point(641, 103);
            this.lvlLabel.Name = "lvlLabel";
            this.lvlLabel.Size = new System.Drawing.Size(229, 19);
            this.lvlLabel.TabIndex = 2;
            this.lvlLabel.Text = "Ваш уровень доступа: пользователь";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TheatreClient.Properties.Resources.tricon;
            this.pictureBox1.Location = new System.Drawing.Point(757, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Clock
            // 
            this.Clock.Enabled = true;
            this.Clock.Interval = 1000;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.clockLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.clockLabel.Location = new System.Drawing.Point(20, 257);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(126, 25);
            this.clockLabel.TabIndex = 4;
            this.clockLabel.Text = "ЗагрузОЧКА...";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(335, 173);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(211, 25);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Moscow Theatre Database";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 302);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.clockLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lvlLabel);
            this.Controls.Add(this.helloLabel);
            this.Controls.Add(this.menuTheatre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuTheatre;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Выбор таблицы базы данных театра";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeApp);
            this.menuTheatre.ResumeLayout(false);
            this.menuTheatre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTheatre;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приемToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назначениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem званияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выдачаЗванийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСТеатромToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem спектаклиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ролиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назначениеНаРольToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem жанрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гастролиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аудиторииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСБилетамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem билетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem абониментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администрированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учётныеЗаписиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel helloLabel;
        private MetroFramework.Controls.MetroLabel lvlLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer Clock;
        private MetroFramework.Controls.MetroLabel clockLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

