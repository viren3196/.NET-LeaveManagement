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
    public partial class Form7 : Form
    {
        string from, to, q;
        int score,temp=0,temp2,flag;
        public Form7(string f, string t, string n, int h)
        {
            InitializeComponent();
            from = f;
            to = t;
            q = n;
            flag = h;
        }

        private void Form7_Load(object sender, EventArgs e)
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
            label12.Font = new Font("Serif", 12, FontStyle.Regular);
            label11.Font = new Font("Serif", 12, FontStyle.Regular);
            label12.Font = new Font("Serif", 12, FontStyle.Regular);
            label13.Font = new Font("Serif", 12, FontStyle.Regular);
            

            button1.Font = new Font("Serif", 12, FontStyle.Regular);
            button2.Font = new Font("Serif", 12, FontStyle.Regular);
           
            textBox1.Font = new Font("Serif", 12, FontStyle.Regular);
            textBox2.Font = new Font("Serif", 12, FontStyle.Regular);
            textBox3.Font = new Font("Serif", 12, FontStyle.Regular);
            textBox4.Font = new Font("Serif", 12, FontStyle.Regular);
            textBox5.Font = new Font("Serif", 12, FontStyle.Regular);
            textBox6.Font = new Font("Serif", 12, FontStyle.Regular);

            checkBox1.Font = new Font("Serif", 12, FontStyle.Regular);
            checkBox2.Font = new Font("Serif", 12, FontStyle.Regular);
            checkBox11.Font = new Font("Serif", 12, FontStyle.Regular);
            checkBox12.Font = new Font("Serif", 12, FontStyle.Regular);
            checkBox17.Font = new Font("Serif", 12, FontStyle.Regular);
            checkBox18.Font = new Font("Serif", 12, FontStyle.Regular);
            
            
            DateTime d1 = DateTime.Parse(from);
            DateTime d2 = DateTime.Parse(to);
            if (flag == 0)
            {
                score = int.Parse(((d2 - d1).TotalDays + 1).ToString());
                label2.Text = ((d2 - d1).TotalDays + 1).ToString();
            }
            else
            {
                score = int.Parse(((d2 - d1).TotalDays).ToString());
                label2.Text = ((d2 - d1).TotalDays).ToString();
            }
            temp2 = score;
            

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

            SqlConnection con2 = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
            con2.Open();
            SqlDataReader dr2;
            string query2 = "select * from leave16 where no='" + q + "'";
            SqlCommand comm2 = new SqlCommand(query2);
            comm2.Connection = con2;
            dr2 = comm2.ExecuteReader();
            while (dr2.Read())
            {
                checkBox1.Text = dr2[1].ToString();
                checkBox2.Text = dr2[2].ToString();
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
                    checkBox12.Text = dr3[1].ToString();
                    checkBox11.Text = dr3[2].ToString();
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
                    checkBox18.Text = dr3[1].ToString();
                    checkBox17.Text = dr3[2].ToString();
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int []a = new int[18];
            a[0] = Convert.ToInt32(checkBox1.Text);
            a[1] = Convert.ToInt32(checkBox2.Text);
            a[10] = Convert.ToInt32(checkBox11.Text);
            a[11] = Convert.ToInt32(checkBox12.Text);
            a[16] = Convert.ToInt32(checkBox17.Text);
            a[17] = Convert.ToInt32(checkBox18.Text);
            if (checkBox1.Checked == true)
            {
                temp += Convert.ToInt32(checkBox1.Text);
                if (temp2 > Convert.ToInt32(checkBox1.Text))
                {
                    a[0] = 0;
                    temp2 -= Convert.ToInt32(checkBox1.Text);
                }
                else
                {
                    a[0] = Convert.ToInt32(checkBox1.Text) - temp2;
                    temp2 = 0;
                }
                
            }
            if (checkBox2.Checked == true)
            {
                temp += Convert.ToInt32(checkBox2.Text);
                int x = Convert.ToInt32(checkBox2.Text);
                if (temp2 > x)
                {
                    a[1] = 0;
                    temp2 -= x;
                }
                else
                {
                    a[1] = x - temp2;
                    temp2 = 0;
                }
            }
            if (checkBox11.Checked == true)
            {
                temp += Convert.ToInt32(checkBox11.Text);
                int x = Convert.ToInt32(checkBox11.Text);
                if (temp2 > x)
                {
                    a[10] = 0;
                    temp2 -= x;
                }
                else
                {
                    a[10] = x - temp2;
                    temp2 = 0;
                }
            }
            if (checkBox12.Checked == true)
            {
                temp += Convert.ToInt32(checkBox12.Text);
                int x = Convert.ToInt32(checkBox12.Text);
                if (temp2 > x)
                {
                    a[11] = 0;
                    temp2 -= x;
                }
                else
                {
                    a[12] = x - temp2;
                    temp2 = 0;
                }
            }
            if (checkBox17.Checked == true)
            {
                temp += Convert.ToInt32(checkBox17.Text);
                int x = Convert.ToInt32(checkBox17.Text);
                if (temp2 > x)
                {
                    a[16] = 0;
                    temp2 -= x;
                }
                else
                {
                    a[16] = x - temp2;
                    temp2 = 0;
                }
            }
            if (checkBox18.Checked == true)
            {
                temp += Convert.ToInt32(checkBox18.Text);
                int x = Convert.ToInt32(checkBox18.Text);
                if (temp2 > x)
                {
                    a[17] = 0;
                    temp2 -= x;
                }
                else
                {
                    a[17] = x - temp2;
                    temp2 = 0;
                }
            }
            if (temp < score)
            {
                MessageBox.Show("Not enough days left");
            }
            else
            {
                {
                    SqlConnection con = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                    con.Open();
                    string qw = String.Format("update leave16 set leave1='{0}',leave2='{1}' where no='{2}'", a[0], a[1], q);
                    SqlCommand insert = new SqlCommand(qw, con);
                    insert.ExecuteNonQuery();
                }
                {
                    SqlConnection con = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                    con.Open();
                    string qw = String.Format("update leave17 set leave1='{0}',leave2='{1}' where no='{2}'", a[11], a[10], q);
                    SqlCommand insert = new SqlCommand(qw, con);
                    insert.ExecuteNonQuery();
                }
                {
                    SqlConnection con = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                    con.Open();
                    string qw = String.Format("update leave18 set leave1='{0}',leave2='{1}' where no='{2}'", a[17], a[16], q);
                    SqlCommand insert = new SqlCommand(qw, con);
                    insert.ExecuteNonQuery();
                }
                {
                    SqlConnection con = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                    con.Open();
                    string qw = String.Format("update details set status='" + "leave" + "' where no='{0}'", q);
                    SqlCommand insert = new SqlCommand(qw, con);
                    insert.ExecuteNonQuery();
                }
                string name="", rank="";
                {
                    SqlConnection con3 = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                    con3.Open();
                    SqlDataReader dr3;
                    string query3 = "select * from details where no='" + q + "'";
                    SqlCommand comm3 = new SqlCommand(query3);
                    comm3.Connection = con3;
                    dr3 = comm3.ExecuteReader();
                    while (dr3.Read())
                    {
                        rank = dr3[0].ToString();
                        name = dr3[1].ToString();
                    }
                }
                {
                    SqlConnection con = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                    con.Open();
                    string qw = String.Format("insert into onleave values ('{0}','{1}','{2}','{3}','{4}','"+"current"+"','{5}')", rank,name,q, from, to, comboBox1.SelectedItem.ToString());
                    SqlCommand insert = new SqlCommand(qw, con);
                    insert.ExecuteNonQuery();
                }
                Form11 ob = new Form11(rank,name,q,from,to);
                this.Hide();
                ob.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 ob = new Form10();
            ob.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
