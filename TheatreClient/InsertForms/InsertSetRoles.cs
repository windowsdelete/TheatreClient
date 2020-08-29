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
    public partial class InsertSetRoles : MetroFramework.Forms.MetroForm
    {
        public InsertSetRoles(int _id)
        {
            InitializeComponent();
            id = _id;
            LoadComboBox();
            if (_id < 0)
            {
                insertButton.Visible = true;
                this.Text = "Добавление в таблицу «" + Properties.Settings.Default.nameTable + "»";
            }
            else
            {
                this.Text = "Правка в таблице «" + Properties.Settings.Default.nameTable + "»";
                deleteButton.Visible = true;
                updateButton.Visible = true;
                LoadString();
            }
        }

        void LoadComboBox()
        {
            try
            {
                MySqlConnection dbc = new MySqlConnection(Properties.Settings.Default.connectText);
                dbc.Open();
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From Rabotniki", dbc);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                MySqlDataAdapter da2 = new MySqlDataAdapter
                    ("Select * From Roles", dbc);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dbc.Close();
                rabCombo.DataSource = dt1;
                rabCombo.DisplayMember = "F_Rabotniki";
                rabCombo.ValueMember = "id_Rabotniki";
                roleCombo.DataSource = dt2;
                roleCombo.DisplayMember = "NameRole";
                roleCombo.ValueMember = "id_Roles";
            }
            catch { MessageBox.Show("Ошибка подключения к серверу. Попробуйте позже.", "TheatreClient", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }
        }

        int id;
        void LoadString()
        {
            try
            {
                MySqlConnection dbc = new MySqlConnection(Properties.Settings.Default.connectText);
                dbc.Open();
                MySqlDataAdapter da = new MySqlDataAdapter
                    ("Select * from setroles " +
                    "Where id_setroles=" + id, dbc);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dbc.Close();
                rabCombo.SelectedValue = dt.Rows[0][1];
                roleCombo.SelectedValue = dt.Rows[0][2];
                dateSet.Value = Convert.ToDateTime(dt.Rows[0][3]);
            }
            catch { MessageBox.Show("Ошибка подключения к серверу. Попробуйте позже.", "TheatreClient", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }
        }

        string btn, request;
        private void btnAction(object sender, EventArgs e)
        {
            try
            {
                btn = (sender as Button).Text;
                MySqlConnection dbc = new MySqlConnection(Properties.Settings.Default.connectText);
                dbc.Open();
                switch (btn)
                {
                    case "Правка":
                        request =
                            "Update setroles set " +
                            "ID_Rabotniki=" + rabCombo.SelectedValue + "," +
                            "ID_Roles=" + roleCombo.SelectedValue + ", " +
                            "SetDate= '" + dateSet.Value.ToString("yyyy-MM-dd") + "' " +
                            "Where id_setroles=" + id;
                        break;
                    case "Добавить":
                        request =
                            "INSERT INTO setroles " +
                            "(ID_Rabotniki, ID_Roles, SetDate) " +
                            "values (" + rabCombo.SelectedValue + "," +
                            roleCombo.SelectedValue + ",'" + dateSet.Value.ToString("yyyy-MM-dd") + "')";
                        break;
                    case "Удалить":
                        request =
                            "Delete From setroles " +
                            "Where id_setroles=" + id;
                        break;
                }
                MySqlDataAdapter da = new MySqlDataAdapter(request, dbc);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dbc.Close();
                Close();
            }
            catch { MessageBox.Show("Ошибка подключения к серверу. Попробуйте позже.", "TheatreClient", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }
        }
    }
}
