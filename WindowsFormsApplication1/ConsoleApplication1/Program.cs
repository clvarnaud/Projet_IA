using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> liste_possibilites = new List<String>();
            liste_possibilites= Permutation("","AZERTYUA");
            foreach (var mots in liste_possibilites)
            {
                Console.WriteLine(mots);
            }
            
                Console.ReadLine();
            }
        private static List<String> Permutation(string soFar, string input)
        {
            List<String> liste_possibilites = new List<String>();
            if (string.IsNullOrEmpty(input))
            {

                liste_possibilites.Add(soFar);
                return liste_possibilites;
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {

                    string remaining = input.Substring(0, i) + input.Substring(i + 1);
                    Permutation(soFar + input[i], remaining);
                }
            }
            return liste_possibilites;
        }
    }
    }
}
