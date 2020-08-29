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
    public partial class InsertAuditory : MetroFramework.Forms.MetroForm
    {
        public InsertAuditory(int _id)
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
                            "Update auditory set " +
                            "NameAuditory= '" + nameAudit.Text + "'," +
                            "Vmestimost= '" + vmestAudit.Text + "' " +
                            "Where id_auditory=" + id;
                        break;
                    case "Добавить":
                        request =
                            "INSERT INTO auditory " +
                            "(NameAuditory, Vmestimost) " +
                            "values ('" + nameAudit.Text + "','" +
                            vmestAudit.Text + "')";
                        break;
                    case "Удалить":
                        request =
                            "Delete From auditory " +
                            "Where id_auditory=" + id;
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
                    ("Select * from auditory " +
                    "Where id_Auditory=" + id, dbc);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dbc.Close();
                nameAudit.Text = dt.Rows[0][1].ToString();
                vmestAudit.Text = dt.Rows[0][2].ToString();
            }
            catch { MessageBox.Show("Ошибка подключения к серверу. Попробуйте позже.", "TheatreClient", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }
        }
    }
}
