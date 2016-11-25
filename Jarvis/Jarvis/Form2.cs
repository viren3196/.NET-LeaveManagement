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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Equals(""))
            {
                SqlConnection con = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                con.Open();
                SqlCommand insert = new SqlCommand("Insert into rank(rank) values (@1)", con);
                insert.Parameters.AddWithValue("1", textBox1.Text);
                insert.ExecuteNonQuery();
                MessageBox.Show("Rank inserted");
                Form1 ob = new Form1();
                ob.Show();
                this.Hide();
            }
            else if (listBox1.SelectedIndex <1 || textBox2.Text.Equals("") || textBox3.Text.Equals(""))
            {
                MessageBox.Show("Enter Mandatory fields");
            }
            else
            {
                SqlConnection con = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                con.Open();
                SqlCommand insert = new SqlCommand("Insert into details(rank,name,no,mobile,address,status) values (@1,@2,@3,@4,@5,@6)", con);
                insert.Parameters.AddWithValue("1", listBox1.SelectedValue.ToString());
                insert.Parameters.AddWithValue("2", textBox2.Text);
                insert.Parameters.AddWithValue("3", textBox3.Text);
                insert.Parameters.AddWithValue("4", textBox4.Text);
                insert.Parameters.AddWithValue("5", textBox5.Text);
                insert.Parameters.AddWithValue("6", "duty");
                insert.ExecuteNonQuery();
                MessageBox.Show("Inserted");

                SqlConnection con2 = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                con2.Open();
                SqlCommand insert2 = new SqlCommand("Insert into leave16(no) values (@1)", con2);
                insert2.Parameters.AddWithValue("1", textBox3.Text);
                insert2.ExecuteNonQuery();

                SqlConnection con3 = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                con3.Open();
                SqlCommand insert3 = new SqlCommand("Insert into leave17(no) values (@1)", con3);
                insert3.Parameters.AddWithValue("1", textBox3.Text);
                insert3.ExecuteNonQuery();


                SqlConnection con4 = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
                con4.Open();
                SqlCommand insert4 = new SqlCommand("Insert into leave18(no) values (@1)", con4);
                insert4.Parameters.AddWithValue("1", textBox3.Text);
                insert4.ExecuteNonQuery();

                Form2 ob = new Form2();
                ob.Show();
                this.Hide();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("Serif", 12, FontStyle.Regular);
            label2.Font = new Font("Serif", 12, FontStyle.Regular);
            label3.Font = new Font("Serif", 12, FontStyle.Regular);
            label4.Font = new Font("Serif", 12, FontStyle.Regular);
            label5.Font = new Font("Serif", 12, FontStyle.Regular);
            label6.Font = new Font("Serif", 12, FontStyle.Regular);

            button1.Font = new Font("Serif", 12, FontStyle.Regular);
            button2.Font = new Font("Serif", 12, FontStyle.Regular);

            textBox1.Font = new Font("Serif", 12, FontStyle.Regular);
            textBox2.Font = new Font("Serif", 12, FontStyle.Regular);
            textBox3.Font = new Font("Serif", 12, FontStyle.Regular);
            textBox4.Font = new Font("Serif", 12, FontStyle.Regular);
            textBox5.Font = new Font("Serif", 12, FontStyle.Regular);

            groupBox1.Font = new Font("Serif", 12, FontStyle.Regular);
            groupBox2.Font = new Font("Serif", 12, FontStyle.Regular);

            radioButton1.Font = new Font("Serif", 12, FontStyle.Regular);
            radioButton2.Font = new Font("Serif", 12, FontStyle.Regular);
            
            
            textBox1.Enabled = false;

            SqlConnection con = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
            con.Open();
            string all = "All ranks";
            string query = String.Format("select rank from rank order by case when rank='{0}' then 0 else 1 end ",all);
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            listBox1.ValueMember = "rank";
            listBox1.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            textBox1.Enabled = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            textBox3.Enabled = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 ob = new Form10();
            ob.Show();
            this.Hide();
        }
    }
}
