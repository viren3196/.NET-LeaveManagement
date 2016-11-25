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
using System.Globalization;

namespace Jarvis
{
    public partial class Form5 : Form
    {
        double score=0;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("Serif", 12, FontStyle.Regular);
            label2.Font = new Font("Serif", 12, FontStyle.Regular);
            label3.Font = new Font("Serif", 12, FontStyle.Regular);
            label4.Font = new Font("Serif", 12, FontStyle.Regular);
            label5.Font = new Font("Serif", 12, FontStyle.Regular);
            label6.Font = new Font("Serif", 12, FontStyle.Regular);
            label7.Font = new Font("Serif", 18, FontStyle.Regular);
            label8.Font = new Font("Serif", 14, FontStyle.Regular);
            label9.Font = new Font("Serif", 12, FontStyle.Regular);
            label10.Font = new Font("Serif", 18, FontStyle.Regular);
           
            button1.Font = new Font("Serif", 12, FontStyle.Regular);
            button2.Font = new Font("Serif", 12, FontStyle.Regular);
            button3.Font = new Font("Serif", 12, FontStyle.Regular);
            button4.Font = new Font("Serif", 12, FontStyle.Regular);
           
            textBox1.Font = new Font("Serif", 10, FontStyle.Regular);
            textBox2.Font = new Font("Serif", 10, FontStyle.Regular);
            textBox3.Font = new Font("Serif", 10, FontStyle.Regular);
            textBox4.Font = new Font("Serif", 10, FontStyle.Regular);
            textBox5.Font = new Font("Serif", 10, FontStyle.Regular);
            
            
            button3.Enabled = false;
            {
                SqlConnection con3 = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                con3.Open();
                SqlDataReader dr3;
                string query3 = "select count(*) from details where status !='" + "transferred" + "'";
                SqlCommand comm3 = new SqlCommand(query3);
                comm3.Connection = con3;
                dr3 = comm3.ExecuteReader();
                while (dr3.Read())
                {
                    textBox1.Text = dr3[0].ToString();
                }
            }
            {
                /*SqlConnection con3 = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                con3.Open();
                SqlDataReader dr3;
                string query3 = "select count(*) from details where status ='" + "duty" + "'";
                SqlCommand comm3 = new SqlCommand(query3);
                comm3.Connection = con3;
                dr3 = comm3.ExecuteReader();
                while (dr3.Read())
                {
                    textBox2.Text = dr3[0].ToString();
                    textBox3.Text = (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)).ToString();
                }*/
                SqlConnection con3 = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                con3.Open();
                SqlDataReader dr3;
                string query3 = "select from1,to1 from onleave where status ='" + "current" + "'";
                SqlCommand comm3 = new SqlCommand(query3);
                comm3.Connection = con3;
                dr3 = comm3.ExecuteReader();
                int cnt = 0;
                DateTime d3 = DateTime.Parse(monthCalendar1.SelectionRange.Start.ToShortDateString());
                while (dr3.Read())
                {
                    DateTime d1 = Convert.ToDateTime(dr3[0].ToString());
                    DateTime d2 = Convert.ToDateTime(dr3[1].ToString());
                    if (d3.Date >= d1.Date && d3.Date <= d2.Date)
                    {
                        cnt++;
                    }
                }
                textBox2.Clear();
                textBox3.Clear();
                label7.Text = "";
                label10.Text = "";
                double a = Convert.ToInt32(textBox1.Text);
                double b, c;
                c = a - cnt;
                textBox3.Text = cnt.ToString();
                textBox2.Text = c.ToString();
                score = Math.Round(((c - 1) / a * 100), 2);
                label7.Text = "(";
                label7.Text += score.ToString();
                label7.Text += "%)";

                b = (cnt / a) * 100;
                c = 100 - b;
                textBox3.Text += " (";
                textBox3.Text += (Math.Round(b, 2)).ToString();
                textBox3.Text += "%)";

                textBox2.Text += " (";
                textBox2.Text += (Math.Round((100 - b), 2)).ToString();
                textBox2.Text += "%)";

                label10.Text += " (";
                label10.Text += (Math.Round((100 - b), 2)).ToString();
                label10.Text += "%)";
            }
            {
                SqlConnection con3 = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                con3.Open();
                SqlDataReader dr3;
                string query3 = "select count(*) from details where status ='" + "transferred" + "'";
                SqlCommand comm3 = new SqlCommand(query3);
                comm3.Connection = con3;
                dr3 = comm3.ExecuteReader();
                while (dr3.Read())
                {
                    label5.Text = dr3[0].ToString();
                }
            }
            
            
            
            
            
            
            /*
            double a = Convert.ToInt32(textBox1.Text);
            double b = Convert.ToInt32(textBox2.Text);
            double c = b;
            b = (b / a) * 100;
            textBox2.Text += " (";
            textBox2.Text += (Math.Round(b,2)).ToString();
            textBox2.Text += "%)";

            textBox3.Text += " (";
            textBox3.Text += (Math.Round((100-b),2)).ToString();
            textBox3.Text += "%)";

            score = Math.Round(((c - 1) / a * 100), 2);
            label7.Text = "(";
            label7.Text += score.ToString();
            label7.Text += "%)";*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (score < 70.00)
            {
                DialogResult dr = MessageBox.Show("Needs permission by OC. Permitted?", "", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    textBox4.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
                }
                else
                {

                }
            }
            else
            {
                textBox4.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (score < 70.00)
            {
                DialogResult dr = MessageBox.Show("Needs permission by OC. Permitted?", "", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    textBox5.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
                }
                else
                {

                }
            }
            else
            {
                textBox5.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
            }
            if (!textBox4.Text.Equals("") && !textBox5.Text.Equals(""))
            {
                button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 ob = new Form6(textBox4.Text,textBox5.Text);
            this.Hide();
            ob.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form10 ob = new Form10();
            ob.Show();
            this.Hide();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            SqlConnection con3 = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
            con3.Open();
            SqlDataReader dr3;
            string query3 = "select from1,to1 from onleave where status ='" + "current" + "'";
            SqlCommand comm3 = new SqlCommand(query3);
            comm3.Connection = con3;
            dr3 = comm3.ExecuteReader();
            int cnt = 0;
            DateTime d3 = DateTime.Parse(monthCalendar1.SelectionRange.Start.ToShortDateString());
            while (dr3.Read())
            {
                DateTime d1 = Convert.ToDateTime(dr3[0].ToString());
                DateTime d2 = Convert.ToDateTime(dr3[1].ToString());
                
                if (d3.Date >= d1.Date && d3.Date <= d2.Date)
                {
                    cnt++;
                }
            }
            textBox2.Clear();
            textBox3.Clear();
            label7.Text = "";
            label10.Text = "";
            double a = Convert.ToInt32(textBox1.Text);
            double b, c;
            c = a - cnt;
            textBox3.Text = cnt.ToString();
            textBox2.Text = c.ToString();
            score = Math.Round(((c - 1) / a * 100), 2);
            label7.Text = "(";
            label7.Text += score.ToString();
            label7.Text += "%)";

            b = (cnt / a) * 100;
            c = 100 - b;
            textBox3.Text += " (";
            textBox3.Text += (Math.Round(b, 2)).ToString();
            textBox3.Text += "%)";

            textBox2.Text += " (";
            textBox2.Text += (Math.Round((100 - b), 2)).ToString();
            textBox2.Text += "%)";

            label10.Text += " (";
            label10.Text += (Math.Round((100 - b), 2)).ToString();
            label10.Text += "%)";
        }
    }
}
