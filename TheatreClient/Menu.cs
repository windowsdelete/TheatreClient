using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheatreClient
{
    public partial class Menu : MetroFramework.Forms.MetroForm
    {
        public Menu(int _role)
        {
            InitializeComponent();
            role = _role;
            helloLabel.Text = "Здравствуйте, " + Properties.Settings.Default.who + "!";
            switch(role)
            {
                case 0: //admin
                    администрированиеToolStripMenuItem.Visible = true;
                    lvlLabel.Text = "Ваш уровень доступа: администратор";
                    break;
                case 2: //guest
                    сотрудникиToolStripMenuItem.Visible = false;
                    работаСБилетамиToolStripMenuItem.Visible = false;
                    назначениеНаРольToolStripMenuItem.Visible = false;
                    запросыToolStripMenuItem.Visible = false;
                    lvlLabel.Text = "Ваш уровень доступа: гость";
                    break;
                case 3: //root
                    администрированиеToolStripMenuItem.Visible = true;
                    lvlLabel.Text = "Ваш уровень доступа: root";
                    break;
            }
        }

        int role;
        private void selectMenu(object sender, EventArgs e)
        {
            if ((sender as ToolStripMenuItem).Text == "Запросы")
            {
                Requests r = new Requests();
                r.Show();
            }
            else
            {
                Properties.Settings.Default.nameTable = (sender as ToolStripMenuItem).Text;
                Table t = new Table();
                t.Show();
            }
        }

        private void closeApp(object sender, FormClosedEventArgs e)
        { Application.Exit(); }

        private void Clock_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
