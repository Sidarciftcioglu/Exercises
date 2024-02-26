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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int shortEdge, longEdge, area, perimeter;

            shortEdge = Convert.ToInt32(textBox1.Text);
            longEdge = Convert.ToInt32(textBox2.Text);

            area = shortEdge * longEdge;
            perimeter = (2*longEdge) + (2*shortEdge);

            MessageBox.Show("Area : " + area +"  "+"Perimeter : " + perimeter);
        }
    }
}
