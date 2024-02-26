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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radius,area,perimeter;
            double pi = 3.14;

            radius=Convert.ToDouble(textBox1.Text);

            area = pi*radius*radius;
            perimeter = 2 * pi * radius;

            MessageBox.Show("Area : " + area + " " + "Perimeter : " + perimeter);


        }
    }
}
