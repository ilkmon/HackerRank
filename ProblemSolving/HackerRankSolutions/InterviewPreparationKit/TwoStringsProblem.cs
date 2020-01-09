using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.InterviewPreparationKit {
    public static class TwoStringsProblem {

        public static string twoStrings(string s1, string s2) {
            return TwoStrings(s1, s2);

        }

        public static string TwoStrings(string s1, string s2) {

            HashSet<char> charSetofs1 = new HashSet<char>(s1.ToCharArray());
            HashSet<char> charSetofs2 = new HashSet<char>(s2.ToCharArray());
            //HashSetler içerisinde aynı elemandan iki adet olmaz. Bu nedenle arama işlemlerinde yüksek performans sağlarlar.


            //İki kümenin kesişimi 0 dan fazla elemana sahipse koşulumuza uyacağından Yes, eğer kesişimin eleman sayısı 0 ise No stringi return etmekte.
            if(charSetofs1.Intersect(charSetofs2).Count() > 0) {
                return "YES";
            } else {
                return "NO";
            }

        }

    }
}
