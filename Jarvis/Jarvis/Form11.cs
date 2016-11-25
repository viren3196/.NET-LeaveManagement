using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Jarvis
{
    public partial class Form11 : Form
    {
        string name, rank, no, from, to;
        public Form11(string p, string q, string r, string s, string t)
        {
            InitializeComponent();
            name = p;
            rank = q;
            no = r;
            from = s;
            to = t;
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Serif", 16, FontStyle.Regular);
            button1.Font = new Font("Serif", 10, FontStyle.Regular); ;
            button2.Font = new Font("Serif", 10, FontStyle.Regular); ;
            textBox1.Text += "SUBJECT : Leave\n\n\n";
            textBox1.Text += rank;
            textBox1.Text += " ";
            textBox1.Text += name;
            textBox1.Text += " ";
            textBox1.Text += no;
            textBox1.Text += "\nHas been granted leave\n\n\nFrom:";
            textBox1.Text += from;
            textBox1.Text += "\nTo:";
            textBox1.Text += to;
            textBox1.Text += "\n\n\nSr JCO\nJagdeesh Singh";
        }
        private void printPage(Object sender, PrintPageEventArgs e)
        {
            string printText = textBox1.Text;
            Font printFont = textBox1.Font;
            e.Graphics.DrawString(printText, printFont, Brushes.Black, e.MarginBounds.X, e.MarginBounds.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += new PrintPageEventHandler(printPage);
            doc.Print();
            Form4 ob = new Form4(no);
            ob.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 ob = new Form4(no);
            ob.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
