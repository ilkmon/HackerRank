using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProblemSolving.Algorithm {
    public class Deneme {


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

            int minDivisor = 1;

            for(int i = 2; i < n && i < int.MaxValue; i++) {
                if(n % i == 0 && i != n) {
                    minDivisor = i;
                    break;
                }
            }

            return minDivisor;
        }
        public static string arrange(string sentence) {

            //Deneme.arrange("1 One, 2 Two, 3 Three i.s good.");

            String lowerCaseSentence = sentence.ToLower(); //Gelen cümlenin tamamı lowercase'e çevrilir.
            String[] words = Regex.Split(lowerCaseSentence, @"[\s\t\n\b\e\,\.]+"); //Regex ile boşluk, tab, newline, backspace, empty nokta ve virgüller ayraç kabul edilerek split edildi.


            /*
             Bildiğimiz select yapısı yerler farklı biraz.
             words arrayinin değişkenlerini word adında al.
             ordeby ile uzunluklarına göre sırala
             tümünü selectleyip ekle.

             */
            IOrderedEnumerable<string> arrangedWords = from word in words
                                                       orderby word.Length
                                                       select word;
            string result = ""; //Result boş atanır.

            foreach(var word in arrangedWords) {

                if(word != "") {
                    if(result == "") {
                        //Eğer result stringi boş ise gelen kelime ilk kelime demektir.
                        //İlk kelime büyük harfle başlamalı
                        string firstString = word;
                        char firstChar = firstString.First();
                        firstChar = char.ToUpper(firstChar);
                        firstString = firstString.Remove(0, 1);
                        firstString = firstChar + firstString;
                        result = firstString;
                        //Eğer result a eşitlememiş ve contiune kullanmamış olsaydık 
                        //İlk kelime öncesinde aşağıdaki result +" " şeklindeki ifadeden dolayı cümle başında boşluk oluşacaktı.
                        //Bu nedenle result içeriğine ilk kelimeyi yazdık ve continue ile foreach döngüsünün bu işlemi burada bırakarak bir sonraki kelimeden
                        //devam etmesini sağladım.
                        continue;

                    }

                    result = result + " " + word;
                }
            }

            //Soruda cümlenin sonunda nokta istenmiş son olarak onu ekleyip dönüşü gerçekleştirdim.
            result = result + ".";
            return result;

        }
    }
}
