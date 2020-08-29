using MySql.Data.MySqlClient;
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
    public partial class Auth : MetroFramework.Forms.MetroForm
    {
        public Auth()
        {
            InitializeComponent();
            this.Select();
        }

        private void checkUser(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection
                    (Properties.Settings.Default.connectText);
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter
                    ("Select role From Auth " +
                    "Where log='" + loginTextbox.Text + "' " +
                    "and pass='" + passwordTextbox.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    int role = Convert.ToInt32(dt.Rows[0][0]);
                    if (role == 3)
                        Properties.Settings.Default.isRoot = true;
                    Properties.Settings.Default.who = loginTextbox.Text;
                    Menu m = new Menu(role);
                    m.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Вы ввели неправильный логин " +
                        "и/или пароль", "TheatreClient");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка подключения к серверу. Попробуйте позже.", "TheatreClient", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guestMode(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection
                    (Properties.Settings.Default.connectText);
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter
                    ("Select role From Auth " +
                    "Where log='guest' " +
                    "and pass='guest'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    int role = Convert.ToInt32(dt.Rows[0][0]);
                    Properties.Settings.Default.guestMode = true;
                    Properties.Settings.Default.who = "guest";
                    Menu m = new Menu(role);
                    m.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Вы ввели неправильный логин " +
                        "и/или пароль", "Отказано в доступе");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка подключения к серверу. Попробуйте позже.", "TheatreClient", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
