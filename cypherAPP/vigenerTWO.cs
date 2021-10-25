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
    public partial class vigenerTWO : Form
    {
        public vigenerTWO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";

            string[] alphabet = { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };

            string input = "", key = "", key_temp = "", input_tolower = "", key_temp_tolower = "";

            int mod = 0, number_of_letter;

            input_tolower = richTextBox1.Text;

            input = input_tolower.ToLower();

            key_temp_tolower = textBox1.Text;

            key_temp = key_temp_tolower.ToLower();

            if (richTextBox1.Text != "" && textBox1.Text != "")
            {
                mod = input.Length % key_temp.Length;

                for (int i = 0; i < (input.Length - mod) / key_temp.Length; i++)
                {
                    key += key_temp;
                }

                for (int i = 0; i < mod; i++)
                {
                    key += key_temp[i];
                }

                string[] input_mas = new string[input.Length];
                int[] input_index = new int[input.Length];

                string[] key_mas = new string[input.Length];
                int[] key_index = new int[input.Length];

                string[] encrypted_word = new string[input.Length];


                for (int i = 0; i < input.Length; i++)
                {
                    input_mas[i] = Convert.ToString(input[i]);
                }

                for (int i = 0; i < key.Length; i++)
                {
                    key_mas[i] = Convert.ToString(key[i]);
                }



                for (int i = 0; i < input.Length; i++)
                {
                    for (int j = 0; j < alphabet.Length; j++)
                    {
                        if (input_mas[i] == alphabet[j])
                        {
                            input_index[i] = j;
                        }

                        if (key_mas[i] == alphabet[j])
                        {
                            key_index[i] = j;
                        }
                    }
                }


                for (int i = 0; i < input_mas.Length; i++)
                {
                    number_of_letter = (input_index[i] + key_index[i]) % 33;
                    encrypted_word[i] = alphabet[number_of_letter];
                    number_of_letter = 0;
                }

                for (int i = 0; i < input_index.Length; i++)
                {
                    richTextBox2.Text += encrypted_word[i];
                }
            }

            else
            {
                MessageBox.Show("Вы не ввели значение в одно из обязательных полей");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";

            string[] alphabet = { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };

            string input = "", key = "", key_temp = "", input_tolower = "", key_temp_tolower = "";

            int mod = 0, number_of_letter;

            input_tolower = richTextBox1.Text;

            input = input_tolower.ToLower();

            key_temp_tolower = textBox1.Text;

            key_temp = key_temp_tolower.ToLower();

            if (richTextBox1.Text != "" && textBox1.Text != "")
            {
                mod = input.Length % key_temp.Length;

                for (int i = 0; i < (input.Length - mod) / key_temp.Length; i++)
                {
                    key += key_temp;
                }

                for (int i = 0; i < mod; i++)
                {
                    key += key_temp[i];
                }

                string[] input_mas = new string[input.Length];
                int[] input_index = new int[input.Length];

                string[] key_mas = new string[input.Length];
                int[] key_index = new int[input.Length];

                string[] encrypted_word = new string[input.Length];


                for (int i = 0; i < input.Length; i++)
                {
                    input_mas[i] = Convert.ToString(input[i]);
                }

                for (int i = 0; i < key.Length; i++)
                {
                    key_mas[i] = Convert.ToString(key[i]);
                }



                for (int i = 0; i < input.Length; i++)
                {
                    for (int j = 0; j < alphabet.Length; j++)
                    {
                        if (input_mas[i] == alphabet[j])
                        {
                            input_index[i] = j;
                        }

                        if (key_mas[i] == alphabet[j])
                        {
                            key_index[i] = j;
                        }
                    }
                }


                for (int i = 0; i < input_mas.Length; i++)
                {
                    number_of_letter = (input_index[i] - key_index[i] + 33) % 33;
                    encrypted_word[i] = alphabet[number_of_letter];
                    number_of_letter = 0;
                }

                for (int i = 0; i < input_index.Length; i++)
                {
                    richTextBox2.Text += encrypted_word[i];
                }
            }

            else
            {
                MessageBox.Show("Вы не ввели значение в одно из обязательных полей");
            }
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 65 || e.KeyChar > 90))
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 65 || e.KeyChar > 90))
                e.Handled = true;
        }
    }
}