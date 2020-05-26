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

namespace ProjetNadhamni
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dsh1 = new Dashboard();
            this.Hide();
            dsh1.Show();
        }

        private void btn_tasks_Click(object sender, EventArgs e)
        {
            Tasks tsk1 = new Tasks();
            this.Hide();
            tsk1.Show();
        }

        private void btn_statistics_Click(object sender, EventArgs e)
        {
            Statistics stc1 = new Statistics();
            this.Hide();
            stc1.Show();
        }

        private void btn_parameters_Click(object sender, EventArgs e)
        {
            Settings st1 = new Settings();
            this.Hide();
            st1.Show();
        }

        private void ExitDashboard_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_planningProfile_Click(object sender, EventArgs e)
        {
            DailyPlanning dp2 = new DailyPlanning();
            this.Hide();
            dp2.Show();
        }

        private void Profile_Shown(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = @"Data Source=DESKTOP-69MM1NJ\SQLEXPRESS;Initial Catalog=NadhamniDB;Integrated Security=True;Pooling=False";

            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("select FirstName from Profile where UserName='" + Home.FK + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt_firstName.Text = dr[0].ToString();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

        }
    }
}
