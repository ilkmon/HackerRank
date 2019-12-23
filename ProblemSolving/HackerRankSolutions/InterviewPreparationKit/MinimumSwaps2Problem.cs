using System.Collections.Generic;
using System.Linq;

namespace InterviewPreparationKit {
    public static class MinimumSwaps2Problem {

        public static int minimumSwaps(int[] arr) {
            return MinimumSwaps(arr);
        }

        public static int MinimumSwaps(int[] arr) {
            int swapCounter = 0;
            int firstValue = arr.Min(); //Arrayin ardışık sayılardan oluştuğu bilgisi verilmiş, Bu nedenle başa gelecek sayıyı bilebiliyoruz.
            int arrayLength = arr.Length;

            List<int> differences = new List<int>();


            for(int i = 0; i < arrayLength; i++) {
                differences.Add(arr[i] - (firstValue + i));
            }

            for(int i = 0; i < differences.Count - 1; i++) {

                //&& differences[i + differences[i]] < 0  && differences[i] == Math.Abs(differences[i + differences[i]])
                if(differences[i] == -1 * (differences[i + differences[i]]) && differences[i] > 0 && i + differences[i] < arrayLength) {
                    swapCounter++;
                    SwapByIndexes(arr, i, (i + differences[i]));
                }


            }

            for(int i = 0; i < arrayLength - 1; i++) {
                // Son elemana bakmamıza gerek yok zaten baştan sona kadar düzelttiysek son elemanın gidebileceği başka bir yer yok :) 
                int exceptedValue = firstValue + i;

                if(arr[i] != exceptedValue) {
                    SwapBy1stElementIndex_2ndElementValue(arr, i, exceptedValue);
                    swapCounter++;
                }
            }
            return swapCounter;
        }


        public static void SwapBy1stElementIndex_2ndElementValue(int[] arr, int firsElement, int secondElementsValue) {
            int secondElement = FindElementIndexByValue(arr, secondElementsValue, firsElement);
            SwapByIndexes(arr, firsElement, secondElement);
        }

        public static void SwapByIndexes(int[] arr, int firsElementIndex, int secondElementIndex) {
            int temp = arr[firsElementIndex];
            arr[firsElementIndex] = arr[secondElementIndex];
            arr[secondElementIndex] = temp;
        }

        public static int FindElementIndexByValue(int[] arr, int secondElementsValue, int fromIndex) {
            fromIndex++;

            for(; fromIndex < arr.Length; fromIndex++) {
                if(arr[fromIndex] == secondElementsValue) {
                    return fromIndex;
                }

            }
            return -1;
        }

































    }
}
