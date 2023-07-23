using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Numerals_HelperI_to_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string romanNumeral = "DM";
            int n = 0;
            int[] roman = { 1000, 500, 100, 50, 10, 5, 1 };
            char[] arab = { 'M', 'D', 'C', 'L', 'X', 'V', 'I'};

            for (int i = 0; i < romanNumeral.Length - 1; i++)
            {
                //MDCLXVI
                if (romanNumeral[i] == arab[0]) n += roman[0];
                if (romanNumeral[i] == arab[1])
                {
                    if (romanNumeral[i + 1] == arab[0]) n -= roman[1]; 
                    else n += roman[1];
                } 

                for (int j = 2; j < roman.Length; j++)
                {
                    if (romanNumeral[i] == arab[j]) { 
                        if (romanNumeral[i + 1] == arab[j - 1] | romanNumeral[i + 1] == arab[j - 2])      n -= roman[j]; 
                        else n += roman[j]; 
                    }
                }
                

            }
            for (int j = 0; j < roman.Length; j++)
            {
                if (romanNumeral[romanNumeral.Length - 1] == arab[j]) n += roman[j];
            }
            
            /*for (int i = 0; i < romanNumeral.Length - 1; i++)
            {
                //MDCLXVI
                switch (romanNumeral[i])
                {
                    case 'D': if (romanNumeral[i + 1] == 'M') n -= 500; else n += 500; break;
                    case 'M': n += 1000; break;
                    case 'I': if (romanNumeral[i + 1] == 'V' | romanNumeral[i + 1] == 'X') n -= 1; else n += 1; break;
                    case 'V': if (romanNumeral[i + 1] == 'X' | romanNumeral[i + 1] == 'L') n -= 5; else n += 5; break;
                    case 'X': if (romanNumeral[i + 1] == 'L' | romanNumeral[i + 1] == 'C') n -= 10; else n += 10; break;
                    case 'L': if (romanNumeral[i + 1] == 'C' | romanNumeral[i + 1] == 'D') n -= 50; else n += 50; break;
                    case 'C': if (romanNumeral[i + 1] == 'S' | romanNumeral[i + 1] == 'M') n -= 100; else n += 100; break;
                    
                    default:
                        break;
                }
            }
            int j = romanNumeral.Length - 1;
            if (romanNumeral[j] == 'I') n += 1;
            if (romanNumeral[j] == 'V') n += 5;
            if (romanNumeral[j] == 'X') n += 10;
            if (romanNumeral[j] == 'L') n += 50;
            if (romanNumeral[j] == 'C') n += 100;
            if (romanNumeral[j] == 'S') n += 500;
            if (romanNumeral[j] == 'M') n += 1000;
*/
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
