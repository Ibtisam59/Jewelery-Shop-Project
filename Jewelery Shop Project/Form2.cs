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
    public partial class Form2: Form
    {
        public Form2()
        {
             
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Open Form3 (Employee Details) when Button1 is clicked
            Form3 employeeDetails = new Form3();
            employeeDetails.Show();
            this.Hide(); // Hide Form2
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Go back to Form1 (Main Page) when Button2 is clicked
            Form1 mainPage = new Form1();
            mainPage.Show();
            this.Hide(); // Hide Form2
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_click(object sender, EventArgs e)
        {
            Form3 new_page = new Form3();
            new_page.Show(); // Opens Form2
            this.Hide();     // Hides t

        }

        private void button2_click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close(); // Closes
        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
