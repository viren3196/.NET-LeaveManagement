﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Jarvis
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("Serif", 10, FontStyle.Regular);

            button1.Font = new Font("Serif", 10, FontStyle.Regular);
            button2.Font = new Font("Serif", 10, FontStyle.Regular);
            dataGridView1.Font = new Font("Serif", 10, FontStyle.Regular);
            comboBox1.Font = new Font("Serif", 10, FontStyle.Regular);



            button1.Enabled = false;
            SqlConnection con = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
            con.Open();
            string all = "All ranks";
            string query = String.Format("select rank from rank order by case when rank='{0}' then 0 else 1 end ", all);
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.ValueMember = "rank";
            comboBox1.DataSource = dt;

            SqlConnection con2 = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
            con2.Open();
            string query2 = String.Format("select * from onleave where status='" + "current" + "' order by rank,name");
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = con2;
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = query2;
            SqlDataAdapter da2 = new SqlDataAdapter(sqlcmd);

            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                SqlConnection con = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                con.Open();
                int index = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];
                string two = Convert.ToString(row.Cells["no"].Value);
                string one = "duty";
                string q = String.Format("update details set status='{0}' where no='{1}'", one, two);
                SqlCommand insert = new SqlCommand(q, con);
                insert.ExecuteNonQuery();
            }
            {
                SqlConnection con = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                con.Open();
                int index = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];
                string two = Convert.ToString(row.Cells["no"].Value);
                string one = "past";
                string q = String.Format("update onleave set status='{0}' where no='{1}'", one, two);
                SqlCommand insert = new SqlCommand(q, con);
                insert.ExecuteNonQuery();
            }
            Form9 ob = new Form9();
            ob.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
            con.Open();
            string all = comboBox1.SelectedValue.ToString();
            string query;
            if (all.Equals("All ranks"))
            {
                query = String.Format("select * from onleave where status='" + "current" + "' order by rank,name");
            }
            else
            {
                query = String.Format("select * from onleave where status='" + "current" + "' and rank='{0}' order by rank,name", all);
            }

            //SqlDataAdapter da = new SqlDataAdapter(query, con);

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = con;
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 ob = new Form10();
            ob.Show();
            this.Hide();

        }
    }
}
