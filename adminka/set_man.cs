using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace adminka
{
    public partial class set_man : Form
    {
        SqlConnection bd;// подключение к БД
        int id_new_man;
        int kolvo_invent;
        int id_new_invent;

        public set_man(SqlConnection bd, int id_new_man)
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.bd = bd;
            this.id_new_man = id_new_man;
        }
        public set_man()
        {
            InitializeComponent();
        }


        public int check_id(string from, string name, SqlConnection bd) // проверка что такое существует  создание +
        {
            int id = 0; // id -которое сохраниться в БД
            object check;
            SqlDataReader check_table = null;
            var sqlString = string.Format("SELECT * FROM {0} WHERE name LIKE @name ", from);
            SqlCommand Select = new SqlCommand(sqlString, bd);
            Select.Parameters.AddWithValue("@name", name);
            check_table = Select.ExecuteReader();
            if (check_table.HasRows) // Запись найдена
            {
                check_table.Close();
                check = Select.ExecuteScalar();
                id = Convert.ToInt32(check);
            }
            else
            { // Запись не найдена
                check_table.Close();
                var sqlString1 = string.Format("INSERT INTO {0} (name) VALUES (@name) ", from);
                SqlCommand Inset = new SqlCommand(sqlString1, bd);
                Inset.Parameters.AddWithValue("@name", name);
                Inset.ExecuteNonQuery();
                //-------------------
                var sqlString2 = string.Format("SELECT TOP 1 Id FROM {0} ORDER BY Id DESC", from);
                SqlCommand Select_1 = new SqlCommand(sqlString2, bd);
                check = Select_1.ExecuteScalar();
                id = Convert.ToInt32(check);
            }

            return id;
        }
        public void Set_Man(int id_org, int id_spesial) // Сохранить данные человека
        {
            SqlCommand inset_man = new SqlCommand("INSERT INTO [Man] (subname,name,patronymic,id_organization,id_specialty,passport,issued_by,phone_number) VALUES (@subname, @name, @patronymic, @id_organization, @id_specialty, @passport, @issued_by, @phone_number)", bd);
            inset_man.Parameters.AddWithValue("subname", sumname.Text); // фамилия
            inset_man.Parameters.AddWithValue("name", name.Text);// имя
            inset_man.Parameters.AddWithValue("patronymic", patronymic.Text); // отчество
            inset_man.Parameters.AddWithValue("passport", pasport.Text); // серия паспорта
            inset_man.Parameters.AddWithValue("issued_by", issued_by.Text); // кем выдан 
            inset_man.Parameters.AddWithValue("phone_number", phone_number.Text);// номер телефона
            inset_man.Parameters.AddWithValue("report_card_number", report_card_number.Text); // номер табеля
            inset_man.Parameters.AddWithValue("id_organization", id_org); // Организация
            inset_man.Parameters.AddWithValue("id_specialty", id_spesial); // Специальность  
            inset_man.ExecuteNonQuery();
            //--Костыли ЛЕнь было через функцию
            if (year_of_birth.Text.Length > 6)
            {
                // inset_man.Parameters.AddWithValue("year_of_birth");// Год рождение
                SqlCommand update = new SqlCommand("UPDATE Man SET year_of_birth = @year_of_birth WHERE Id = @id", bd);
                update.Parameters.AddWithValue("@year_of_birth",Convert.ToDateTime(year_of_birth.Text));
                update.Parameters.AddWithValue("@id", id_new_man);
                update.ExecuteNonQuery();
            }
            if (When_issued.Text.Length > 6)
            {
                SqlCommand update = new SqlCommand("UPDATE Man  SET When_issued = @When_issued WHERE Id = @id", bd);
                update.Parameters.AddWithValue("@When_issued", Convert.ToDateTime(When_issued.Text));
                update.Parameters.AddWithValue("@id", id_new_man);
                update.ExecuteNonQuery();
            }
            if(report_card_number.Text.Length != 0)
            {
                SqlCommand update = new SqlCommand("UPDATE Man  SET report_card_number = @report_card_number WHERE Id = @id", bd);
                update.Parameters.AddWithValue("@report_card_number", report_card_number.Text);
                update.Parameters.AddWithValue("@id", id_new_man);
                update.ExecuteNonQuery();
            } 
            //--Костыли ЛЕнь было через функцию
        }
        public void Set_Time() // Сохранить статистику
        {
            DateTime date = DateTime.Today; // дата прихода
            DateTime date2 = DateTime.Today.AddMonths(1);// дата ухода
            SqlCommand inset_time_klient = new SqlCommand("INSERT INTO [time_klient] (id_klient, date_of_arrival ,date_of_withdrawal ,komnata) VALUES (@id_klient,@date_of_arrival,@date_of_withdrawal,@komnata)", bd);
            inset_time_klient.Parameters.AddWithValue("@id_klient", id_new_man); // id-клиента
            inset_time_klient.Parameters.AddWithValue("date_of_arrival", date);// дата заезда
            inset_time_klient.Parameters.AddWithValue("date_of_withdrawal", date2);// дата уезда
            inset_time_klient.Parameters.AddWithValue("komnata", komnata.Text); // комната
            inset_time_klient.ExecuteNonQuery();
        }

        private void set_Click(object sender, EventArgs e) // Нажата кнопка создать
        {
            bd.Open();
            //проверка что всё гуд создаем записи
            if ((!string.IsNullOrEmpty(komnata.Text) && !string.IsNullOrWhiteSpace(komnata.Text) && Convert.ToInt32(komnata.Value) != 0)
                && (!string.IsNullOrEmpty(organization.Text) && !string.IsNullOrWhiteSpace(organization.Text))
                && (!string.IsNullOrEmpty(organization.Text) && !string.IsNullOrWhiteSpace(specialty.Text)))
            {
                if (error.Visible) // проверка что не указана ошибка
                {
                    error.Visible = false;
                }
                // --------- определения Id
                int id_org = check_id(" organization ", organization.Text, bd);
                int id_spesial = check_id(" specialty ", specialty.Text, bd);
                Set_Man(id_org, id_spesial);
                Set_Time();
                DateTime date = DateTime.Today;

                // Создание записей какой инвентарь был взят   
                for (int i = 0; i < invent.Rows.Count; i++)
                {
                    object invent_row = invent[2, i].Value;
                    int invent_row_kolvo = Convert.ToInt32(invent_row);
                    if (invent_row_kolvo != 0)
                    {
                        SqlCommand inset_invent = new SqlCommand("INSERT INTO [rent] (id_klient,id_inventory,kolbo_taken,kolbo_give_away,check_dolg,data) VALUES (@id_klient,@id_inventory,@kolbo_taken,0,@check_dolg,@data)", bd);
                        inset_invent.Parameters.AddWithValue("id_klient", id_new_man);
                        inset_invent.Parameters.AddWithValue("id_inventory", Convert.ToInt32(invent[0, i].Value));
                        inset_invent.Parameters.AddWithValue("kolbo_taken", Convert.ToInt32(invent[2, i].Value));
                        inset_invent.Parameters.AddWithValue("data", date);
                        inset_invent.Parameters.AddWithValue("check_dolg", 1);
                        inset_invent.ExecuteNonQuery();
                    }
                }
                this.Hide();
                get_mans get_mans = new get_mans();
                get_mans.Show();
                bd.Close();
            }
            // Создание не удалось 
            else
            {
                error.Text = "Вы не указали";
                if (komnata.Value == 0)
                {
                    error.Text += " комнату";
                }
                if (string.IsNullOrEmpty(organization.Text) || string.IsNullOrWhiteSpace(organization.Text))
                {
                    error.Text += " организацию";
                }
                if (string.IsNullOrEmpty(specialty.Text) || string.IsNullOrWhiteSpace(specialty.Text))
                {
                    error.Text += " специальность";
                }
                error.Visible = true;
                bd.Close();
            }
        }

        private async void set_man_Load(object sender, EventArgs e) // при загрузки инвентарь
        {
            SqlDataReader result = null;
            // Вывод инвентаря 
                await bd.OpenAsync();
                SqlCommand select_invent = new SqlCommand("SELECT * FROM inventory ORDER BY Id DESC", bd);
                result = await select_invent.ExecuteReaderAsync();
                if (result.HasRows)
                {
                    while (await result.ReadAsync())
                    {
                        invent.Rows.Add(result["Id"], result["name"], 0);
                    }
                    if (result != null)
                    {
                        result.Close();
                    }
                    id_new_invent = Convert.ToInt32(invent[0, 0].Value) + 1;
            }else
            {
                id_new_invent = 1;
            }
            bd.Close();
        }

        private async void set_invent_bd_Click(object sender, EventArgs e)// создание нового инвентаря
        {
            await bd.OpenAsync();
            if (!string.IsNullOrEmpty(set_invent.Text) && !string.IsNullOrWhiteSpace(set_invent.Text))
            {
                SqlCommand inset_invent = new SqlCommand("INSERT INTO [inventory] (name) VALUES (@name)", bd);
                if (error_invent.Visible)
                {
                    error_invent.Visible = false;
                }
                inset_invent.Parameters.AddWithValue("name", set_invent.Text); // название
                await inset_invent.ExecuteNonQueryAsync();
                invent.Rows.Add(id_new_invent, set_invent.Text, 0);
                set_invent.Text = "";
                id_new_invent++;
            }
            else
            {
                error_invent.Visible = true;
                error_invent.Text = "Вы не указали название нового инвентаря";
            }
            bd.Close();
        }

        private void button3_Click(object sender, EventArgs e) // нажата кнопка отмена создания человека
        {
            //Thread.Sleep(2000);
            this.Hide();
            get_mans get_mans = new get_mans();
            get_mans.Show();
        }

        public void report_card_number_Leave(object sender, EventArgs e) // Проверка что в номере табеля только цифры
        {
            Regex regex = new Regex(@"(\D)");
            if (regex.IsMatch(report_card_number.Text))
            {
                MessageBox.Show("В строке не должны быть буквы");
                report_card_number.Text = "";
            }
        }


        private void invent_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) // Открылась поле  в таблице изменение
        {
            if (e.ColumnIndex == 2)
            {
                kolvo_invent = Convert.ToInt32(invent[2, e.RowIndex].Value);
            }
        }

        private void invent_CellEndEdit(object sender, DataGridViewCellEventArgs e)// закончилось изменение поля в таблице
        {
            if (e.ColumnIndex == 2)
            {
                if(invent[2, e.RowIndex].Value == null)
                {
                    invent[2, e.RowIndex].Value = 0;
                }
                Regex regex = new Regex(@"(\D)");
                if (regex.IsMatch(invent[2, e.RowIndex].Value.ToString())) // Найдена символ не цифра
                {
                    invent[2, e.RowIndex].Value = kolvo_invent.ToString();
                    MessageBox.Show("Должны быть только цифры");
                }
            }
        }

        private void set_man_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void pasport_Leave(object sender, EventArgs e) // Проверка паспорта
        {
            Regex regex = new Regex(@"^(\d){2}_(\d){2}_(\d){6}$");
            Regex regex2 = new Regex(@"^((\s){2}_){2}$");
            if (!regex.IsMatch(pasport.Text) && !regex2.IsMatch(pasport.Text))
            {
                MessageBox.Show("Некорректно введены данные");
                pasport.Text = "";
            }
        }

        public void phone_number_Leave(object sender, EventArgs e)// Проверка тлф
        {
            Regex regex = new Regex(@"^\+7(\d){3}_(\d){3}_(\d){2}_(\d){2}$");
            Regex regex2 = new Regex(@"^\+7(\s){3}_(\s){3}_(\s){2}_$");
            if (!regex.IsMatch(phone_number.Text) && !regex2.IsMatch(phone_number.Text))
            {
                MessageBox.Show("Некорректно введены данные");
                phone_number.Text = "";
            }
        }
        public void date_check(object sender, EventArgs e) // проверка даты
        {
            string error = "";
            string a = ((Control)sender).Text;
            if (a.Length == 10)
            {
                string day = a[0].ToString() + a[1].ToString();
                string mes = a[3].ToString() + a[4].ToString();
                string god = a[6].ToString() + a[7].ToString() + a[8].ToString() + a[9].ToString();
                if (Convert.ToInt32(day) > 31)
                {
                    error += "В месяце не может быть больше 31 дней\n";
                } 
                if(Convert.ToInt32(mes) > 12)
                {
                    error += "В году не может быть больше 12месяцев\n";
                }
                DateTime date = DateTime.Today;
                if (Convert.ToInt32(god) < 1950 || Convert.ToInt32(god) > date.Year)
                {
                    error += "Год может быть с 1950 по настоящее время";
                }
                if(error != "") {
                    ((Control)sender).Text = "";
                     MessageBox.Show(error);
                }

            }
            else
            {
                MessageBox.Show("Вы не указали полную дату");
                ((Control)sender).Text = "";
            }
        }
    }
}
