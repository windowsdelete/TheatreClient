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

namespace TheatreClient.InsertForms
{
    public partial class InsertAuth : MetroFramework.Forms.MetroForm
    {
        public InsertAuth(int _id)
        {
            InitializeComponent();
            id = _id;
            if (_id < 0)
            {
                insertButton.Visible = true;
                this.Text = "Добавление в таблицу «" + Properties.Settings.Default.nameTable + "»";
                check = -1;
            }
            else
            {
                this.Text = "Правка в таблице «" + Properties.Settings.Default.nameTable + "»";
                deleteButton.Visible = true;
                updateButton.Visible = true;
                LoadString();
            }
        }

        int id, check;
        string btn, request;
        private void btnAction(object sender, EventArgs e)
        {
            if (loginText.Text.Contains(" ") || loginText.Text == "")
            { MessageBox.Show("Логин не может быть пустым или содержать пробел!", "TheatreClient", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                try
                {
                    if (Properties.Settings.Default.isRoot == false && (roleCombo.SelectedIndex == 0 || roleCombo.SelectedIndex == 3 || check == 0 || check == 3))
                    {
                        MessageBox.Show("Извините, у вас не хватает доступа.", "TheatreClient", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        btn = (sender as Button).Text;
                        MySqlConnection dbc = new MySqlConnection(Properties.Settings.Default.connectText);
                        dbc.Open();
                        switch (btn)
                        {
                            case "Правка":
                                request =
                                    "Update auth set " +
                                    "Log= '" + loginText.Text + "'," +
                                    "Pass= '" + loginPass.Text + "', " +
                                    "Role=" + roleCombo.SelectedIndex + " " +
                                    "Where id_auth=" + id;
                                break;
                            case "Добавить":
                                request =
                                    "INSERT INTO auth " +
                                    "(Log, Pass, Role) " +
                                    "values ('" + loginText.Text + "','" +
                                    loginPass.Text + "'," + roleCombo.SelectedIndex + ")";
                                break;
                            case "Удалить":
                                request =
                                    "Delete From auth " +
                                    "Where id_auth=" + id;
                                break;
                        }
                        MySqlDataAdapter da = new MySqlDataAdapter(request, dbc);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dbc.Close();
                        Close();
                    }
                }
                catch { MessageBox.Show("Ошибка подключения к серверу. Попробуйте позже.", "TheatreClient", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }
            }
        }

        void LoadString()
        {
            try {
                MySqlConnection dbc = new MySqlConnection(Properties.Settings.Default.connectText);
                dbc.Open();
                MySqlDataAdapter da = new MySqlDataAdapter
                    ("Select * from auth " +
                    "Where id_auth=" + id, dbc);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dbc.Close();
                loginText.Text = dt.Rows[0][1].ToString();
                loginPass.Text = dt.Rows[0][2].ToString();
                roleCombo.SelectedIndex = Convert.ToInt32(dt.Rows[0][3]);
                check = roleCombo.SelectedIndex;
                }
            catch { MessageBox.Show("Ошибка подключения к серверу. Попробуйте позже.", "TheatreClient", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }
            }
    }
}
