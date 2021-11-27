using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDotComApp.Model
{
    class SimpleDotCom
    {
        int[] locationCells;
        int numOfHits = 0;
        int cell = 0;

        public void setLocationCells (int[] locs)
        {
           locationCells = locs;
        }
        public String checkYourself(String stringGuess)
        {
            int guess = Int32.Parse(stringGuess);
            String result = "miss";
            for (cell : Convert.ToInt32(locationCells)) 
            {
                if (guess == cell)
                {
                    result = "hit";
                    numOfHits ++;
                    break;
                }
            }
            if (numOfHits == locationCells.Length)
            {
                result = "kill";
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
