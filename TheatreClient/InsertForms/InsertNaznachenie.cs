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
    public partial class InsertNaznachenie : MetroFramework.Forms.MetroForm
    {
        public InsertNaznachenie(int _id)
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
                    ("Select * From Groups", dbc);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dbc.Close();
                rabCombo.DataSource = dt1;
                rabCombo.DisplayMember = "F_Rabotniki";
                rabCombo.ValueMember = "id_Rabotniki";
                groupCombo.DataSource = dt2;
                groupCombo.DisplayMember = "NameGroups";
                groupCombo.ValueMember = "id_Groups";
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
                    ("Select * from naznachenie " +
                    "Where id_naznachenie=" + id, dbc);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dbc.Close();
                rabCombo.SelectedValue = dt.Rows[0][1];
                groupCombo.SelectedValue = dt.Rows[0][2];
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
                            "Update naznachenie set " +
                            "ID_Rabotniki=" + rabCombo.SelectedValue + "," +
                            "ID_Groups=" + groupCombo.SelectedValue + " " +
                            "Where id_naznachenie=" + id;
                        break;
                    case "Добавить":
                        request =
                            "INSERT INTO naznachenie " +
                            "(ID_Rabotniki, ID_Groups) " +
                            "values (" + rabCombo.SelectedValue + "," +
                            groupCombo.SelectedValue + ")";
                        break;
                    case "Удалить":
                        request =
                            "Delete From naznachenie " +
                            "Where id_naznachenie=" + id;
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
