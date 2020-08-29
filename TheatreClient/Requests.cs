using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class Requests : MetroFramework.Forms.MetroForm
    {
        public Requests()
        {
            InitializeComponent();
        }
        ArrayList empty = new ArrayList();
        string request;
        private void changeInd(object sender, EventArgs e)
        {
            firstParam.Visible = false;
            firstparamLabel.Visible = false;
            secondParam.Visible = false;
            secondparamLabel.Visible = false;
            dateStart.Visible = false;
            datestartLabel.Visible = false;
            dateEnd.Visible = false;
            dateendLabel.Visible = false;
            executeRequest.Visible = true;
            firstParam.Text = "";
            secondParam.Text = "";
            tableView.DataSource = empty;
            switch (reqCombo.SelectedIndex)
            {
                case 0:
                    firstParam.Visible = true;
                    firstparamLabel.Visible = true;
                    firstparamLabel.Text = "Название спектакля";
                    break;
                case 3:
                    firstParam.Visible = true;
                    firstparamLabel.Visible = true;
                    firstparamLabel.Text = "Название спектакля";
                    dateStart.Visible = true;
                    datestartLabel.Visible = true;
                    dateEnd.Visible = true;
                    dateendLabel.Visible = true;
                    break;
                case 4:
                    firstParam.Visible = true;
                    firstparamLabel.Visible = true;
                    firstparamLabel.Text = "Название спектакля";
                    break;
                case 5:
                    firstParam.Visible = true;
                    firstparamLabel.Visible = true;
                    firstparamLabel.Text = "Название спектакля";
                    dateStart.Visible = true;
                    datestartLabel.Visible = true;
                    dateEnd.Visible = true;
                    dateendLabel.Visible = true;
                    break;
                case 6:
                    firstParam.Visible = true;
                    firstparamLabel.Visible = true;
                    firstparamLabel.Text = "Век";
                    break;
                case 7:
                    firstParam.Visible = true;
                    firstparamLabel.Visible = true;
                    firstparamLabel.Text = "Страна";
                    break;
                case 8:
                    firstParam.Visible = true;
                    firstparamLabel.Visible = true;
                    firstparamLabel.Text = "Жанр";
                    break;
                case 9:
                    firstParam.Visible = true;
                    firstparamLabel.Visible = true;
                    firstparamLabel.Text = "Роль";
                    break;
                case 10:
                    firstParam.Visible = true;
                    firstparamLabel.Visible = true;
                    firstparamLabel.Text = "Премия";
                    dateStart.Visible = true;
                    datestartLabel.Visible = true;
                    dateEnd.Visible = true;
                    dateendLabel.Visible = true;
                    break;
                case 11:
                    dateStart.Visible = true;
                    datestartLabel.Visible = true;
                    dateEnd.Visible = true;
                    dateendLabel.Visible = true;
                    break;
                case 12:
                    firstParam.Visible = true;
                    firstparamLabel.Visible = true;
                    firstparamLabel.Text = "Пол";
                    break;
                case 13:
                    firstParam.Visible = true;
                    firstparamLabel.Visible = true;
                    firstparamLabel.Text = "Название спектакля";
                    break;
                case 14:
                    dateStart.Visible = true;
                    datestartLabel.Visible = true;
                    dateEnd.Visible = true;
                    dateendLabel.Visible = true;
                    break;
                case 15:
                    firstParam.Visible = true;
                    firstparamLabel.Visible = true;
                    firstparamLabel.Text = "От";
                    secondParam.Visible = true;
                    secondparamLabel.Visible = true;
                    secondparamLabel.Text = "До";
                    break;
                case 16:
                    firstParam.Visible = true;
                    firstparamLabel.Visible = true;
                    firstparamLabel.Text = "Пол";
                    break;
                case 17:
                    dateStart.Visible = true;
                    datestartLabel.Visible = true;
                    dateEnd.Visible = true;
                    dateendLabel.Visible = true;
                    break;
                case 18:
                    firstParam.Visible = true;
                    firstparamLabel.Visible = true;
                    firstparamLabel.Text = "Автор";
                    break;
                case 19:
                    firstParam.Visible = true;
                    firstparamLabel.Visible = true;
                    firstparamLabel.Text = "Жанр";
                    break;
                case 20:
                    firstParam.Visible = true;
                    firstparamLabel.Visible = true;
                    firstparamLabel.Text = "Век";
                    break;
                case 21:
                    firstParam.Visible = true;
                    firstparamLabel.Visible = true;
                    firstparamLabel.Text = "Жанр";
                    break;
                case 22:
                    firstParam.Visible = true;
                    firstparamLabel.Visible = true;
                    firstparamLabel.Text = "Страна";
                    break;
                case 23:
                    dateStart.Visible = true;
                    datestartLabel.Visible = true;
                    dateEnd.Visible = true;
                    dateendLabel.Visible = true;
                    break;
                case 24:
                    firstParam.Visible = true;
                    firstparamLabel.Visible = true;
                    firstparamLabel.Text = "Автор";
                    break;
            }
        }

        private void execReq(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection dbc = new MySqlConnection(Properties.Settings.Default.connectText);
                dbc.Open();
                switch (reqCombo.SelectedIndex)
                {
                    case 0:
                        request = "SELECT Spektakli.NameSpektakli, Autors.NameAutor FROM Autors INNER JOIN Spektakli ON Autors.ID_Autors = Spektakli.ID_Autors GROUP BY Spektakli.NameSpektakli, Autors.NameAutor HAVING(((Spektakli.NameSpektakli)Like " + "\"" + firstParam.Text + "\"" + "));";
                        break;
                    case 1:
                        request = "SELECT Spektakli.NameSpektakli, Gastroli.SDate FROM Spektakli INNER JOIN Gastroli ON Spektakli.ID_Spektakli = Gastroli.ID_Spektakli WHERE(((Gastroli.SDate) < Now()));";
                        break;
                    case 2:
                        request = "SELECT Spektakli.NameSpektakli, Count(Tickets.ID_Tickets) AS `Количество` FROM Spektakli INNER JOIN Tickets ON Spektakli.ID_Spektakli = Tickets.ID_Spektakli GROUP BY Spektakli.NameSpektakli; ";
                        break;
                    case 3:
                        request = "SELECT Spektakli.NameSpektakli, Count(Tickets.ID_Tickets) AS `Количество`, Tickets.BuyDate FROM Spektakli INNER JOIN Tickets ON Spektakli.ID_Spektakli = Tickets.ID_Spektakli GROUP BY Spektakli.NameSpektakli, Tickets.BuyDate HAVING(((Spektakli.NameSpektakli)Like " + "\"" + firstParam.Text + "\"" + ") AND((Tickets.BuyDate)Between " + "\"" + dateStart.Value.ToString("yyyy-MM-dd HH:mm:ss") + "\"" + " And " + "\"" + dateEnd.Value.ToString("yyyy-MM-dd HH:mm:ss") + "\"" + "));";
                        break;
                    case 4:
                        request = "SELECT Spektakli.NameSpektakli, Sum(Tickets.TicketCost) AS `Сумма` FROM Spektakli INNER JOIN Tickets ON Spektakli.ID_Spektakli = Tickets.ID_Spektakli GROUP BY Spektakli.NameSpektakli HAVING(((Spektakli.NameSpektakli)Like " + "\"" + firstParam.Text + "\"" + ")); ";
                        break;
                    case 5:
                        request = "SELECT Spektakli.NameSpektakli, Count(Tickets.ID_Tickets) AS `Количество`, Tickets.BuyDate FROM Spektakli INNER JOIN Tickets ON Spektakli.ID_Spektakli = Tickets.ID_Spektakli GROUP BY Spektakli.NameSpektakli, Tickets.BuyDate HAVING(((Spektakli.NameSpektakli)Like " + "\"" + firstParam.Text + "\"" + ") AND((Tickets.BuyDate)Between " + "\"" + dateStart.Value.ToString("yyyy-MM-dd HH:mm:ss") + "\"" + " And " + "\"" + dateEnd.Value.ToString("yyyy-MM-dd HH:mm:ss") + "\"" + "));";
                        break;
                    case 6:
                        request = "SELECT Autors.NameAutor, Autors.VekAutor FROM Autors WHERE(((Autors.VekAutor) = " + "\"" + firstParam.Text + "\"" + "));";
                        break;
                    case 7:
                        request = "SELECT Autors.NameAutor, Autors.CountryAutor FROM Autors WHERE(((Autors.CountryAutor)Like " + "\"" + firstParam.Text + "\"" + "));";
                        break;
                    case 8:
                        request = "SELECT Autors.NameAutor, Zhanry.NameZhanry FROM Zhanry INNER JOIN (Autors INNER JOIN Spektakli ON Autors.ID_Autors = Spektakli.ID_Autors) ON Zhanry.ID_Zhanry = Spektakli.ID_Zhanry WHERE(((Zhanry.NameZhanry)Like " + "\"" + firstParam.Text + "\"" + "));";
                        break;
                    case 9:
                        request = "SELECT Rabotniki.F_Rabotniki, Rabotniki.I_Rabotniki, Rabotniki.O_Rabotniki, Roles.NameRole FROM Roles INNER JOIN (Rabotniki INNER JOIN SetRoles ON Rabotniki.ID_Rabotniki = SetRoles.ID_Rabotniki) ON Roles.ID_Roles = SetRoles.ID_Roles WHERE(((Roles.NameRole)Like " + "\"" + firstParam.Text + "\"" + "));";
                        break;
                    case 10:
                        request = "SELECT Rabotniki.F_Rabotniki, Rabotniki.I_Rabotniki, Rabotniki.O_Rabotniki, Zvanie.NameZvanie, GiveZvanie.DateGiveZvanie, GiveZvanie.Konkurs FROM Zvanie INNER JOIN (Rabotniki INNER JOIN GiveZvanie ON Rabotniki.ID_Rabotniki = GiveZvanie.ID_Rabotniki) ON Zvanie.ID_Zvanie = GiveZvanie.ID_Zvanie WHERE(((GiveZvanie.DateGiveZvanie)Between " + "\"" + dateStart.Value.ToString("yyyy-MM-dd HH:mm:ss") + "\"" + " And " + "\"" + dateEnd.Value.ToString("yyyy-MM-dd HH:mm:ss") + "\"" + ") AND((GiveZvanie.Konkurs)Like " + "\"" + firstParam.Text + "\"" + ")); ";
                        break;
                    case 11:
                        request = "SELECT Rabotniki.F_Rabotniki, Rabotniki.I_Rabotniki, Rabotniki.O_Rabotniki, Rabotniki.BDate, Zvanie.NameZvanie FROM Zvanie INNER JOIN (Rabotniki INNER JOIN GiveZvanie ON Rabotniki.ID_Rabotniki = GiveZvanie.ID_Rabotniki) ON Zvanie.ID_Zvanie = GiveZvanie.ID_Zvanie WHERE(((Rabotniki.BDate)Between " + "\"" + dateStart.Value.ToString("yyyy-MM-dd HH:mm:ss") + "\"" + " And " + "\"" + dateEnd.Value.ToString("yyyy-MM-dd HH:mm:ss") + "\"" + ")); ";
                        break;
                    case 12:
                        request = "SELECT Rabotniki.F_Rabotniki, Rabotniki.I_Rabotniki, Rabotniki.O_Rabotniki, Rabotniki.Pol, Zvanie.NameZvanie FROM Zvanie INNER JOIN (Rabotniki INNER JOIN GiveZvanie ON Rabotniki.ID_Rabotniki = GiveZvanie.ID_Rabotniki) ON Zvanie.ID_Zvanie = GiveZvanie.ID_Zvanie WHERE(((Rabotniki.Pol)Like " + "\"" + firstParam.Text + "\"" + ")); ";
                        break;
                    case 13:
                        request = "SELECT Spektakli.NameSpektakli, Rabotniki.F_Rabotniki, Rabotniki.I_Rabotniki, Rabotniki.O_Rabotniki, Dolzhnosti.NameDolzhnosti FROM(Rabotniki INNER JOIN((Groups INNER JOIN Naznachenie ON Groups.ID_Groups = Naznachenie.ID_Groups) INNER JOIN Spektakli ON Groups.ID_Groups = Spektakli.ID_Groups) ON Rabotniki.ID_Rabotniki = Naznachenie.ID_Rabotniki) INNER JOIN (Dolzhnosti INNER JOIN Priem ON Dolzhnosti.ID_Dolzhnosti = Priem.ID_Dolzhnosti) ON Rabotniki.ID_Rabotniki = Priem.ID_Rabotniki WHERE(((Spektakli.NameSpektakli)Like " + "\"" + firstParam.Text + "\"" + ")); ";
                        break;
                    case 14:
                        request = "SELECT Rabotniki.F_Rabotniki, Rabotniki.I_Rabotniki, Rabotniki.O_Rabotniki, Rabotniki.BDate FROM Rabotniki WHERE(((Rabotniki.BDate)Between " + "\"" + dateStart.Value.ToString("yyyy-MM-dd HH:mm:ss") + "\"" + " And " + "\"" + dateEnd.Value.ToString("yyyy-MM-dd HH:mm:ss") + "\"" + ")); ";
                        break;
                    case 15:
                        request = "SELECT Rabotniki.F_Rabotniki, Rabotniki.I_Rabotniki, Rabotniki.O_Rabotniki, Dolzhnosti.ZP FROM Rabotniki INNER JOIN (Dolzhnosti INNER JOIN Priem ON Dolzhnosti.ID_Dolzhnosti = Priem.ID_Dolzhnosti) ON Rabotniki.ID_Rabotniki = Priem.ID_Rabotniki WHERE(((Dolzhnosti.ZP)Between " + "\"" + firstParam.Text + "\"" + " And " + "\"" + secondParam.Text + "\"" + ")); ";
                        break;
                    case 16:
                        request = "SELECT Rabotniki.F_Rabotniki, Rabotniki.I_Rabotniki, Rabotniki.O_Rabotniki, Rabotniki.Pol FROM Rabotniki WHERE(((Rabotniki.Pol)Like " + "\"" + firstParam.Text + "\"" + ")); ";
                        break;
                    case 17:
                        request = "SELECT Rabotniki.F_Rabotniki, Rabotniki.I_Rabotniki, Rabotniki.O_Rabotniki, Roles.NameRole, SetRoles.SetDate FROM Roles INNER JOIN (Rabotniki INNER JOIN SetRoles ON Rabotniki.ID_Rabotniki = SetRoles.ID_Rabotniki) ON Roles.ID_Roles = SetRoles.ID_Roles WHERE(((SetRoles.SetDate)Between " + "\"" + dateStart.Value.ToString("yyyy-MM-dd HH:mm:ss") + "\"" + " And " + "\"" + dateEnd.Value.ToString("yyyy-MM-dd HH:mm:ss") + "\"" + ")); ";
                        break;
                    case 18:
                        request = "SELECT Rabotniki.F_Rabotniki, Rabotniki.I_Rabotniki, Rabotniki.O_Rabotniki, Roles.NameRole, Autors.NameAutor FROM Roles INNER JOIN ((Rabotniki INNER JOIN((Groups INNER JOIN Naznachenie ON Groups.ID_Groups = Naznachenie.ID_Groups) INNER JOIN(Autors INNER JOIN Spektakli ON Autors.ID_Autors = Spektakli.ID_Autors) ON Groups.ID_Groups = Spektakli.ID_Groups) ON Rabotniki.ID_Rabotniki = Naznachenie.ID_Rabotniki) INNER JOIN SetRoles ON Rabotniki.ID_Rabotniki = SetRoles.ID_Rabotniki) ON Roles.ID_Roles = SetRoles.ID_Roles WHERE(((Autors.NameAutor)Like " + "\"" + firstParam.Text + "\"" + ")); ";
                        break;
                    case 19:
                        request = "SELECT Rabotniki.F_Rabotniki, Rabotniki.I_Rabotniki, Rabotniki.O_Rabotniki, Roles.NameRole, Zhanry.NameZhanry FROM Zhanry INNER JOIN (Roles INNER JOIN((Rabotniki INNER JOIN((Groups INNER JOIN Naznachenie ON Groups.ID_Groups = Naznachenie.ID_Groups) INNER JOIN Spektakli ON Groups.ID_Groups = Spektakli.ID_Groups) ON Rabotniki.ID_Rabotniki = Naznachenie.ID_Rabotniki) INNER JOIN SetRoles ON Rabotniki.ID_Rabotniki = SetRoles.ID_Rabotniki) ON Roles.ID_Roles = SetRoles.ID_Roles) ON Zhanry.ID_Zhanry = Spektakli.ID_Zhanry WHERE(((Zhanry.NameZhanry)Like " + "\"" + firstParam.Text + "\"" + ")); ";
                        break;
                    case 20:
                        request = "SELECT Spektakli.NameSpektakli, Zhanry.NameZhanry, Autors.NameAutor, Autors.VekAutor FROM Zhanry INNER JOIN (Autors INNER JOIN Spektakli ON Autors.ID_Autors = Spektakli.ID_Autors) ON Zhanry.ID_Zhanry = Spektakli.ID_Zhanry WHERE(((Autors.VekAutor)Like " + "\"" + firstParam.Text + "\"" + ")); ";
                        break;
                    case 21:
                        request = "SELECT Spektakli.NameSpektakli, Zhanry.NameZhanry FROM Zhanry INNER JOIN Spektakli ON Zhanry.ID_Zhanry = Spektakli.ID_Zhanry WHERE(((Zhanry.NameZhanry)Like " + "\"" + firstParam.Text + "\"" + ")); ";
                        break;
                    case 22:
                        request = "SELECT Spektakli.NameSpektakli, Zhanry.NameZhanry, Autors.NameAutor, Autors.CountryAutor FROM Zhanry INNER JOIN (Autors INNER JOIN Spektakli ON Autors.ID_Autors = Spektakli.ID_Autors) ON Zhanry.ID_Zhanry = Spektakli.ID_Zhanry WHERE(((Autors.CountryAutor)Like " + "\"" + firstParam.Text + "\"" + ")); ";
                        break;
                    case 23:
                        request = "SELECT Spektakli.NameSpektakli, Gastroli.SDate FROM Spektakli INNER JOIN Gastroli ON Spektakli.ID_Spektakli = Gastroli.ID_Spektakli WHERE(((Gastroli.SDate)Between " + "\"" + dateStart.Value.ToString("yyyy-MM-dd HH:mm:ss") + "\"" + " And " + "\"" + dateEnd.Value.ToString("yyyy-MM-dd HH:mm:ss") + "\"" + ")); ";
                        break;
                    case 24:
                        request = "SELECT Spektakli.NameSpektakli, Zhanry.NameZhanry, Autors.NameAutor FROM Zhanry INNER JOIN (Autors INNER JOIN Spektakli ON Autors.ID_Autors = Spektakli.ID_Autors) ON Zhanry.ID_Zhanry = Spektakli.ID_Zhanry WHERE(((Autors.NameAutor)Like " + "\"" + firstParam.Text + "\"" + ")); ";
                        break;
                }
                MySqlDataAdapter dba = new MySqlDataAdapter(request, dbc);
                DataTable dateTable = new DataTable();
                dba.Fill(dateTable);
                tableView.DataSource = dateTable;
                dbc.Close();
                switch (reqCombo.SelectedIndex)
                {
                    case 0:
                        tableView.Columns[0].HeaderText = "Спектакль";
                        tableView.Columns[1].HeaderText = "Автор";
                        break;
                    case 1:
                        tableView.Columns[0].HeaderText = "Спектакль";
                        tableView.Columns[1].HeaderText = "Дата постановки";
                        break;
                    case 2:
                        tableView.Columns[0].HeaderText = "Спектакль";
                        break;
                    case 3:
                        tableView.Columns[0].HeaderText = "Спектакль";
                        tableView.Columns[2].HeaderText = "Дата покупки";
                        break;
                    case 4:
                        tableView.Columns[0].HeaderText = "Спектакль";
                        break;
                    case 5:
                        tableView.Columns[0].HeaderText = "Спектакль";
                        tableView.Columns[2].HeaderText = "Дата покупки";
                        break;
                    case 6:
                        tableView.Columns[0].HeaderText = "Автор";
                        tableView.Columns[1].HeaderText = "Век";
                        break;
                    case 7:
                        tableView.Columns[0].HeaderText = "Автор";
                        tableView.Columns[1].HeaderText = "Страна";
                        break;
                    case 8:
                        tableView.Columns[0].HeaderText = "Автор";
                        tableView.Columns[1].HeaderText = "Жанр";
                        break;
                    case 9:
                        tableView.Columns[0].HeaderText = "Фамилия";
                        tableView.Columns[1].HeaderText = "Имя";
                        tableView.Columns[2].HeaderText = "Отчество";
                        tableView.Columns[3].HeaderText = "Роль";
                        break;
                    case 10:
                        tableView.Columns[0].HeaderText = "Фамилия";
                        tableView.Columns[1].HeaderText = "Имя";
                        tableView.Columns[2].HeaderText = "Отчество";
                        tableView.Columns[3].HeaderText = "Звание";
                        tableView.Columns[4].HeaderText = "Дата выдачи";
                        tableView.Columns[5].HeaderText = "Конкурс";
                        break;
                    case 11:
                        tableView.Columns[0].HeaderText = "Фамилия";
                        tableView.Columns[1].HeaderText = "Имя";
                        tableView.Columns[2].HeaderText = "Отчество";
                        tableView.Columns[3].HeaderText = "Звание";
                        tableView.Columns[4].HeaderText = "Дата рождения";
                        break;
                    case 12:
                        tableView.Columns[0].HeaderText = "Фамилия";
                        tableView.Columns[1].HeaderText = "Имя";
                        tableView.Columns[2].HeaderText = "Отчество";
                        tableView.Columns[3].HeaderText = "Звание";
                        tableView.Columns[4].HeaderText = "Пол";
                        break;
                    case 13:
                        tableView.Columns[0].HeaderText = "Фамилия";
                        tableView.Columns[1].HeaderText = "Имя";
                        tableView.Columns[2].HeaderText = "Отчество";
                        tableView.Columns[3].HeaderText = "Спектакль";
                        tableView.Columns[4].HeaderText = "Должность";
                        break;
                    case 14:
                        tableView.Columns[0].HeaderText = "Фамилия";
                        tableView.Columns[1].HeaderText = "Имя";
                        tableView.Columns[2].HeaderText = "Отчество";
                        tableView.Columns[3].HeaderText = "Дата рождения";
                        break;
                    case 15:
                        tableView.Columns[0].HeaderText = "Фамилия";
                        tableView.Columns[1].HeaderText = "Имя";
                        tableView.Columns[2].HeaderText = "Отчество";
                        tableView.Columns[3].HeaderText = "Зарплата";
                        break;
                    case 16:
                        tableView.Columns[0].HeaderText = "Фамилия";
                        tableView.Columns[1].HeaderText = "Имя";
                        tableView.Columns[2].HeaderText = "Отчество";
                        tableView.Columns[3].HeaderText = "Пол";
                        break;
                    case 17:
                        tableView.Columns[0].HeaderText = "Фамилия";
                        tableView.Columns[1].HeaderText = "Имя";
                        tableView.Columns[2].HeaderText = "Отчество";
                        tableView.Columns[3].HeaderText = "Роль";
                        tableView.Columns[4].HeaderText = "Дата выдачи";
                        break;
                    case 18:
                        tableView.Columns[0].HeaderText = "Фамилия";
                        tableView.Columns[1].HeaderText = "Имя";
                        tableView.Columns[2].HeaderText = "Отчество";
                        tableView.Columns[3].HeaderText = "Роль";
                        tableView.Columns[4].HeaderText = "Автор";
                        break;
                    case 19:
                        tableView.Columns[0].HeaderText = "Фамилия";
                        tableView.Columns[1].HeaderText = "Имя";
                        tableView.Columns[2].HeaderText = "Отчество";
                        tableView.Columns[3].HeaderText = "Роль";
                        tableView.Columns[4].HeaderText = "Жанр";
                        break;
                    case 20:
                        tableView.Columns[0].HeaderText = "Спектакль";
                        tableView.Columns[1].HeaderText = "Жанр";
                        tableView.Columns[2].HeaderText = "Автор";
                        tableView.Columns[3].HeaderText = "Век";
                        break;
                    case 21:
                        tableView.Columns[0].HeaderText = "Спектакль";
                        tableView.Columns[1].HeaderText = "Жанр";
                        break;
                    case 22:
                        tableView.Columns[0].HeaderText = "Спектакль";
                        tableView.Columns[1].HeaderText = "Жанр";
                        tableView.Columns[2].HeaderText = "Автор";
                        tableView.Columns[3].HeaderText = "Страна";
                        break;
                    case 23:
                        tableView.Columns[0].HeaderText = "Спектакль";
                        tableView.Columns[1].HeaderText = "Дата постановки";
                        break;
                    case 24:
                        tableView.Columns[0].HeaderText = "Спектакль";
                        tableView.Columns[1].HeaderText = "Жанр";
                        tableView.Columns[2].HeaderText = "Автор";
                        break;
                }
            }
            catch
            { MessageBox.Show("Ошибка подключения к серверу. Попробуйте позже.", "TheatreClient", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
