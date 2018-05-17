using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SortingListOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sortingList = new List<int> { 1, 3, 2, 8, 5, 3, 4 };
            sortingList.Sort();
            foreach (int x in sortingList)
            {
                Write(x);
            }
            ReadKey();
        }
    }
}
