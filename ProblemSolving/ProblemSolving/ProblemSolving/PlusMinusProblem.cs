using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving {
    public class PlusMinusProblem {
        /// <summary>
        /// Pozitif, negatif ve 0 sayısı adetlerinin tüm sayılara opranını ekrana bastırması istenmiş.
        /// Bunu yaparken Noktadan sonra 6 hane olması gerektiği belirtilmiş.
        /// </summary>
        /// <param name="arr"></param>
        public static void PlusMinus(int[] arr) {
            float negativeElementsCount = 0, positiveElementsCount = 0, zeroElementsCount = 0;
            float arrayLength = arr.Length;

            foreach(int e in arr) {
                if(e > 0) positiveElementsCount++;
                if(e < 0) negativeElementsCount++;
                if(e == 0) zeroElementsCount++;
            }
            //Noktadan sonra 6 hane olması gerektiği için {0:F6} şeklinde noktadan sonra yazdıracağı rakam sayısını veriyoruz.
            Console.WriteLine("{0:F6}", negativeElementsCount / arrayLength);
            Console.WriteLine("{0:F6}", positiveElementsCount / arrayLength);
            Console.WriteLine("{0:F6}", zeroElementsCount / arrayLength);
        }

    }
}
