using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.InterviewPreparationKit {
    public class SherlockAndAnagramsProblem {
        int sherlockAndAnagrams(string s) {
            return SherlockAndAnagrams(s);
        }


        public int SherlockAndAnagrams(string s) {

            var charCounts = new Dictionary<string, int>(); //İnitiliaze a Dictionary to keep chars as keys and counts as ints. 


            int maxStringLength = s.Length;

            for(int substringLength = 1; substringLength <= maxStringLength; substringLength++) {
                for(int fromIndex = 0; fromIndex < maxStringLength - substringLength; fromIndex++) {
                    char[] substringAsCharacters = s.Substring(fromIndex, substringLength).ToCharArray();
                    Array.Sort(substringAsCharacters);
                    string substringAsSortedString = substringAsCharacters.ToString();

                    if(!charCounts.ContainsKey(substringAsSortedString)) {
                        charCounts.Add(substringAsSortedString, 1);
                    } else {
                        charCounts[substringAsSortedString] = charCounts[substringAsSortedString] + 1;
                    }
                }
            }

            /*//Count similar chars in  string.
            foreach(char character in s.ToCharArray()) {

                if(!charCounts.ContainsKey(character)) {
                    charCounts.Add(character, 1); //Elimizde olduğundan 1 olarak eklenmesi gerekmekte.
                } else {
                    charCounts[character] = charCounts[character] + 1;
                }
            }*/

            int anagramCounts = 0;
            /*            foreach(int charCount in charCounts.Values) {
                            anagramCounts += (charCount * (charCount - 1))/2; // Matematiksel formül 
                        }*/

            foreach(var element in charCounts.Values) {
                if(element > 1) {
                    anagramCounts += element;
                }
            }

            return anagramCounts;
        }
    }
}
