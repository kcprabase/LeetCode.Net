using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class LeetCode
    {

        public string AddBinary(string a, string b)
        {
            return "";
        }

        public int[] PlusOne(int[] digits)
        {
            int len = digits.Length;
            int i = len - 1;
            bool extend = false;
            while (i >= 0)
            {
                digits[i] = digits[i] + 1;
                if (digits[i] > 9)
                {
                    extend = true;
                    digits[i] = 0;
                    i--;
                }
                else
                {
                    extend = false;
                    break;
                }
            }
            if (extend)
            {
                int[] newDigits = new int[len + 1];
                int n = 0;
                newDigits[n] = 1;
                n++;
                foreach (int digit in digits)
                {
                    newDigits[n] = digit;
                    n++;
                }
                return newDigits;
            }
            else
            {
                return digits;
            }

        }

        public string Multiply(string num1, string num2)
        {
            return "";
        }

        internal void RomanToInt(string s)
        {
            s = s.ToUpper();
            int len = s.Length;
            int num = 0;
            int i = 0;
            char prev = ' ';
            while (i < len)
            {
                char curr = s[i];
                num += alphabetToInt(curr);
                if (prev == 'I' && (curr == 'V' || curr == 'X'))
                {
                    num -= 2;
                }
                else if (prev == 'X' && (curr == 'L' || curr == 'C'))
                {
                    num -= 20;
                }
                else if (prev == 'C' && (curr == 'D' || curr == 'M'))
                {
                    num -= 200;
                }
                prev = curr;
                i++;
            }
            Console.WriteLine(num);
        }

        private int alphabetToInt(char s)
        {
            switch (s)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: throw new Exception("Invalid character");
            }
        }
    }
}


//Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

//Symbol       Value
//I             1
//V             5
//X             10
//L             50
//C             100
//D             500
//M             1000
//For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

//Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

//I can be placed before V (5) and X(10) to make 4 and 9. 
//X can be placed before L (50) and C(100) to make 40 and 90. 
//C can be placed before D (500) and M(1000) to make 400 and 900.
//Given a roman numeral, convert it to an integer.



//Example 1:

//Input: s = "III"
//Output: 3
//Explanation: III = 3.
//Example 2:

//Input: s = "LVIII"
//Output: 58
//Explanation: L = 50, V = 5, III = 3.
//Example 3:

//Input: s = "MCMXCIV"
//Output: 1994
//Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.


//Constraints:

//1 <= s.length <= 15
//s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
//It is guaranteed that s is a valid roman numeral in the range [1, 3999].