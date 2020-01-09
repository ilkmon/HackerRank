using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Algorithm {
    class Deneme {


        public int CountNonUniqueElements(List<int> numbers) {

            var elementCounts = new Dictionary<int, int>();


            //Count similar chars in  string.
            foreach(int theNumber in numbers) {
                if(!elementCounts.ContainsKey(theNumber)) {
                    elementCounts.Add(theNumber, 1);
                    //Elimizde olduğundan 1 olarak eklenmesi gerekmekte.
                } else {
                    elementCounts[theNumber] = elementCounts[theNumber] + 1;
                }
            }

            int uniqueCounter = 0;

            foreach(int element in elementCounts.Values) {
                if(element > 1) {
                    uniqueCounter++;
                }

            }
            return uniqueCounter;


        }
        public int fourthBit(int number) {
            //1 test casete patlıyor.
            if(number < 8) {
                return 0;
            }

            string binary = Convert.ToString(number, 2);

            if(binary[binary.Length - 3] == '0') {
                return 0;

            } else {

                return 1;
            }




        }
        public int isPrime(long n) {

            int maxDivisor = 1;

            for(long i = n - 1; i > 1; i--) {
                if(n % i == 0) {
                    maxDivisor = (int)i;
                    break;
                }
            }
            return maxDivisor;
        }
    }
}
