using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace cypherAPP
{
    public partial class Systemy_Schisleniya : Form
    {
        string bukv = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public Systemy_Schisleniya()
        {
            InitializeComponent();
            numericUpDown1.Minimum = 2;
            numericUpDown1.Maximum = 25;
            numericUpDown1.Value = 10;
            numericUpDown2.Minimum = 2;
            numericUpDown2.Maximum = 25;
            numericUpDown2.Value = 10;
            button1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Переводит из деятичной системы счисления в систему счисления с основанием N
        /// </summary>
        /// <param name="number">Число, которое переводим </param>
        /// <param name="sys">Система счисления, в которую переводим</param>
        /// <returns>Возвращает переведенное число в строковом формате</returns>
        private string ToN(string number, string sys)
        {
            string newNum = "";
            int num = Convert.ToInt32(number);
            int chast = Convert.ToInt32(number);
            ArrayList numTemp = new ArrayList();
            while (chast > 0)
            {
                chast = chast / Convert.ToInt32(sys);
                numTemp.Add(num - chast * Convert.ToInt32(sys));
                num = chast;
            }
            int j;
            for (j = numTemp.Count - 1; j >= 0; j--)
                newNum += newCh(numTemp[j].ToString(), "to");
            return newNum;
        }
        /// <summary>
        /// Функция, заменяет буквы на числа и наоборот
        /// </summary>
        /// <param name="sym">Число, над которым нужно работать</param>
        /// <param name="otk">В какую сторону осуществляется действие относительно десятичной системы счисления</param>
        /// <returns>Возвращает букву, если числу соответствует буква и наоборот, иначе число</returns>
        string newCh(string sym, string otk)
        {
            string s = "";
            if (otk == "to")
            {
                if (Convert.ToInt32(sym) > 10)
                    s += bukv.Substring(Convert.ToInt32(sym) - 10, 1);
                else
                    s += sym;
            }
            else if (otk == "from")
            {
                if (bukv.IndexOf(sym) == -1)
                    s += sym;
                else
                    s += (bukv.IndexOf(sym) + 10).ToString();
            }
            return s;
        }


        /// <summary>
        /// Переводит системы счисления с основанием N в деятичную систему счисления 
        /// </summary>
        /// <param name="number">Число, которое переводим </param>
        /// <param name="sys">Система счисления, из которой переводим</param>
        /// <returns>Возвращает переведенное число в строковом формате</returns>
        private string FromN(string number, string sys)
        {
            int newNum = 0;
            string temp = "";
            int t;
            int i;
            for (i = 0; i < number.Length; i++)
            {
                temp = "";
                temp += newCh(number.Substring(i, 1), "from");
                t = (int)Math.Pow(Convert.ToDouble(sys), Convert.ToDouble(number.Length - (i + 1)));
                newNum += Convert.ToInt32(temp) * t;
            }
            return newNum.ToString();
        }
        private string FromTo(string number, string sysN, string sysK)
        {
            string temp = "";
            temp = FromN(number, sysN);
            temp = ToN(temp, sysK);
            return temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 10 && numericUpDown2.Value != 10)
                textBox2.Text = ToN(textBox1.Text, numericUpDown2.Value.ToString());
            else if (numericUpDown2.Value == 10 && numericUpDown1.Value != 10)
                textBox2.Text = FromN(textBox1.Text, numericUpDown1.Value.ToString());
            else if (numericUpDown2.Value != 10 && numericUpDown1.Value != 10)
                textBox2.Text = FromTo(textBox1.Text, numericUpDown1.Value.ToString(), numericUpDown2.Value.ToString());
            button1.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}

