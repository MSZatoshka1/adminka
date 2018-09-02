using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using System.Collections;
using Assoc = System.Collections.Generic.Dictionary<string, string>;

namespace adminka
{
    public partial class get_man : Form 
    {
        string val;
        SqlConnection bd;
        int id_man;
        Assoc assocArray = new Assoc();
        set_man set_man = new set_man();
        public get_man(int id, SqlConnection bd) 
        {
            InitializeComponent();
            this.id_man = id;
            this.bd = bd;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
             
        }

        public string name_get(string from, int id) // узнавание имя по внешнему ключу
        {
            object table = null;
            string ret = "";
            SqlCommand SEL = new SqlCommand("SELECT name FROM " + from + " WHERE Id = @Id", bd);
            SEL.Parameters.AddWithValue("@Id", id);
            table = SEL.ExecuteScalar();
            ret = Convert.ToString(table);
            return ret;
            }

        private void get_man_Load(object sender, EventArgs e) // Загрузка
        {
            Dictionary<string, string> assocArray = new Dictionary<string, string>();
            int id_org = 0;
            int id_spesial = 0;
            bd.Open();
            SqlDataReader man = null;
            try
            {
                SqlCommand Selest_Man = new SqlCommand("SELECT * FROM Man WHERE Id = @Id", bd);
                Selest_Man.Parameters.AddWithValue("Id", id_man);
                man = Selest_Man.ExecuteReader();
                while (man.Read())
                {
                    subname.Text = Convert.ToString(man["subname"]);
                    name.Text = Convert.ToString(man["name"]);
                    patronymic.Text = Convert.ToString(man["patronymic"]);
                    passport.Text = Convert.ToString(man["passport"]);
                    issued_by.Text = Convert.ToString(man["issued_by"]);
                    when_issued.Text =  man["when_issued"].ToString();
                    report_card_number.Text = Convert.ToString(man["report_card_number"]);
                    year_of_birth.Text = man["year_of_birth"].ToString();
                    phone_number.Text = Convert.ToString(man["phone_number"]);
                    id_org = Convert.ToInt32(man["id_organization"]);
                    id_spesial = Convert.ToInt32(man["id_specialty"]);
                    break;
                }
            }
            finally
            {
                if (man != null)
                {
                    man.Close();
                }
            }
             organization.Text = name_get(" organization ", id_org);
             specialty.Text = name_get(" specialty ", id_spesial);
        }

       
        private async void button1_Click(object sender, EventArgs e) // изменить запись клиента
        {
            if (!string.IsNullOrEmpty(organization.Text) && !string.IsNullOrWhiteSpace(organization.Text)
                && (!string.IsNullOrEmpty(organization.Text)))
            {
                foreach (KeyValuePair<string, string> keyValue in assocArray)
                {
                    if (keyValue.Key == "specialty" || keyValue.Key == "organization")
                    {
                        int Id_check;
                        if (keyValue.Key == "specialty")
                        {
                            string a = keyValue.Key.ToString();
                            string b = keyValue.Value.ToString();
                            Id_check = set_man.check_id(a, b, bd);
                        }
                        else
                        {
                            Id_check = set_man.check_id(keyValue.Key, keyValue.Value, bd);
                        }
                        var sqlString = string.Format("UPDATE Man SET id_{0} = @val WHERE Id=@ID", keyValue.Key);
                        SqlCommand update_w = new SqlCommand(sqlString, bd);
                        update_w.Parameters.AddWithValue("ID", id_man);
                        update_w.Parameters.AddWithValue("val", Id_check);
                        await update_w.ExecuteNonQueryAsync();
                    }
                    else
                    {
                        var sqlString = string.Format("UPDATE Man SET {0} = @val WHERE Id=@ID", keyValue.Key);
                        SqlCommand update = new SqlCommand(sqlString, bd);
                        update.Parameters.AddWithValue("ID", id_man);
                        update.Parameters.AddWithValue("val", keyValue.Value);
                        await update.ExecuteNonQueryAsync();
                    }
                }
                bd.Close();
                this.Hide();
                get_mans get_mans = new get_mans();
                get_mans.Show();
            }else
            {
                MessageBox.Show("Организация и специальность и даты не могут быть пустыми");
            }
        }


        private async void problit_Click(object sender, EventArgs e) // прописать клиента
        {
            if(kom.Value != 0) {
                DateTime date1 = DateTime.Today;
                DateTime date2 = DateTime.Today.AddMonths(1);
                SqlCommand Inset = new SqlCommand("INSERT INTO [time_klient] (id_klient, date_of_arrival ,date_of_withdrawal,komnata) VALUES (@id_klient,@date_of_arrival,@date_of_withdrawal,@komnata)", bd);
                Inset.Parameters.AddWithValue("id_klient", id_man);
                Inset.Parameters.AddWithValue("date_of_arrival", date1);
                Inset.Parameters.AddWithValue("date_of_withdrawal", date2);
                Inset.Parameters.AddWithValue("komnata", kom.Text);
                await Inset.ExecuteNonQueryAsync();
                get_mans get_mans = new get_mans();
                bd.Close();
                get_mans.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("Вы не указали комнату");
            }
        }
        private void button6_Click(object sender, EventArgs e) // показать историю инвентаря
        {
            bd.Close();
            this.Hide();
            get_man_invent get_man_invent = new get_man_invent(bd, id_man);
            get_man_invent.Show();
        }

        private void button3_Click(object sender, EventArgs e) // нажата назад
        {
            bd.Close();
            this.Hide();
            get_mans get_mans = new get_mans();
            get_mans.Show();
        }

        public void passport_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^(\d){2}_(\d){2}_(\d){6}$");
            Regex regex2 = new Regex(@"^((\s){2}_){2}$");
            if (!regex.IsMatch(passport.Text) && !regex2.IsMatch(passport.Text))
            {
                MessageBox.Show("Некорректно введены данные");
                passport.Text = "";
            }
        }

        public void phone_number_Leave(object sender, EventArgs e)// проверка что номер тлф указан коректно или не указан 
        {
            Regex regex = new Regex(@"^\+7(\d){3}_(\d){3}_(\d){2}_(\d){2}$");
            Regex regex2 = new Regex(@"^\+7(\s){3}_(\s){3}_(\s){2}_$");
            if (!regex.IsMatch(phone_number.Text) && !regex2.IsMatch(phone_number.Text))
            {
                MessageBox.Show("Некорректно введены данные");
                phone_number.Text = "";
            }
        }
        public void report_card_number_Leave(object sender, EventArgs e) // Проверка что в номере табеля только цифры
        {
            Regex regex = new Regex(@"(\D)");
            if (regex.IsMatch(report_card_number.Text))
            {
                MessageBox.Show("в строке Не должны быть буквы");
                report_card_number.Text = "";
            }
        }
        public void focus_off(object sender, EventArgs e)
        {
            int check = 0;
            if (((Control)sender).Text != val)
            {
                if (assocArray.Count != 0) // Массив существует
                {
                    foreach (KeyValuePair<string, string> keyValue in assocArray)
                    {
                            if (keyValue.Key == ((Control)sender).Name)// Уже изменялось
                            {
                                assocArray[keyValue.Key] = ((Control)sender).Text;
                                check = 0;
                                break;
                            }
                            else // не изменялось не ДАТА
                            {
                                check = 1;
                            }
                    } // конец массива
                    if (check == 1)// требуется создать не дата
                    {
                        assocArray.Add(((Control)sender).Name, ((Control)sender).Text);
                    }
                }
                else
                { // Массив не существует 
                        assocArray.Add(((Control)sender).Name, ((Control)sender).Text);
                }
            }
        }      
        public void focus_on(object sender, EventArgs e)
        {
                val = ((Control)sender).Text;
        }
        private void get_man_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void date_check(object sender, EventArgs e)
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
                if (Convert.ToInt32(mes) > 12)
                {
                    error += "В году не может быть больше 12месяцев\n";
                }
                DateTime date = DateTime.Today;
                if (Convert.ToInt32(god) < 1950 || Convert.ToInt32(god) > date.Year)
                {
                    error += "Год может быть с 1950 по настоящее время";
                }
                if (error != "")
                {
                    ((Control)sender).Text = "";
                    MessageBox.Show(error);
                }

            }
            else
            {
                MessageBox.Show("Вы не указали полную дату");
                ((Control)sender).Text = "";
                assocArray.Remove(((Control)sender).Name);
            }
        }
    }
}
