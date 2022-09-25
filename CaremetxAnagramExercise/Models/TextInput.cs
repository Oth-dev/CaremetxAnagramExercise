using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaremetxAnagramExercise.Models
{
    public class TextInput : IAnagram
    {
        public string text1 { get; set; }
        public string text2 { get; set; }
        public TextInput(string text1, string text2)
        {
            this.text1 = text1;
            this.text2 = text2;
        }
        public TextInput()
        {
        }
        public bool AreAnagram(string text1, string text2)
        {
            //check the length of both texts 
            //Space matters : 'listen' and 's ilent' are not Anagrams but 'listen' and 'silent' are Anagrams
            if(text1.Length!=text2.Length)
            {
                return false;
            }
            else
            {
                //Converting the string to an array of char and all in lower case
                char[] array1 = text1.ToLower().ToCharArray();
                char[] array2 = text2.ToLower().ToCharArray();

                //Sort both Arrays
                Array.Sort(array1);
                Array.Sort(array2);

                //Convert the Array of char to a string
                string resultString1 = new string(array1);
                string resultString2 = new string(array2);

                if (resultString1 == resultString2)
                    return true;
                else
                    return false;
            }
           
        }
        public bool AreAnagram()
        {
            //check the length of both texts
            //Space matters : 'listen' and 's ilent' are not Anagrams but 'listen' and 'silent' are Anagrams

            if (this.text1.Length != this.text2.Length)
            {
                return false;
            }
            else
            {
                //Converting the string to an array of char and all in lower case
                char[] array1 = this.text1.ToLower().ToCharArray();
                char[] array2 = this.text2.ToLower().ToCharArray();

                //Sort both Arrays
                Array.Sort(array1);
                Array.Sort(array2);

                //Convert the Array of char to a string
                string resultString1 = new string(array1);
                string resultString2 = new string(array2);

                if (resultString1 == resultString2)
                    return true;
                else
                    return false;
            }
        }
    }
}
