using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaremetxAnagramExercise.Models
{
    interface IAnagram
    {
        public bool AreAnagram(string text1, string text2);

    }
}
