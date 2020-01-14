using System;
using System.Collections.Generic;
using System.Linq;

namespace _52.uzd_GetNonEmptyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Janis", "", "Peteris", "Antons", "", "Andris" };

            PrintArrayValues(names);

            Console.WriteLine("----------------");

            GetNonEmptyArray(names);
        }

        static void PrintArrayValues(string[] names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void GetNonEmptyArray(string[] names)
        {
            var x = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (!string.IsNullOrEmpty(names[i]))
                {
                    ++x;
                }
            }
            string[] nonEmptyNames = new string[x];
            var j = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (!string.IsNullOrEmpty(names[i]))
                {
                    nonEmptyNames[j] = names[i];
                    ++j;
                }
            }
            foreach (var nonEmptyName in nonEmptyNames)
            {
                Console.WriteLine(nonEmptyName);
            }
        }
    }
}
// Definēt programmas sākumā string[] ar vērtībām {“Jānis”, ””, “Pēteris”, “Antons”, “”, “Andris”}. 
// Izveidot metodi GetNonEmptyArray, kura kā paramatru saņem string[] un lietotājam atgriež string[], 
// kurā vairs nav tukšo vērtību. 
// Lai nodemonstrētu GetNonEmptyArray metodes darbību, izmantojiet metodi PrintArrayValues, 
// kura vispirms izdrukā sākotnējā masīva vērtības, bet vēlāk masīvu, kurā vairs nav tukšās vērtības.