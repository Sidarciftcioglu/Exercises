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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int exam1, exam2, exam3, average;

            exam1=Convert.ToInt32(textBox1.Text);
            exam2=Convert.ToInt32(textBox2.Text);
            exam3=Convert.ToInt32(textBox3.Text);

            average = ((exam1 + exam2 + exam3) / 3);

            MessageBox.Show("Average : " + average);
        }
    }
}
