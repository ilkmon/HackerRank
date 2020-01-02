using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.InterviewPreparationKit {
    class HashTablesRansomNoteProblem {
        public void checkMagazine(string[] magazine, string[] note) {
            CheckMagazine(magazine, note);
        }

        public static void CheckMagazine(string[] magazine, string[] note) {

            bool canReplicate = true;

            var wordCounts = new Dictionary<string, int>(); //İnitiliaze a Dictionary to keep words as keys and counts as ints. 
            foreach(string magazineWord in magazine) {
                if(!wordCounts.ContainsKey(magazineWord)) {
                    wordCounts.Add(magazineWord, 1); //Elimizde olduğundan 1 olarak eklenmesi gerekmekte.
                } else {
                    wordCounts[magazineWord] = wordCounts[magazineWord] + 1;
                }

            }
            foreach(string noteWord in note) {

                if(wordCounts.ContainsKey(noteWord) && canReplicate) {
                    if(wordCounts[noteWord] <= 0) {
                        canReplicate = false;
                        break; //Breaks if out of word.
                    } else {
                        wordCounts[noteWord] = wordCounts[noteWord] - 1;
                    }
                } else {
                    canReplicate = false;
                    break;
                    //Breaks if cant find the any given word. 
                    //Bir kelime bulunamadığında döngünün durdurulması gerekmekte.
                }

            }

            if(canReplicate) {
                Console.WriteLine("Yes");
            } else {
                Console.WriteLine("No");
            }

        }

    }
}
