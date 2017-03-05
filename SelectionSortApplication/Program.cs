using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSortApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int noOfElementInArray;
            
            Console.WriteLine("Enter the No. of Elements you want for selection Sort");
            noOfElementInArray = Convert.ToInt32(Console.ReadLine());
            int[] selectionSortArray = new int[noOfElementInArray];
            Console.WriteLine("Enter the Elements in array");
            for (int iterator = 0; iterator < noOfElementInArray; iterator++)
            {
                selectionSortArray[iterator] = Convert.ToInt32(Console.ReadLine());
            }

            SortingController selectionObject = new SortingController();
            int[] sortedArray = selectionObject.SelectionSortLogic(selectionSortArray, noOfElementInArray);
            selectionObject.DisplayArray(sortedArray, noOfElementInArray);
            Console.WriteLine("\n\nThankyou\n\n Press any key to Exit the Apllication...");
            Console.ReadLine();
        }
    }
}
