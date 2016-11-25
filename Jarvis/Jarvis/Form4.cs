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

namespace Jarvis
{
    public partial class Form4 : Form
    {
        string q;
        public Form4(string two)
        {
            InitializeComponent();
            q = two;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("Serif", 12, FontStyle.Regular);
            label2.Font = new Font("Serif", 12, FontStyle.Regular);
            label3.Font = new Font("Serif", 12, FontStyle.Regular);
            label4.Font = new Font("Serif", 12, FontStyle.Regular);
            label5.Font = new Font("Serif", 12, FontStyle.Regular);
            label6.Font = new Font("Serif", 12, FontStyle.Regular);
            label7.Font = new Font("Serif", 12, FontStyle.Regular);
            label8.Font = new Font("Serif", 12, FontStyle.Regular);
            label9.Font = new Font("Serif", 12, FontStyle.Regular);
            label10.Font = new Font("Serif", 12, FontStyle.Regular);
            label11.Font = new Font("Serif", 12, FontStyle.Regular);
            label16.Font = new Font("Serif", 12, FontStyle.Regular);
            button1.Font = new Font("Serif", 12, FontStyle.Regular);
            button2.Font = new Font("Serif", 12, FontStyle.Regular);
           
            textBox1.Font = new Font("Serif", 12, FontStyle.Regular);
            textBox2.Font = new Font("Serif", 12, FontStyle.Regular);
            textBox3.Font = new Font("Serif", 12, FontStyle.Regular);
            textBox4.Font = new Font("Serif", 12, FontStyle.Regular);
            textBox5.Font = new Font("Serif", 12, FontStyle.Regular);
            textBox6.Font = new Font("Serif", 12, FontStyle.Regular);
            textBox7.Font = new Font("Serif", 12, FontStyle.Regular);
            textBox8.Font = new Font("Serif", 12, FontStyle.Regular);
            
            textBox17.Font = new Font("Serif", 12, FontStyle.Regular);
            textBox18.Font = new Font("Serif", 12, FontStyle.Regular);
            
            textBox23.Font = new Font("Serif", 12, FontStyle.Regular);
            textBox24.Font = new Font("Serif", 12, FontStyle.Regular);

            dataGridView1.Font = new Font("Serif", 10, FontStyle.Regular);

            {
                    SqlConnection con5 = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                    con5.Open();
                    string query5 = String.Format("select * from onleave where no='"+q+"'");
                    SqlCommand sqlcmd = new SqlCommand();
                    sqlcmd.Connection = con5;
                    sqlcmd.CommandType = CommandType.Text;
                    sqlcmd.CommandText = query5;
                    SqlDataAdapter da2 = new SqlDataAdapter(sqlcmd);

                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    dataGridView1.DataSource = dt2;
            }

            SqlConnection con = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
            con.Open();
            SqlDataReader dr;
            string query = "select * from details where no='" + q + "'";
            SqlCommand comm = new SqlCommand(query);
            comm.Connection = con;
            dr = comm.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr["rank"].ToString();
                textBox2.Text = dr["name"].ToString();
                textBox3.Text = dr["no"].ToString();
                textBox4.Text = dr["mobile"].ToString();
                textBox5.Text = dr["address"].ToString();
                textBox6.Text = dr["status"].ToString();
            }
            {
                SqlConnection con6 = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                con6.Open();
                SqlDataReader dr2;
                string query6 = "select * from leave16 where no='" + q + "'";
                SqlCommand comm2 = new SqlCommand(query6);
                comm2.Connection = con6;
                dr2 = comm2.ExecuteReader();
                while (dr2.Read())
                {
                    textBox7.Text = dr2[1].ToString();
                    textBox8.Text = dr2[2].ToString();
                }
            }

            {
                SqlConnection con3 = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                con3.Open();
                SqlDataReader dr3;
                string query3 = "select * from leave17 where no='" + q + "'";
                SqlCommand comm3 = new SqlCommand(query3);
                comm3.Connection = con3;
                dr3 = comm3.ExecuteReader();
                while (dr3.Read())
                {
                    textBox18.Text = dr3[1].ToString();
                    textBox17.Text = dr3[2].ToString();
                }
            }

            {
                SqlConnection con3 = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                con3.Open();
                SqlDataReader dr3;
                string query3 = "select * from leave18 where no='" + q + "'";
                SqlCommand comm3 = new SqlCommand(query3);
                comm3.Connection = con3;
                dr3 = comm3.ExecuteReader();
                while (dr3.Read())
                {
                    textBox24.Text = dr3[1].ToString();
                    textBox23.Text = dr3[2].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                SqlConnection con = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                con.Open();
                string qw = String.Format("update leave16 set leave1='{0}',leave2='{1}',leave3='{2}',leave4='{3}',leave5='{4}',leave6='{5}' where no='{6}'", textBox7.Text, textBox8.Text, q);
                SqlCommand insert = new SqlCommand(qw, con);
                insert.ExecuteNonQuery();
            }
            {
                SqlConnection con = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                con.Open();
                string qw = String.Format("update leave17 set leave1='{0}',leave2='{1}',leave3='{2}',leave4='{3}',leave5='{4}',leave6='{5}' where no='{6}'", textBox18.Text, textBox17.Text, q);
                SqlCommand insert = new SqlCommand(qw, con);
                insert.ExecuteNonQuery();
            }
            {
                SqlConnection con = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                con.Open();
                string qw = String.Format("update leave18 set leave1='{0}',leave2='{1}',leave3='{2}',leave4='{3}',leave5='{4}',leave6='{5}' where no='{6}'", textBox24.Text, textBox23.Text, q);
                SqlCommand insert = new SqlCommand(qw, con);
                insert.ExecuteNonQuery();
            }
            Form4 ob = new Form4(q);
            this.Close();
            ob.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 ob = new Form10();
            ob.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
