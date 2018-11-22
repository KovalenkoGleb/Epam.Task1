using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.NoPositive
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[,,] BigArray = new int[5, 5, 5];
            Random RandomGenerator = new Random();

            for (int i = 0; i < BigArray.Rank; i++)
            {
                for (int j = 0; j < BigArray.Rank; j++)
                {
                    for (int k = 0; k < BigArray.Rank; k++)
                    {
                        BigArray[i, j, k] = 1;
                    }
                }
            }

            for (int i = 0; i < BigArray.Rank; i++)
            {
                for (int j = 0; j < BigArray.Rank; j++)
                {
                    for (int k = 0; k < BigArray.Rank; k++)
                    {
                        if (BigArray[i, j, k] > 0)
                            BigArray[i, j, k] = 0;
                    }
                }
            }
        }
    }
}
