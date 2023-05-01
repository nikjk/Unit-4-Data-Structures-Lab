using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_4___Data_Structures_Lab
{
    public class ReverseWord
    {
        public ReverseWord(string input)
        {
            char[] inputCharArray = input.ToCharArray();
            Array.Reverse(inputCharArray);
            foreach (char c in inputCharArray)
            {
                Console.Write(c);
            }
        }
    }
}
