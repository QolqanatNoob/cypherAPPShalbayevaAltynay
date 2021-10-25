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
    public partial class Caesar : Form
    {

        public Caesar()
        {
            InitializeComponent();
        }

        static string alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Enc(textBox1.Text);
        }

        public string Enc(string inp)
        {
            StringBuilder a1 = new StringBuilder();

            string PlnTxt = textBox1.Text;

            string Key = textBox4.Text;

            int step = Convert.ToInt32(Key);

            for (int i = 0; i < PlnTxt.Length; i++)

                for (int j = 0; j < alph.Length; j++)

                    if (PlnTxt[i] == alph[j]) a1.Append(alph[(j + step) % alph.Length]);

            return a1.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Enc1(textBox2.Text);
        }

        public string Enc1(string inp)
        {
            StringBuilder a1 = new StringBuilder();

            string PlnTxt = textBox2.Text;

            string Key = textBox4.Text;

            int step = Convert.ToInt32(Key);

            for (int i = 0; i < PlnTxt.Length; i++) 

                for (int j = 0; j < alph.Length; j++)
                

                    if (PlnTxt[i] == alph[j]) a1.Append(alph[(j - step + alph.Length) % alph.Length]);
                
                    return a1.ToString();
                

        }
    }
}
