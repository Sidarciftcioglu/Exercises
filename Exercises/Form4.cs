using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercises
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, num3, multiplication, subtraction, addition;
            
            num1=Convert.ToInt32(textBox1.Text);
            num2=Convert.ToInt32(textBox2.Text);
            num3=Convert.ToInt32(textBox3.Text);

            multiplication = num1 * num2 * num3;
            subtraction = num1 - num2 - num3;
            addition = num1 + num2 + num3;

            MessageBox.Show("Multiplication : " + multiplication + " " + "Subtraction : " + subtraction + " " + "addition : " + addition);
        }
    }
}
