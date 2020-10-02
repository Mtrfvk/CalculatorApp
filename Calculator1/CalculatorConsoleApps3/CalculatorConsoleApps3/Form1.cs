using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CalculatorConsoleApps3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int hasil = 0;

            if (comboBox1.Text == "Penambahan")
            {
                hasil = a + b;
            }
            else if (comboBox1.Text == "Pengurangan")
            {
                hasil = a - b;
            }
            else if (comboBox1.Text == "Perkalian")
            {
                hasil = a * b;
            }
            else if (comboBox1.Text == "Pembagian")
            {
                hasil = a / b;
            }



            textBox3.Text = hasil.ToString();
    

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
