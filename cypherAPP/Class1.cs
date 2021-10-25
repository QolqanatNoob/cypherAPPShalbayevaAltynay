using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cypherAPP
{
    class CaesarEnc

    {
        private static string doEncryption(string words,int shiftNo)
        {
            char[] buffer = words.ToCharArray();
            for (int i=0; i < buffer.Length; i++)
            {
                //каждая буква по отдельности будет заменена
                char letter = buffer[i];
                letter = (char)(letter + shiftNo);
                if (letter > 'я')
                {
                    letter = (char)(letter - 33);

                }
                else if (letter < 'а')
                {
                    letter = (char)(letter + 33);
                }
                buffer[i] = letter;
            }
            return new string(buffer);
        }


    }
}
