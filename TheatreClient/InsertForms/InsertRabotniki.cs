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
    public partial class InsertRabotniki : MetroFramework.Forms.MetroForm
    {
        public InsertRabotniki(int _id)
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
        void LoadString()
        {
            try
            {
                MySqlConnection dbc = new MySqlConnection(Properties.Settings.Default.connectText);
                dbc.Open();
                MySqlDataAdapter da = new MySqlDataAdapter
                    ("Select * from rabotniki " +
                    "Where id_rabotniki=" + id, dbc);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dbc.Close();
                fText.Text = dt.Rows[0][1].ToString();
                iText.Text = dt.Rows[0][2].ToString();
                oText.Text = dt.Rows[0][3].ToString();
                dateBirth.Value = Convert.ToDateTime(dt.Rows[0][4]);
                polText.Text = dt.Rows[0][5].ToString();
                rostText.Text = dt.Rows[0][6].ToString();
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
                            "Update rabotniki set " +
                            "F_Rabotniki= '" + fText.Text + "'," +
                            "I_Rabotniki= '" + iText.Text + "'," +
                            "O_Rabotniki= '" + oText.Text + "', " +
                            "BDate= '" + dateBirth.Value.ToString("yyyy-MM-dd") + "', " +
                            "Pol= '" + polText.Text + "', " +
                            "RostRabotnik= '" + rostText.Text + "' " +
                            "Where id_rabotniki=" + id;
                        break;
                    case "Добавить":
                        request =
                            "INSERT INTO rabotniki " +
                            "(F_Rabotniki, I_Rabotniki, O_Rabotniki, BDate, Pol, RostRabotnik) " +
                            "values ('" + fText.Text + "','" + iText.Text + "','" +
                            oText.Text + "','" +
                            dateBirth.Value.ToString("yyyy-MM-dd") + "','" +
                            polText.Text + "','" + rostText.Text + "')";
                        break;
                    case "Удалить":
                        request =
                            "Delete From rabotniki " +
                            "Where id_rabotniki=" + id;
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
