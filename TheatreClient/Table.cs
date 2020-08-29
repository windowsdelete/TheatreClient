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
using TheatreClient.InsertForms;

namespace TheatreClient
{
    public partial class Table : MetroFramework.Forms.MetroForm
    {
        public Table()
        {
            InitializeComponent();
            if (Properties.Settings.Default.guestMode == true)
                insertWindow.Visible = false;
            this.Text = "Работа с таблицой «‎" + Properties.Settings.Default.nameTable + "»";
            refresh();
        }

        string request, primkey;

        private void buttonsAction(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tableView[primkey, tableView.CurrentRow.Index].Value);
            switch(Properties.Settings.Default.nameTable)
            {
                case "Прием":
                    InsertPriem inspriem = new InsertPriem(-1);
                    inspriem.ShowDialog();
                    break;
                case "Работники":
                    InsertRabotniki insrab = new InsertRabotniki(-1);
                    insrab.ShowDialog();
                    break;
                case "Должности":
                    InsertDolzhnosti insdolzn = new InsertDolzhnosti(-1);
                    insdolzn.ShowDialog();
                    break;
                case "Назначение":
                    InsertNaznachenie insnazn = new InsertNaznachenie(-1);
                    insnazn.ShowDialog();
                    break;
                case "Звания":
                    InsertZvanie inszvan = new InsertZvanie(-1);
                    inszvan.ShowDialog();
                    break;
                case "Выдача званий":
                    InsertGiveZvanie insgzvan = new InsertGiveZvanie(-1);
                    insgzvan.ShowDialog();
                    break;
                case "Группы":
                    InsertGroups insgrp = new InsertGroups(-1);
                    insgrp.ShowDialog();
                    break;
                case "Спектакли":
                    InsertSpektakli inspsek = new InsertSpektakli(-1);
                    inspsek.ShowDialog();
                    break;
                case "Роли":
                    InsertRoles insrol = new InsertRoles(-1);
                    insrol.ShowDialog();
                    break;
                case "Назначение на роль":
                    InsertSetRoles inssetr = new InsertSetRoles(-1);
                    inssetr.ShowDialog();
                    break;
                case "Жанры":
                    InsertZhanry inszhan = new InsertZhanry(-1);
                    inszhan.ShowDialog();
                    break;
                case "Гастроли":
                    InsertGastroli insgast = new InsertGastroli(-1);
                    insgast.ShowDialog();
                    break;
                case "Авторы":
                    InsertAutors insaut = new InsertAutors(-1);
                    insaut.ShowDialog();
                    break;
                case "Аудитории":
                    InsertAuditory insaudit = new InsertAuditory(-1);
                    insaudit.ShowDialog();
                    break;
                case "Билеты":
                    InsertTickets instick = new InsertTickets(-1);
                    instick.ShowDialog();
                    break;
                case "Абонименты":
                    InsertAbonimenty insabo = new InsertAbonimenty(-1);
                    insabo.ShowDialog();
                    break;
                case "Учётные записи":
                    InsertAuth insauth = new InsertAuth(-1);
                    insauth.ShowDialog();
                    break;
            }
            refresh();
        }

        private void selectToUpdate(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
                try
                {
                    if (Properties.Settings.Default.guestMode == false)
                    {
                        int id = Convert.ToInt32(tableView[primkey, tableView.CurrentRow.Index].Value);
                        switch (Properties.Settings.Default.nameTable)
                        {
                            case "Прием":
                                InsertPriem inspriem = new InsertPriem(id);
                                inspriem.ShowDialog();
                                break;
                            case "Работники":
                                InsertRabotniki insrab = new InsertRabotniki(id);
                                insrab.ShowDialog();
                                break;
                            case "Должности":
                                InsertDolzhnosti insdolzn = new InsertDolzhnosti(id);
                                insdolzn.ShowDialog();
                                break;
                            case "Назначение":
                                InsertNaznachenie insnazn = new InsertNaznachenie(id);
                                insnazn.ShowDialog();
                                break;
                            case "Звания":
                                InsertZvanie inszvan = new InsertZvanie(id);
                                inszvan.ShowDialog();
                                break;
                            case "Выдача званий":
                                InsertGiveZvanie insgzvan = new InsertGiveZvanie(id);
                                insgzvan.ShowDialog();
                                break;
                            case "Группы":
                                InsertGroups insgrp = new InsertGroups(id);
                                insgrp.ShowDialog();
                                break;
                            case "Спектакли":
                                InsertSpektakli inspsek = new InsertSpektakli(id);
                                inspsek.ShowDialog();
                                break;
                            case "Роли":
                                InsertRoles insrol = new InsertRoles(id);
                                insrol.ShowDialog();
                                break;
                            case "Назначение на роль":
                                InsertSetRoles inssetr = new InsertSetRoles(id);
                                inssetr.ShowDialog();
                                break;
                            case "Жанры":
                                InsertZhanry inszhan = new InsertZhanry(id);
                                inszhan.ShowDialog();
                                break;
                            case "Гастроли":
                                InsertGastroli insgast = new InsertGastroli(id);
                                insgast.ShowDialog();
                                break;
                            case "Авторы":
                                InsertAutors insaut = new InsertAutors(id);
                                insaut.ShowDialog();
                                break;
                            case "Аудитории":
                                InsertAuditory insaudit = new InsertAuditory(id);
                                insaudit.ShowDialog();
                                break;
                            case "Билеты":
                                InsertTickets instick = new InsertTickets(id);
                                instick.ShowDialog();
                                break;
                            case "Абонименты":
                                InsertAbonimenty insabo = new InsertAbonimenty(id);
                                insabo.ShowDialog();
                                break;
                            case "Учётные записи":
                                InsertAuth insauth = new InsertAuth(id);
                                insauth.ShowDialog();
                                break;
                        }
                        refresh();
                    }
                }
                catch
                {
                    insertWindow.PerformClick();
                }
        }

        void refresh()
        {
            try
            {
                MySqlConnection dbc = new MySqlConnection(Properties.Settings.Default.connectText);
                dbc.Open();
                switch (Properties.Settings.Default.nameTable)
                {
                    case "Прием":
                        primkey = "id_Priem";
                        request = "Select priem.id_Priem, rabotniki.F_Rabotniki, rabotniki.I_Rabotniki, rabotniki.O_Rabotniki, dolzhnosti.NameDolzhnosti, priem.PriemDate " +
                            "From priem, rabotniki, dolzhnosti " +
                            "Where priem.id_Rabotniki=rabotniki.id_Rabotniki and priem.id_Dolzhnosti=dolzhnosti.id_Dolzhnosti";
                        break;
                    case "Работники":
                        primkey = "id_Rabotniki";
                        request = "Select rabotniki.id_Rabotniki, rabotniki.F_Rabotniki, rabotniki.I_Rabotniki, rabotniki.O_Rabotniki, rabotniki.BDate, rabotniki.Pol, rabotniki.RostRabotnik " +
                            "From rabotniki ";
                        break;
                    case "Должности":
                        primkey = "id_Dolzhnosti";
                        request = "Select dolzhnosti.id_Dolzhnosti, dolzhnosti.NameDolzhnosti, dolzhnosti.ZP " +
                            "From dolzhnosti ";
                        break;
                    case "Назначение":
                        primkey = "id_Naznachenie";
                        request = "Select naznachenie.id_Naznachenie, rabotniki.F_Rabotniki, rabotniki.I_Rabotniki, rabotniki.O_Rabotniki, groups.NameGroups " +
                            "From naznachenie, rabotniki, groups " +
                            "Where naznachenie.id_Rabotniki=rabotniki.id_Rabotniki and naznachenie.id_Groups=groups.id_Groups";
                        break;
                    case "Звания":
                        primkey = "id_Zvanie";
                        request = "Select zvanie.id_Zvanie, zvanie.NameZvanie " +
                            "From zvanie ";
                        break;
                    case "Выдача званий":
                        primkey = "id_GiveZvanie";
                        request = "Select givezvanie.id_GiveZvanie, rabotniki.F_Rabotniki, rabotniki.I_Rabotniki, rabotniki.O_Rabotniki, zvanie.NameZvanie, givezvanie.DateGiveZvanie, givezvanie.Konkurs " +
                            "From givezvanie, rabotniki, zvanie " +
                            "Where givezvanie.id_Rabotniki=rabotniki.id_Rabotniki and givezvanie.id_Zvanie=zvanie.id_Zvanie";
                        break;
                    case "Группы":
                        primkey = "id_Groups";
                        request = "Select groups.id_Groups, groups.NameGroups " +
                            "From groups ";
                        break;
                    case "Спектакли":
                        primkey = "id_Spektakli";
                        request = "Select spektakli.id_Spektakli, spektakli.NameSpektakli, zhanry.NameZhanry, auditory.NameAuditory, groups.NameGroups, autors.NameAutor " +
                            "From spektakli, zhanry, auditory, groups, autors " +
                            "Where spektakli.id_Zhanry= zhanry.id_Zhanry and spektakli.id_Auditory= auditory.id_Auditory and spektakli.id_Groups=groups.id_Groups and spektakli.id_Autors=autors.id_Autors";
                        break;
                    case "Роли":
                        primkey = "id_Roles";
                        request = "Select roles.id_Roles, roles.NameRole, roles.RostRole " +
                            "From roles ";
                        break;
                    case "Назначение на роль":
                        primkey = "id_SetRoles";
                        request = "Select setroles.id_SetRoles, rabotniki.F_Rabotniki, rabotniki.I_Rabotniki, rabotniki.O_Rabotniki, roles.NameRole, setroles.SetDate " +
                            "From setroles, rabotniki, roles " +
                            "Where setroles.id_Rabotniki=rabotniki.id_Rabotniki and setroles.id_Roles=roles.id_Roles";
                        break;
                    case "Жанры":
                        primkey = "id_Zhanry";
                        request = "Select zhanry.id_Zhanry, zhanry.NameZhanry " +
                            "From zhanry ";
                        break;
                    case "Гастроли":
                        primkey = "id_Gastroli";
                        request = "Select gastroli.id_Gastroli, gastroli.City, gastroli.SDate, spektakli.NameSpektakli " +
                            "From gastroli, spektakli " +
                            "Where gastroli.id_Spektakli=spektakli.id_Spektakli";
                        break;
                    case "Авторы":
                        primkey = "id_Autors";
                        request = "Select autors.id_Autors, autors.NameAutor, autors.CountryAutor, autors.VekAutor " +
                            "From autors ";
                        break;
                    case "Аудитории":
                        primkey = "id_Auditory";
                        request = "Select auditory.id_Auditory, auditory.NameAuditory, auditory.Vmestimost " +
                            "From auditory ";
                        break;
                    case "Билеты":
                        primkey = "id_Tickets";
                        request = "Select tickets.id_Tickets, spektakli.NameSpektakli, tickets.TicketCost, tickets.BuyDate " +
                            "From tickets, spektakli " +
                            "Where tickets.id_Spektakli=spektakli.id_Spektakli";
                        break;
                    case "Абонименты":
                        primkey = "id_Abonimenty";
                        request = "Select abonimenty.id_Abonimenty, zhanry.NameZhanry, abonimenty.AbonimentCost, abonimenty.AbonimentBuyDate, abonimenty.AbonimentOutDate " +
                            "From abonimenty, zhanry " +
                            "Where abonimenty.id_Zhanry=zhanry.id_Zhanry";
                        break;
                    case "Учётные записи":
                        primkey = "id_Auth";
                        request = "Select auth.id_Auth, auth.Log, auth.Pass, auth.Role " +
                            "From auth ";
                        break;
                }
                MySqlDataAdapter dba = new MySqlDataAdapter(request, dbc);
                DataTable dateTable = new DataTable();
                dba.Fill(dateTable);
                tableView.DataSource = dateTable;
                tableView.Columns[primkey].Visible = false;
                dbc.Close();
                switch (Properties.Settings.Default.nameTable)
                {
                    case "Прием":
                        tableView.Columns[1].HeaderText = "Фамилия";
                        tableView.Columns[2].HeaderText = "Имя";
                        tableView.Columns[3].HeaderText = "Отчество";
                        tableView.Columns[4].HeaderText = "Должность";
                        tableView.Columns[5].HeaderText = "Дата приёма";
                        break;
                    case "Работники":
                        tableView.Columns[1].HeaderText = "Фамилия";
                        tableView.Columns[2].HeaderText = "Имя";
                        tableView.Columns[3].HeaderText = "Отчество";
                        tableView.Columns[4].HeaderText = "Дата рождения";
                        tableView.Columns[5].HeaderText = "Пол";
                        tableView.Columns[6].HeaderText = "Рост";
                        break;
                    case "Должности":
                        tableView.Columns[1].HeaderText = "Название";
                        tableView.Columns[2].HeaderText = "Зарплата";
                        break;
                    case "Назначение":
                        tableView.Columns[1].HeaderText = "Фамилия";
                        tableView.Columns[2].HeaderText = "Имя";
                        tableView.Columns[3].HeaderText = "Отчество";
                        tableView.Columns[4].HeaderText = "Группа";
                        break;
                    case "Звания":
                        tableView.Columns[1].HeaderText = "Название";
                        break;
                    case "Выдача званий":
                        tableView.Columns[1].HeaderText = "Фамилия";
                        tableView.Columns[2].HeaderText = "Имя";
                        tableView.Columns[3].HeaderText = "Отчество";
                        tableView.Columns[4].HeaderText = "Звание";
                        tableView.Columns[5].HeaderText = "Дата выдачи";
                        tableView.Columns[6].HeaderText = "Конкурс";
                        break;
                    case "Группы":
                        tableView.Columns[1].HeaderText = "Название";
                        break;
                    case "Спектакли":
                        tableView.Columns[1].HeaderText = "Название";
                        tableView.Columns[2].HeaderText = "Жанр";
                        tableView.Columns[3].HeaderText = "Аудитория";
                        tableView.Columns[4].HeaderText = "Группа";
                        tableView.Columns[5].HeaderText = "Автор";
                        break;
                    case "Роли":
                        tableView.Columns[1].HeaderText = "Название";
                        tableView.Columns[2].HeaderText = "Рост";
                        break;
                    case "Назначение на роль":
                        tableView.Columns[1].HeaderText = "Фамилия";
                        tableView.Columns[2].HeaderText = "Имя";
                        tableView.Columns[3].HeaderText = "Отчество";
                        tableView.Columns[4].HeaderText = "Роль";
                        tableView.Columns[5].HeaderText = "Дата назначения";
                        break;
                    case "Жанры":
                        tableView.Columns[1].HeaderText = "Название";
                        break;
                    case "Гастроли":
                        tableView.Columns[1].HeaderText = "Город";
                        tableView.Columns[2].HeaderText = "Дата";
                        tableView.Columns[3].HeaderText = "Спектакль";
                        break;
                    case "Авторы":
                        tableView.Columns[1].HeaderText = "Имя";
                        tableView.Columns[2].HeaderText = "Страна";
                        tableView.Columns[3].HeaderText = "Век";
                        break;
                    case "Аудитории":
                        tableView.Columns[1].HeaderText = "Название";
                        tableView.Columns[2].HeaderText = "Вместимость";
                        break;
                    case "Билеты":
                        tableView.Columns[1].HeaderText = "Спектакль";
                        tableView.Columns[2].HeaderText = "Цена";
                        tableView.Columns[3].HeaderText = "Дата покупки";
                        break;
                    case "Абонименты":
                        tableView.Columns[1].HeaderText = "Жанр";
                        tableView.Columns[2].HeaderText = "Цена";
                        tableView.Columns[3].HeaderText = "Дата покупки";
                        tableView.Columns[4].HeaderText = "Дата окончания";
                        break;
                    case "Учётные записи":
                        tableView.Columns[1].HeaderText = "Логин";
                        tableView.Columns[2].HeaderText = "Пароль";
                        tableView.Columns[3].HeaderText = "Роль";
                        break;
                }
            }
            catch
            { MessageBox.Show("Ошибка подключения к серверу. Попробуйте позже.", "TheatreClient", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
