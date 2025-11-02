using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher_Alg
{
    internal class Caesar
    {
        Caesar()
        { }

        public static string caesarCipher(string text,int key)
        {
            string arabic = "ابتثجحخدذرزسشصضطظعغفقكلمنهويإأؤءئ ";
            string english = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int alen = arabic.Length;
            int elen = english.Length;
            string result = "";

            foreach (char c in text)
            {
                if (arabic.Contains(c.ToString()))
                {
                    int index = arabic.IndexOf(c);
                    int newindex = (index + key) % alen;
                    if (newindex < 0)
                        newindex += alen;
                    result += arabic[newindex];
                }
                else if(char.IsUpper(c))
                {
                    int index = english.IndexOf(c);
                    int newindex = (index + key) % elen;
                    if (newindex < 0)
                        newindex += elen;
                    result += english[newindex];
                }
                else if (char.IsLower(c))
                {
                    int index = english.ToLower().IndexOf(c);
                    int newindex = (index + key) % elen;
                    if (newindex < 0)
                        newindex += elen;
                    result += english[newindex];
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }
    }
}
