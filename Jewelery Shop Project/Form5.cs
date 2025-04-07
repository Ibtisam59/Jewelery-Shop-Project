using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Jewelery_Shop_Project;

namespace JewelryShopApp
{
    public partial class Form5 : Form
    {
        public Form5()
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Dummy validation (Replace this with database authentication)
            if (username == "admin" && password == "password123")
            {
                Form1 mainPage = new Form1();
                mainPage.Show();
                this.Hide(); // Hide the login form after successful login
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}





