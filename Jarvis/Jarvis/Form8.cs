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
    public partial class Form8 : Form
    {
        string no, from, to;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

            label1.Font = new Font("Serif", 12, FontStyle.Regular);
            label2.Font = new Font("Serif", 12, FontStyle.Regular);
            label3.Font = new Font("Serif", 12, FontStyle.Regular);

            button1.Font = new Font("Serif", 12, FontStyle.Regular);
            button2.Font = new Font("Serif", 12, FontStyle.Regular);
            button3.Font = new Font("Serif", 12, FontStyle.Regular);

            textBox1.Font = new Font("Serif", 12, FontStyle.Regular);
            dataGridView1.Font = new Font("Serif", 10, FontStyle.Regular);
            
            
            button1.Enabled = false;
            SqlConnection con2 = new SqlConnection("server=.;initial catalog=jarvis;integrated security=true");
            con2.Open();
            string query2 = String.Format("select * from onleave where status='"+"current"+"' order by rank,name");
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = con2;
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = query2;
            SqlDataAdapter da2 = new SqlDataAdapter(sqlcmd);

            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            no = Convert.ToString(row.Cells["no"].Value);
            from = Convert.ToString(row.Cells["from1"].Value);
            to = Convert.ToString(row.Cells["to1"].Value);
            label2.Text = from;
            textBox1.Text = to;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime d1 = DateTime.Parse(to);
            d1 = d1.AddDays(1);
            DateTime d2 = DateTime.Parse(textBox1.Text);
            int days = Convert.ToInt32(((d2 - d1).TotalDays+1).ToString());
            if (days > 0)
            {
                Form7 ob = new Form7(d1.ToString("dd/MM/yyyy"),textBox1.Text,no,0);
                this.Hide();
                ob.Show();
            }
            else if (days < 0)
            {
                Form4 ob = new Form4(no);
                this.Hide();
                ob.Show();
            }
            else
            {
                MessageBox.Show("Same date chosen");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 ob = new Form10();
            ob.Show();
            this.Hide();
        }
    }
}
