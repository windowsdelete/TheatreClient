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
    public partial class InsertAutors : MetroFramework.Forms.MetroForm
    {
        public InsertAutors(int _id)
        {
            InitializeComponent();
            id = _id;
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

        int id;
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
                            "Update autors set " +
                            "NameAutor= '" + autorText.Text + "'," +
                            "CountryAutor= '" + countryText.Text + "', " +
                            "VekAutor= '" + vekText.Text + "' " +
                            "Where id_autors=" + id;
                        break;
                    case "Добавить":
                        request =
                            "INSERT INTO autors " +
                            "(NameAutor, CountryAutor, VekAutor) " +
                            "values ('" + autorText.Text + "','" +
                            countryText.Text + "','" + vekText.Text + "')";
                        break;
                    case "Удалить":
                        request =
                            "Delete From autors " +
                            "Where id_autors=" + id;
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

        void LoadString()
        {
            try
            {
                MySqlConnection dbc = new MySqlConnection(Properties.Settings.Default.connectText);
                dbc.Open();
                MySqlDataAdapter da = new MySqlDataAdapter
                    ("Select * from autors " +
                    "Where id_Autors=" + id, dbc);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dbc.Close();
                autorText.Text = dt.Rows[0][1].ToString();
                countryText.Text = dt.Rows[0][2].ToString();
                vekText.Text = dt.Rows[0][3].ToString();
            }
            catch { MessageBox.Show("Ошибка подключения к серверу. Попробуйте позже.", "TheatreClient", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }
        }
    }
}
