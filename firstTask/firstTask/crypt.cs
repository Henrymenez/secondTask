using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace firstTask
{
    internal class crypt
    {

        string[] alphabets = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k",
            "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", " " };

        string[] keys = {"£", "*", "%", "&", ">", "<", "!", ")", "\"", "(", "@",
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", " " };

        string[] encryptMap = { };
        string[] decryptMap = { };




        public string encrypt(string word)
        {
            for (int i = 0; i < keys.Length; i++)
            {
                encryptMap[alphabets[i]] = keys[i];
            };
            string text = word.ToLower();
            string encryptedText = "";
            bool isValidText = true;

            for (int i = 0; i < text.Length; i++)
            {
                char charAt = text[i];

                if (!alphabets.Contains(charAt))
                {
                    isValidText = false;
                    break;
                };
                encryptedText += encryptMap[charAt];
            }

            return isValidText ? encryptedText : text;
        }


        public string  decrypt(string[] key)
        {
            for (int i = 0; i < keys.Length; i++)
            {
                decryptMap[keys[i]] = alphabets[i];
            };
            string decyptedText = "";
            bool isValidCrypt = true;
            string text = "";

            for (int i = 0; i < key.Length; i++)
            {
                char charAt = key[i];

                if (!keys.Contains(charAt))
                {
                    isValidCrypt = false;
                    break;
                };
                decyptedText += decryptMap[charAt];
            }

            return isValidCrypt ? decyptedText : text;
        }

       

            }
        }


   