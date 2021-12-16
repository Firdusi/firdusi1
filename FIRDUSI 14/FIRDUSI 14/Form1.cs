using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIRDUSI_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(textBox1.Text);
            if (radioButton1.Checked)
            {
                int oplata = b * 500;
                textBox2.Text = Convert.ToString(oplata);
            }

            
            if (radioButton2.Checked) 
            {
                int oplata = b * 100;
                textBox2.Text = Convert.ToString(oplata);
            }
        }
    }
}
