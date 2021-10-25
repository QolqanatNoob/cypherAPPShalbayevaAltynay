using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cypherAPP
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        /*
        private void button2_Click(object sender, EventArgs e)
        {
            FormVigener newForm = new FormVigener();
            newForm.Show();
        }
        */
        private void button1_Click(object sender, EventArgs e)
        {
            Caesar newForm = new Caesar();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Systemy_Schisleniya newForm = new Systemy_Schisleniya();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DES_64 newForm = new DES_64();
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vigenerTWO newForm = new vigenerTWO();
            newForm.Show();
        }
    }
}
