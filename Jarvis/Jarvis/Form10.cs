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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ob = new Form2();
            ob.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 ob = new Form5();
            ob.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 ob = new Form3();
            this.Hide();
            ob.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 ob = new Form8();
            this.Hide();
            ob.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form9 ob = new Form9();
            ob.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ob = new Form1();
            ob.Show();
            this.Hide();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            button1.Font = new Font("Serif", 10, FontStyle.Regular);
            button2.Font = new Font("Serif", 10, FontStyle.Regular);
            button3.Font = new Font("Serif", 10, FontStyle.Regular);
            button4.Font = new Font("Serif", 10, FontStyle.Regular);
            button5.Font = new Font("Serif", 10, FontStyle.Regular);
            button6.Font = new Font("Serif", 10, FontStyle.Regular);
            label1.Font = new Font("Serif", 20, FontStyle.Regular);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you Sure?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                {
                    SqlConnection con = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                    con.Open();
                    string qw = String.Format("delete from details");
                    SqlCommand insert = new SqlCommand(qw, con);
                    insert.ExecuteNonQuery();
                }
                {
                    SqlConnection con = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                    con.Open();
                    string qw = String.Format("delete from onleave");
                    SqlCommand insert = new SqlCommand(qw, con);
                    insert.ExecuteNonQuery();
                }
                {
                    SqlConnection con = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                    con.Open();
                    string qw = String.Format("delete from leave16");
                    SqlCommand insert = new SqlCommand(qw, con);
                    insert.ExecuteNonQuery();
                }
                {
                    SqlConnection con = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                    con.Open();
                    string qw = String.Format("delete from leave17");
                    SqlCommand insert = new SqlCommand(qw, con);
                    insert.ExecuteNonQuery();
                }
                {
                    SqlConnection con = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                    con.Open();
                    string qw = String.Format("delete from leave18");
                    SqlCommand insert = new SqlCommand(qw, con);
                    insert.ExecuteNonQuery();
                }
            }
            else
            { 
            
            }
        }
    }
}
