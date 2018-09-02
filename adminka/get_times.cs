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

namespace adminka
{
    public partial class get_times : Form
    {
        SqlConnection bd;
        public get_times(SqlConnection bd)
        {
            InitializeComponent();
            this.bd = bd;
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            bd.Close();
            get_mans get_mans = new get_mans();
            get_mans.Show();
        }

        private async void get_times_Load(object sender, EventArgs e)
        {
            SqlDataReader returs = null;
            await bd.OpenAsync();
            SqlCommand Select = new SqlCommand("SELECT * FROM time_klient LEFT JOIN Man ON Man.Id = time_klient.id_klient WHERE check_arrival = 1", bd);
            returs = await Select.ExecuteReaderAsync();
            try
            {
                while (await returs.ReadAsync())
                {
                    DateTime date1 = Convert.ToDateTime(returs["date_of_arrival"]);
                    DateTime date2 = Convert.ToDateTime(returs["date_of_withdrawal"]);    
                    spicok.Rows.Add(returs[0], returs["id_klient"], returs["subname"], returs["name"], returs["patronymic"], returs["passport"], returs["report_card_number"], date1.ToString("dd.MM.yyyy"), date2.ToString("dd.MM.yyyy"), returs["komnata"]);
                }
            }
            finally
            {
                if (returs != null)
                {
                    returs.Close();
                }
            } 
        }

        private async void spicok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 10 || e.ColumnIndex == 11)
            {
                SqlCommand update_time = new SqlCommand("UPDATE time_klient SET check_arrival = 0 WHERE Id = @id",bd);
                update_time.Parameters.AddWithValue("@id", spicok[0, e.RowIndex].Value);
                await update_time.ExecuteNonQueryAsync();
            }
            if(e.ColumnIndex == 10)
            {
                DateTime date1 = DateTime.Today;
                DateTime date2 = DateTime.Today.AddMonths(1);
                SqlCommand Inset = new SqlCommand("INSERT INTO [time_klient] (id_klient, date_of_arrival ,date_of_withdrawal,check_arrival ,komnata) VALUES (@id_klient,@date_of_arrival,@date_of_withdrawal,@check_arrival,@komnata)", bd);
                Inset.Parameters.AddWithValue("id_klient", spicok[1, e.RowIndex].Value);
                Inset.Parameters.AddWithValue("date_of_arrival", date1);
                Inset.Parameters.AddWithValue("date_of_withdrawal", date2);
                Inset.Parameters.AddWithValue("check_arrival",1);
                Inset.Parameters.AddWithValue("komnata", spicok[9, e.RowIndex].Value);
                await Inset.ExecuteNonQueryAsync();
                spicok[7 ,e.RowIndex].Value = date1.ToString("dd.MM.yyyy");
                spicok[8, e.RowIndex].Value = date2.ToString("dd.MM.yyyy");
            }
            if (e.ColumnIndex == 11)
            {
                SqlCommand update_man = new SqlCommand("UPDATE Man SET check_komnata = 0 WHERE Id = @id", bd);
                update_man.Parameters.AddWithValue("@id", spicok[1, e.RowIndex].Value);
                await update_man.ExecuteNonQueryAsync();
                spicok.Rows.RemoveAt(e.RowIndex);
                // MessageBox.Show("Нажата кнопка закрыть на строке " + e.RowIndex.ToString());
            }
        }
    }
}
