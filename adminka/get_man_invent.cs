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
using System.Text.RegularExpressions;

namespace adminka
{
    public partial class get_man_invent : Form
    {
        SqlConnection bd;
        int man_id; // id человека
        int get_kov;// проверка количество вернутого инвентаря на ошибки 
        int id_rent_new; // id нового rent}
        public get_man_invent(SqlConnection bd, int man_id)
        {
            InitializeComponent();
            this.bd = bd;
            this.man_id = man_id;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void get_man_invent_Load(object sender, EventArgs e) // Загрузка
        {
            int id_check = -1;// нужно для выяснения какая по счету добавляется строка в таблицу
            await bd.OpenAsync();
            //---
            SqlDataReader resurt = null;
            SqlCommand Select = new SqlCommand("SELECT * FROM rent LEFT JOIN inventory ON inventory.Id = rent.id_inventory WHERE id_klient = @Id ORDER BY rent.check_dolg DESC", bd);
            Select.Parameters.AddWithValue("Id", man_id);
            resurt = await Select.ExecuteReaderAsync();
                while (await resurt.ReadAsync())
                {
                    if(Convert.ToInt32(resurt[0]) > id_rent_new)
                    {
                        id_rent_new = Convert.ToInt32(resurt[0]);// переменая указываешься какой Id максимальный rent
                    }
                    id_check++;
                    DateTime a = Convert.ToDateTime(resurt["data"]);
                    table.Rows.Add(resurt[0], resurt["id_inventory"], resurt["name"], resurt["kolbo_taken"], resurt["kolbo_give_away"], a.ToString("dd.MM.yyyy"));
                    if(Convert.ToInt32(resurt["check_dolg"]) == 0)
                    {
                        table.Rows[id_check].ReadOnly = true;
                    }
                }

            resurt.Close();
            /*ТУТ ИНВЕНТарь*/
            SqlDataReader resurt_invent = null;
            SqlCommand Select_invent = new SqlCommand("SELECT * FROM inventory", bd);
            resurt_invent = await Select_invent.ExecuteReaderAsync();
            while (await resurt_invent.ReadAsync())
               {
                    name_invent.Items.Add(resurt_invent["name"]);
               }
                resurt_invent.Close();
            }
 
            /*ТУТ ИНВЕНТарь*/
 

        private void button2_Click(object sender, EventArgs e) // кнопка изменить
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                int kolvo = Convert.ToInt32(table[4, i].Value);
                SqlCommand update_rent = new SqlCommand("UPDATE rent SET kolbo_give_away = @kol WHERE Id = @ID ",bd);
                update_rent.Parameters.AddWithValue("kol", kolvo);
                update_rent.Parameters.AddWithValue("ID", table[0, i].Value);
                update_rent.ExecuteNonQuery();
                if (table[3, i].Value == table[4, i].Value)
                {
                    SqlCommand update_rent_check = new SqlCommand("UPDATE rent SET check_dolg = @check_dolg WHERE Id = @ID ", bd);
                    update_rent_check.Parameters.AddWithValue("check_dolg", 0);
                    update_rent_check.Parameters.AddWithValue("ID", table[0, i].Value);
                    update_rent_check.ExecuteNonQuery();
                }      
            }
            this.Hide();
            bd.Close();
            get_man get_mans = new get_man(man_id,bd);
            get_mans.Show();
        }
        //-------------------------------------------------------
        private async void button1_Click(object sender, EventArgs e) // создание новой записи взятие инвентаря
        {
            int id = 0;
 
                if (kol.Value != 0 && !string.IsNullOrEmpty(name_invent.Text) && !string.IsNullOrWhiteSpace(name_invent.Text))
                {
                    if (name_invent.Items.Contains(name_invent.Text))
                    {
                        id = name_invent.Items.IndexOf(name_invent.Text) +1 ;
                    }
                    else
                    {
                        SqlCommand SET_invent = new SqlCommand("INSERT INTO [inventory] (name) VALUES (@name)", bd);
                        SET_invent.Parameters.AddWithValue("name", name_invent.Text);
                        await SET_invent.ExecuteNonQueryAsync();
                        id = name_invent.Items.Count +1;
                        name_invent.Items.Add(name_invent.Text);
                    }
                    id_rent_new++;
                    // Создание записи
                    DateTime date1 = DateTime.Today;
                    SqlCommand inset_invent = new SqlCommand("INSERT INTO [rent] (id_klient,id_inventory,kolbo_taken,kolbo_give_away,check_dolg,data) VALUES (@id_klient,@id_inventory,@kolbo_taken,0,@check_dolg,@data)", bd);
                    inset_invent.Parameters.AddWithValue("id_klient", man_id);
                    inset_invent.Parameters.AddWithValue("id_inventory", id);
                    inset_invent.Parameters.AddWithValue("kolbo_taken", kol.Value);
                    inset_invent.Parameters.AddWithValue("data", date1);
                    inset_invent.Parameters.AddWithValue("check_dolg", 1);
                    await inset_invent.ExecuteNonQueryAsync();
                    table.Rows.Add(id_rent_new, id, name_invent.Text, kol.Value,0, date1.ToString("dd.MM.yyyy"));
                    name_invent.Text = "";
                    kol.Value = 0;
             }
                else
                {
                    MessageBox.Show("Вы не указали данные");
                }  
        }
        // --------------- ТАБЛИЦА 
        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e) // 
        {
            if(e.ColumnIndex == 6) // кнопка приравнить
            {
                table[4, e.RowIndex].Value = table[3, e.RowIndex].Value;
            }
        }


        private void table_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 4) // начало редактирования
            {
                get_kov = Convert.ToInt32(table[4, e.RowIndex].Value);
            }
        }

        private void table_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4) // конец редактирования
            {
                if(table[4, e.RowIndex].Value == null)
                {
                    table[4, e.RowIndex].Value = 0;
                }
                Regex regex = new Regex(@"(\D)");
                if (regex.IsMatch(table[4, e.RowIndex].Value.ToString()))
                {
                    MessageBox.Show("Нужно ввести число");
                    table[4, e.RowIndex].Value = get_kov;
                }
                else
                {
                    if (Convert.ToInt32(table[4, e.RowIndex].Value) > Convert.ToInt32(table[3, e.RowIndex].Value))
                    {
                        MessageBox.Show("Нельзя указать значение вернул больше чем взял");
                        table[4, e.RowIndex].Value = get_kov;
                    }
                }
            }
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e) // кнопка назад
        {
            this.Hide();
            bd.Close();
            get_man get_mans = new get_man(man_id, bd);
            get_mans.Show();
        }

        private void get_man_invent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
