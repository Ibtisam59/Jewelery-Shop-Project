using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Jewelery_Shop_Project
{
    public partial class Form6: Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void FillInventoryFields()
        {
            maskedTextBox1.Text = "Emerald Necklace";          // Item Name

            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[] { "Ring", "Necklace", "Earrings", "Bracelet", "Pendant" });
            comboBox1.SelectedItem = "Necklace";               // Product Type

            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new string[] { "Gold 18K", "Silver", "Platinum", "Rose Gold" });
            comboBox2.SelectedItem = "Gold 18K";               // Material Type

            textBox2.Text = "2.0";                             // Carat
            textBox3.Text = "10.5";                            // Weight in grams
            textBox4.Text = "5";                               // Quantity
            textBox5.Text = "2500";                            // Gross Price
            textBox6.Text = "Emerald House Ltd.";              // Supplier

            dateTimePicker1.Value = new DateTime(2025, 4, 6);  // Date Acquired
        }




    }
}
