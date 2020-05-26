﻿using System;
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
    public partial class Settings : Form
    {
        public static bool sevisited = false;
        public Settings()
        {
            InitializeComponent();
            sevisited = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ExitDashboard_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dsh4 = new Dashboard();
            this.Hide();
            dsh4.Show();
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            Profile pf4 = new Profile();
            this.Hide();
            pf4.Show();
        }

        private void btn_tasks_Click(object sender, EventArgs e)
        {
            Tasks tsk4 = new Tasks();
            this.Hide();
            tsk4.Show();
        }

        private void btn_statistics_Click(object sender, EventArgs e)
        {
            Statistics stc4 = new Statistics();
            this.Hide();
            stc4.Show();
        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {

        }

        private void bunifuiOSSwitch3_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch3.Value==true)
            {
                EditProfile p = new EditProfile();
                p.Show();
            }
        }

        private void btn_planningSettings_Click(object sender, EventArgs e)
        {
            DailyPlanning  dp3= new DailyPlanning();
            this.Hide();
            dp3.Show();


        }

        private void Settings_Shown(object sender, EventArgs e)
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
