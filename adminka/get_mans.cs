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


namespace adminka
{
    public partial class get_mans : Form
    {
        SqlConnection bd;
        SqlDataReader result;
        int id_new_man;
        public get_mans()
        {
            InitializeComponent();
            string data = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\Database1.mdf';Integrated Security=True";
            bd = new SqlConnection(data);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        public async void set_bd(SqlDataReader result) // заполнения данными
        {
            while (await result.ReadAsync())
            {
                spicok_klient.Rows.Add(result["Id"], result["subname"], result["name"], result["patronymic"], result["passport"]);
            }
        }
        private async void get_mans_Load(object sender, EventArgs e)// при загрузке
        {
            try
            {
                await bd.OpenAsync();
                SqlCommand dann_tabl = new SqlCommand("SELECT TOP 50 * FROM [Man] ORDER BY Id DESC", bd);
                result = await dann_tabl.ExecuteReaderAsync(); 
                set_bd(result);
                if(spicok_klient.RowCount > 0 )
                {
                    id_new_man = Convert.ToInt32(spicok_klient[0, 0].Value) + 1;
                }else
                {
                    id_new_man = 1;
                }
            }
            finally
            {
                if (result != null)
                {
                    result.Close();
                }
            }
            check_dann.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // переход к конкретному клиенту
        {
            if(e.ColumnIndex == 7 && e.RowIndex != -1)
            {
                if(check_dann.Enabled == true)
                {
                    bd.Close();
                    this.Hide();
                    get_man get_man = new get_man(Convert.ToInt32(spicok_klient[0, e.RowIndex].Value), bd);
                    get_man.Show();
                }
                else
                {
                    MessageBox.Show("Данные еще не загрузились подождите");
                }
 
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e) // переход к созданию клиента
        {
            if (check_dann.Enabled == true)
            {
                bd.Close();
                this.Hide();
                set_man set_man = new set_man(bd, id_new_man);
                set_man.Show();
            }
            else
            {
                MessageBox.Show("Данные еще не загрузились подождите");
            }
        }

        private void посмотретьToolStripMenuItem_Click(object sender, EventArgs e) // посмотреть статистику
        {
            if (check_dann.Enabled == true)
            {
                bd.Close();
                this.Hide();
                get_statistic_data get_statistic_data = new get_statistic_data(bd);
                get_statistic_data.Show();
            }
            else
            {
                MessageBox.Show("Данные еще не загрузились подождите");
            }
 
        }


        private async void text_TextChanged(object sender, EventArgs e) // изменение записей
        {
            check_dann.Visible = false;
            if (text.Text.Length == 0) // поле поиска пустое
            {
                spicok_klient.Rows.Clear();
                SqlCommand dann_tabl = new SqlCommand("SELECT TOP 50 * FROM [Man] ORDER BY Id DESC", bd);
                result = await dann_tabl.ExecuteReaderAsync();
                try
                {
                    set_bd(result);
                }
                finally
                {
                    if (result != null)
                    {
                        result.Close();
                    }
                }
            }else // в поле поиска есть значение
            {
                spicok_klient.Rows.Clear();
                SqlCommand poisc = new SqlCommand("SELECT * FROM [Man] WHERE subname LIKE @name", bd);
                poisc.Parameters.AddWithValue("@name", text.Text + "%");

                result = await poisc.ExecuteReaderAsync();
                try
                {
                    set_bd(result);
                }
                finally
                {
                    if (result != null)
                    {
                        result.Close();
                    }
                }
            }
            check_dann.Visible = true;

        }

        private void get_mans_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
}
