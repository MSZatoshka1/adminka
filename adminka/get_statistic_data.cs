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
    public partial class get_statistic_data : Form
    {
        SqlConnection bd;
        public get_statistic_data(SqlConnection bd)
        {
            InitializeComponent();
            this.bd = bd;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        public string name_get(string from, int id)
        {
            object table = null;
            string ret = "";
            SqlCommand SEL = new SqlCommand("SELECT name FROM " + from + " WHERE Id = @Id", bd);
            SEL.Parameters.AddWithValue("@Id", id);
            table = SEL.ExecuteScalar();
            ret = Convert.ToString(table);
            return ret;
        }
        private async void get_statistic_data_Load(object sender, EventArgs e)
        {
            SqlDataReader result = null;
            await bd.OpenAsync();
            try
            {
                SqlCommand select = new SqlCommand("SELECT * FROM time_klient LEFT OUTER JOIN [Man] ON Man.Id = time_klient.id_klient LEFT OUTER JOIN [specialty]  ON specialty.Id = Man.id_specialty LEFT OUTER JOIN [organization]  ON organization.Id = Man.id_organization", bd);
                result = await select.ExecuteReaderAsync();              
                while (await result.ReadAsync())
                {
                    DateTime date = Convert.ToDateTime(result["date_of_arrival"]);
                    DateTime date1 = Convert.ToDateTime(result["date_of_withdrawal"]);
                    statick.Rows.Add(result["subname"], result[7], result["patronymic"], result[20], result[18], result["passport"], result["report_card_number"], date.ToString("dd.MM.yyyy"), date1.ToString("dd.MM.yyyy"), result[4]);
                }
            }
            finally
            {
                if(result!= null)
                {
                    result.Close();
                }
            }
        }

        private void списокКлиентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            bd.Close();
            get_mans get_mans = new get_mans();
            get_mans.Show();
        }

        private void get_statistic_data_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
