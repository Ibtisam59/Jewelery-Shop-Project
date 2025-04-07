using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jewelery_Shop_Project
{
    public partial class Form1: Form
    {
        public Form1()
        {
             
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Open Form2 when Button1 is clicked
            Form2 employeeManagement = new Form2();
            employeeManagement.Show();
            this.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_click(object sender, EventArgs e)
        {
            Form2 new_page = new Form2();
            new_page.Show(); // Opens Form2
            this.Hide();     // Hides t
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 new_page = new Form6();
            new_page.Show(); // Opens Form2
            this.Hide();     // Hides t
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 new_page = new Form2();
            new_page.Show(); // Opens Form2
            this.Hide();     // Hides t
        }
    }
}
