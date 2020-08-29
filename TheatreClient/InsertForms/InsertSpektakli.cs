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
    public partial class InsertSpektakli : MetroFramework.Forms.MetroForm
    {
        public InsertSpektakli(int _id)
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
                    ("Select * From Zhanry", dbc);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                MySqlDataAdapter da2 = new MySqlDataAdapter
                    ("Select * From Auditory", dbc);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                MySqlDataAdapter da3 = new MySqlDataAdapter
                    ("Select * From Groups", dbc);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                MySqlDataAdapter da4 = new MySqlDataAdapter
                    ("Select * From Autors", dbc);
                DataTable dt4 = new DataTable();
                da4.Fill(dt4);
                dbc.Close();
                zhanryCombo.DataSource = dt1;
                zhanryCombo.DisplayMember = "NameZhanry";
                zhanryCombo.ValueMember = "id_Zhanry";
                auditCombo.DataSource = dt2;
                auditCombo.DisplayMember = "NameAuditory";
                auditCombo.ValueMember = "id_Auditory";
                groupCombo.DataSource = dt3;
                groupCombo.DisplayMember = "NameGroups";
                groupCombo.ValueMember = "id_Groups";
                autorCombo.DataSource = dt4;
                autorCombo.DisplayMember = "NameAutor";
                autorCombo.ValueMember = "id_Autors";
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
                    ("Select * from spektakli " +
                    "Where id_spektakli=" + id, dbc);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dbc.Close();
                nameText.Text = dt.Rows[0][1].ToString();
                zhanryCombo.SelectedValue = dt.Rows[0][2];
                auditCombo.SelectedValue = dt.Rows[0][3];
                groupCombo.SelectedValue = dt.Rows[0][4];
                autorCombo.SelectedValue = dt.Rows[0][5];
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
                            "Update spektakli set " +
                            "NameSpektakli= '" + nameText.Text + "', " +
                            "ID_Zhanry=" + zhanryCombo.SelectedValue + "," +
                            "ID_Auditory=" + auditCombo.SelectedValue + ", " +
                            "ID_Groups=" + groupCombo.SelectedValue + ", " +
                            "ID_Autors=" + autorCombo.SelectedValue + " " +
                            "Where id_spektakli=" + id;
                        break;
                    case "Добавить":
                        request =
                            "INSERT INTO spektakli " +
                            "(NameSpektakli, ID_Zhanry, ID_Auditory, ID_Groups, ID_Autors) " +
                            "values ('" + nameText.Text + "'," + zhanryCombo.SelectedValue + "," +
                            auditCombo.SelectedValue + "," + groupCombo.SelectedValue + "," + autorCombo.SelectedValue + ")";
                        break;
                    case "Удалить":
                        request =
                            "Delete From spektakli " +
                            "Where id_spektakli=" + id;
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
