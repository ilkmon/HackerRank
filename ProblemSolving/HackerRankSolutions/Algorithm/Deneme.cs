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
                        firstString = firstString.Remove(0, 1);
                        firstChar = char.ToUpper(firstChar);

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
        public static int[] jobOffers(int[] scores, int[] lowerLimits, int[] upperLimits) {

            //Sort edilip for ile de yapılabilir.
            //Kod bu haliyle 9- 13 arası testlerde hata vermektedir.


            List<int> matchedCandidatesCountList = new List<int>();
            List<int> scoresList = new List<int>(scores); // Liste yerine yukarıdaki scores kullanılabilir. Dönüştürme işlemine normalde gerek yok.


            for(int i = 0; i < lowerLimits.Length; i++) { //Limit sayısı kadar dönecek

                int matchedCandidatesCount = 0;
                int lowerLimit = lowerLimits[i];
                int upperLimit = upperLimits[i];

                if(upperLimit >= lowerLimit) {  //Bu sorgu kaç adet arada sayı olduğunu getiriyor.
                    matchedCandidatesCount = scoresList.Where(score => {
                        return score >= lowerLimit && score <= upperLimit;
                    }).Count();
                }
                matchedCandidatesCountList.Add(matchedCandidatesCount);
            }

            return matchedCandidatesCountList.ToArray();


        }

        public static List<int> arrangeEquipments(List<int> equipments) {

            //Çözülemedi!
            List<int> arrangedEquipmentsList = new List<int>();
            equipments.Sort();
            int maxValue = equipments.Max();
            arrangedEquipmentsList.Add(maxValue);
            equipments.Remove(maxValue);
            int n = 2;
            int minValue;
            while(equipments.Count() > 0) {
                if(n % 2 == 0) {
                    maxValue = equipments.Max();
                    arrangedEquipmentsList.Add(maxValue);
                    equipments.Remove(maxValue);
                } else {
                    minValue = equipments.Min();
                    arrangedEquipmentsList.Add(maxValue);
                    equipments.Remove(maxValue);
                }

                n++;
            }

            return arrangedEquipmentsList;
        }

        public int Beauty(int[] a, int n) {
            // arrangeEquipments için soruda tanımlanan en yüksek değeri alması istenen fonksiyon.
            if(n == 1) {
                return a[n];
            } else {
                if(n % 2 == 1) {
                    //n MOD 2 =  1 OLMASI DURUMU
                    return Beauty(a, n - 1) * (1 / a[n]);
                } else {
                    //n MOD 2 =  0 OLMASI DURUMU
                    return Beauty(a, n - 1) * a[n];
                }

            }
        }

        public static string isPossible(int a, int b, int c, int d) {
            coordinates goal = new coordinates(c, d);
            coordinates point = new coordinates(a, b);

            int targettedXDifference = goal.X - point.X;
            int targettedYDifference = goal.Y - point.Y;
            return "notcompletedd";


        }
        public class coordinates {
            int x, y;

            public coordinates(int x, int y) {
                this.x = x;
                this.y = y;
            }
            public void moveOnX() {
                this.x = this.x + this.y;
            }
            public void moveOnY() {
                this.y = this.y + this.x;
            }



            public int X { get => x; set => x = value; }
            public int Y { get => y; set => y = value; }
        }

        public static int priceCheck(List<string> products, List<float> productPrices, List<string> productSold, List<float> soldPrice) {

            int countOfWrongPricedItemSolds = 0;

            Dictionary<string, float> priceList = new Dictionary<string, float>();

            //Ürün adları benzersiz olacağından Dictionary ile çözülebiliyor.
            //Dictionarylerde Keyler benzersiz olmalı.

            for(int i = 0; i < products.Count; i++) {
                priceList.Add(products.ElementAt(i), productPrices.ElementAt(i));
                //tüm ürünler dictionary içine priceList(ürünadı, ürünFiyatı) şeklinde dolduruldu.
            }
            for(int i = 0; i < productSold.Count; i++) {
                //Bu for ile her satılan ürün tek tek alındı.
                if(priceList[productSold.ElementAt(i)] != soldPrice.ElementAt(i)) {
                    //PiceList[ürün ismi] bize ürünün fiyatını getirecektir bu aşamada.
                    //ProductSold içerisinde i indisli ürünün adını priceList ürün adı ile fiyat bilgisinin satış fiyatı bilgisine eşitliği kontrol edildi.
                    //Hatalı ile hata sayısı 1 arttırıldı.
                    countOfWrongPricedItemSolds++;
                }
            }
            return countOfWrongPricedItemSolds;
        }
        public static List<string> missingWords(string s, string t) {
            //TestCase 7 de runtime error alıyor.
            List<string> AllWords = new List<string>(Regex.Split(s, @"[\s]+")); //Kelimelerin space ile bölündüğü, başka herhangi bir bölme işareti olmadığı söylenmiş.
            List<string> SubstringWords = new List<string>(Regex.Split(t, @"[\s]+"));
            if(AllWords.Count == SubstringWords.Count) { return AllWords; }

            int AllWordIndex = 0;
            //Eğer bir kelimeyi listeden sildiysek gerideki kelimelere bakmamak gerekiyor.
            //Bu nedenle her döngüde sıfırlanmayan bir Index'e ihtiyaç var.

            foreach(string lookingFor in SubstringWords) {
                //Tüm substringlerin Allwords içerisinde olduğu garanti edilmiş.
                //Tüm substringleri lookingFor olarak alıp, Allwords listesinin devamında olup olmadığını kontrol ediyorum.
                for(; AllWordIndex < AllWords.Count; AllWordIndex++) {

                    if(AllWords.ElementAt(AllWordIndex).Equals(lookingFor)) {
                        //Eğer ındexteki eleman aradığım eleman ise
                        //Bu indexteki elemanı siliyorum. Eleman silindiğinde bir sonraki bakacağım index aynı index olmalı.(Eleman sayısı 1 azaldığından.)
                        //Break index sayısını arttırmadan for döngüsünün kırılmasını ve sonraki substringin alınmasını sağlıyor.
                        AllWords.RemoveAt(AllWordIndex);
                        break;
                    }
                }
            }
            //En son substringlerden temizlenmiş olarak AllWords return ediliyor.
            return AllWords;
        }

        public static string dnaComplement(string s) {
            string result = "";
            foreach(char Ch in s.Reverse()) {
                if(Ch == 'A') {
                    result += 'T';
                } else if(Ch == 'T') {
                    result += 'A';
                } else if(Ch == 'G') {
                    result += 'C';
                } else if(Ch == 'C') {
                    result += 'G';
                }
            }
            return result;
        }
    }



}
