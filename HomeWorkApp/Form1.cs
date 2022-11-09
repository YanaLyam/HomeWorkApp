using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            double A = Convert.ToDouble(a);
            double B = Convert.ToDouble(b);
            double C = Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));
            C = Math.Round(C * 100) / 100;


            
            if (A == B)
            {
                tbresult.Text = C.ToString() + " Это равнобедренный треугольник.";
            }
            else if (A != B && A != C)
            {
                tbresult.Text = C.ToString() + " Это разносторонний треугольник.";
            }
            




        }
    }
}
