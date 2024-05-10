using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 5;
            int b = 15;
            int c = 7;
            int delta = b * b - 4 * a * c;
            double a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double a2 = (-b - Math.Sqrt(delta)) / (2 * a);
            MessageBox.Show("Resultado de a1: " + a1);
            MessageBox.Show("Resultado de a2: " + a2);

        }
    }
}
