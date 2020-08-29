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
    public partial class InsertTickets : MetroFramework.Forms.MetroForm
    {
        public InsertTickets(int _id)
        {
            InitializeComponent();
            id = _id;
            LoadComboBox();
            if (_id < 0)
            {
                insertButton.Visible = true;
                this.Text = "Добавление в таблицу «" + Properties.Settings.Default.nameTable + "»";
                labelDate.Visible = false;
                dateBuy.Visible = false;
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
                    ("Select * From Spektakli", dbc);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dbc.Close();
                specCombo.DataSource = dt1;
                specCombo.DisplayMember = "NameSpektakli";
                specCombo.ValueMember = "id_Spektakli";
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
                    ("Select * from tickets " +
                    "Where id_tickets=" + id, dbc);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dbc.Close();
                costText.Text = dt.Rows[0][2].ToString();
                dateBuy.Value = Convert.ToDateTime(dt.Rows[0][3]);
                specCombo.SelectedValue = dt.Rows[0][1];
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
                            "Update tickets set " +
                            "ID_Spektakli=" + specCombo.SelectedValue + "," +
                            "TicketCost= '" + costText.Text + "'," +
                            "BuyDate= '" + dateBuy.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' " +
                            "Where id_tickets=" + id;
                        break;
                    case "Добавить":
                        request =
                            "INSERT INTO tickets " +
                            "(ID_Spektakli,TicketCost,BuyDate) " +
                            "values (" + specCombo.SelectedValue + ",'" +
                            costText.Text + "','" +
                            DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                        break;
                    case "Удалить":
                        request =
                            "Delete From tickets " +
                            "Where id_tickets=" + id;
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
