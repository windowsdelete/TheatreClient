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
    public partial class InsertPriem : MetroFramework.Forms.MetroForm
    {
        public InsertPriem(int _id)
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
                    ("Select * From Dolzhnosti", dbc);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dbc.Close();
                rabCombo.DataSource = dt1;
                rabCombo.DisplayMember = "F_Rabotniki";
                rabCombo.ValueMember = "id_Rabotniki";
                dolzCombo.DataSource = dt2;
                dolzCombo.DisplayMember = "NameDolzhnosti";
                dolzCombo.ValueMember = "id_Dolzhnosti";
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
                    ("Select * from priem " +
                    "Where id_priem=" + id, dbc);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dbc.Close();
                rabCombo.SelectedValue = dt.Rows[0][1];
                dolzCombo.SelectedValue = dt.Rows[0][2];
                dateCome.Value = Convert.ToDateTime(dt.Rows[0][3]);
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
                            "Update priem set " +
                            "ID_Rabotniki=" + rabCombo.SelectedValue + "," +
                            "ID_Dolzhnosti=" + dolzCombo.SelectedValue + "," +
                            "PriemDate= '" + dateCome.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' " +
                            "Where id_priem=" + id;
                        break;
                    case "Добавить":
                        request =
                            "INSERT INTO priem " +
                            "(ID_Rabotniki, ID_Dolzhnosti, PriemDate) " +
                            "values (" + rabCombo.SelectedValue + "," +
                            dolzCombo.SelectedValue + ",'" +
                            dateCome.Value.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                        break;
                    case "Удалить":
                        request =
                            "Delete From priem " +
                            "Where id_priem=" + id;
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
