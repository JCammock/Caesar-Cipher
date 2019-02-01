using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    class Encryption
    {
        private string unencrypted;

        public void SetUnencrypted(string unencrypted)
        {
            this.unencrypted = unencrypted;
        }

        public string Encrypt(int shift)
        {
            char[] buffer = unencrypted.ToCharArray();
            for(int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                letter = (char)(letter + shift);
                if (letter > 'z')
                {
                    letter = (char)(letter - 26);
                }
                else if (letter < 'a')
                {
                    letter = (char)(letter + 26);
                }
                buffer[i] = letter;
            }
            return new string(buffer);

        }
    }
}
