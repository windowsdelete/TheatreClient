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
    public partial class InsertAbonimenty : MetroFramework.Forms.MetroForm
    {
        public InsertAbonimenty(int _id)
        {
            InitializeComponent();
            id = _id;
            LoadComboBox();
            if (_id < 0)
            {
                insertButton.Visible = true;
                this.Text = "Добавление в таблицу «" + Properties.Settings.Default.nameTable + "»";
                labelBuy.Visible = false;
                labelOut.Visible = false;
                dateBuy.Visible = false;
                dateOut.Visible = false;
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
                    ("Select * From Zhanry", dbc);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dbc.Close();
                comboZhanry.DataSource = dt1;
                comboZhanry.DisplayMember = "NameZhanry";
                comboZhanry.ValueMember = "id_Zhanry";
            }
            catch
            { MessageBox.Show("Ошибка подключения к серверу. Попробуйте позже.", "TheatreClient", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }
        }

        int id;
        void LoadString()
        {
            try
            {
                MySqlConnection dbc = new MySqlConnection(Properties.Settings.Default.connectText);
                dbc.Open();
                MySqlDataAdapter da = new MySqlDataAdapter
                    ("Select * from abonimenty " +
                    "Where id_Abonimenty=" + id, dbc);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dbc.Close();
                textboxCost.Text = dt.Rows[0][2].ToString();
                dateBuy.Value = Convert.ToDateTime(dt.Rows[0][3]);
                dateOut.Value = Convert.ToDateTime(dt.Rows[0][4]);
                comboZhanry.SelectedValue = dt.Rows[0][1];
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
                            "Update abonimenty set " +
                            "ID_Zhanry=" + comboZhanry.SelectedValue + "," +
                            "AbonimentCost= '" + textboxCost.Text + "'," +
                            "AbonimentBuyDate= '" + dateBuy.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                            "AbonimentOutDate= '" + dateOut.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' " +
                            "Where id_Abonimenty=" + id;
                        break;
                    case "Добавить":
                        request =
                            "INSERT INTO abonimenty " +
                            "(ID_Zhanry,AbonimentCost,AbonimentBuyDate,AbonimentOutDate) " +
                            "values (" + comboZhanry.SelectedValue + ",'" +
                            textboxCost.Text + "','" +
                            DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" +
                            DateTime.Now.AddDays(7).ToString("yyyy-MM-dd HH:mm:ss") + "')";
                        break;
                    case "Удалить":
                        request =
                            "Delete From Abonimenty " +
                            "Where id_Abonimenty=" + id;
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
