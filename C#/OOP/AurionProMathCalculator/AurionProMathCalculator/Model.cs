using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AurionProMathCalculator
{
    public class Model
    {
        public bool CheckPrimeNumber(int number)
        {
            {
                int i, m = 0, flag = 0;
                m = number / 2;

                for (i = 2; i <= m; i++)
                {
                    if (number % i == 0)
                    {
                        flag = 1;
                        break;
                    }
                }

                if (flag == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

            //[MyUnitTestMethod]
            public int[] GenerateEvenNo(int limit)
            {
                int[] evenNoArray = new int[limit / 2 + 1];
                int evenNo = 0;
                for (int i = 0; i <= limit / 2; i++)
                {
                    evenNoArray[i] = evenNo;
                    evenNo += 2;
                }
                return evenNoArray;
            }

        public int[] GeneratePrimeNo(int limit)
        {
            int loop = 1;
            int primeCount = 0;
            int[] primeArray = new int[limit / 2];
            while (loop != limit)
            {
                if (CheckPrimeNumber(loop) == true)
                {
                    primeArray[primeCount] = loop;
                    primeCount++;
                    loop++;
                }
                else
                {
                    loop++;
                }
            }
            return primeArray;
        }
    }
    
}
