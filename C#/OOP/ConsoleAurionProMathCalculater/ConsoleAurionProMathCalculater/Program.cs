using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AurionProMathCalculator;

namespace ConsoleAurionProMathCalculater
{
    class Program
    {
        static void Main(string[] args)
        {
            Model M1 = new Model();
            CaseStudy1(M1);
            CaseStudy2(M1);
            CaseStudy3(M1);
            Console.ReadLine();
        }

        private static void CaseStudy1(Model m1)
        {
            {
                if (m1.CheckPrimeNumber(23) == true)
                {
                    Console.WriteLine("The number is prime ");
                }
                else
                {
                    Console.WriteLine("The number is not Prime");
                }
            }
        }

        private static void CaseStudy2(Model m1)
        {
            int limit = 50;
            int[] evenArray = m1.GenerateEvenNo(limit);
            Console.WriteLine("Even NO till {0}", limit);
            foreach (int i in evenArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" ");
        }

        private static void CaseStudy3(Model m1)
        {
            {
                int limit = 50;
                int[] primeArray = m1.GeneratePrimeNo(limit);
                Console.WriteLine("prime NO till {0}", limit);

                foreach (int i in primeArray)
                {
                    if (i == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write(i + " ");
                    }

                }
                Console.WriteLine(" ");
            }
        }
    }
}
