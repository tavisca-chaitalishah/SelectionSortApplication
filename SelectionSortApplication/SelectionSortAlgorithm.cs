using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSortApplication
{
   public class SortingController
    {
       public int[] SelectionSortLogic(int[] selectionSortArray, int noOfElementInArray)
        {
            int minimunValue;

            for(int index = 0; index < noOfElementInArray; index++)
            {
                minimunValue = index;
                for(int nextIndex = index + 1; nextIndex < noOfElementInArray; nextIndex++)
                {
                    if(selectionSortArray[nextIndex] < selectionSortArray[minimunValue])
                    {
                        minimunValue = nextIndex;
                    }
                }
                if(minimunValue != index)
                {
                   
                    SwapNum(ref selectionSortArray[index],ref selectionSortArray[minimunValue]);
                }
            }


            return selectionSortArray;

          
        }
        void SwapNum(ref int fristNumber, ref int secondNumber)
        {

            int tempswap = fristNumber;
            fristNumber = secondNumber;
            secondNumber = tempswap;
        }
        public void DisplayArray(int[] selectionSortArray,int noOfElementInArray)
        {
            Console.WriteLine("Sorted Array\n");
            for (int iterator = 0; iterator < noOfElementInArray; iterator++)
            {
                Console.Write(" " + selectionSortArray[iterator]);
            }
        }
    }
}
