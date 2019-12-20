using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving {
    public class TwoDArrayDSProblem {
        public  int TwoDArrayDS(int[][] arr) {

            int rowLimit = arr.Length - 3; // 3 indexli(4. satır) dan daha aşağıda sol üst köşesi olan bir saat olamayacağından limitliyoruz.
            int columnLimit = arr[0].Length - 3; // 3 indexli(4. sütun) dan daha sağda üst köşesi bulunan bir saat olamayacağından limitliyoruz.
            int maxSum = int.MinValue; //Böylece bulduğumuz her değer maxSum dan daha büyük olacak.

            //Bu for içerisinde saati sol üst köşesinden başlayarak oluşturacağımız için ,
            //Bu sol üst köşelerin koordinatları oluşturuluyor. Ardından Calculate Sum ile toplamı hesaplanıp
            //hesaplanan değer maxSum değişkeni ile karşılaştırılıp eğer büyükse maxSum değerine atanıyor.
            //
            for(int StartRow = 0; StartRow <= rowLimit; StartRow++) {
                for(int StartColumn = 0; StartColumn <= columnLimit; StartColumn++) {
                    int actualSum = CalculateSum(StartRow, StartColumn, arr);
                    if(actualSum > maxSum) { maxSum = actualSum; }
                }
            }
            
            return maxSum;

        }

        /// <summary>
        /// Sol üst köşesi verilen 3x3 lük kum saatinin değerlerini toplayıp geri gönderen metod.
        /// </summary>
        /// <param name="fromRowIndex">Başlangıç Satırı</param>
        /// <param name="fromColumnIndex">Başlangıç Sütunu</param>
        /// <param name="arr">Array</param>
        /// <returns></returns>
        public int CalculateSum(int fromRowIndex, int fromColumnIndex, int[][] arr) {
            int sum = 0;

            for(int i = 0; i < 3; i++) { sum += arr[fromRowIndex][fromColumnIndex + i]; }
            sum += arr[fromRowIndex + 1][fromColumnIndex + 1];
            for(int i = 0; i < 3; i++) { sum += arr[fromRowIndex + 2][fromColumnIndex + i]; }

            return sum;
        }

    }
}
