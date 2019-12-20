using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparationKit {
    class ArraysLeftRotationProblem {
        public static int[] ArraysLeftRotation(int[] a, int d) {
            d = d % a.Length;  // Eğer bir tesbihte 99 defa ileri gidersem başa geri dönerim. Bu nedenle uzunluğa göre mod aldım.
            List<int> resultList = new List<int>(); //Listenin Add ve Remove özelliklerini kullanabilmek için Liste oluşturdum.
            resultList = a.OfType<int>().ToList(); //Ve bu listenin içerisine elemanları arrayden alarak attım.

            // Döngü d sefer gerçekleşmekte ve her seferinde
            // En baştaki elemanın bir kopyası listenin sonuna eklenmekte. {1,2,3,4} --> {1,2,3,4,1}
            // Daha sonra en baştaki eleman silinmekte. {1,2,3,4,1} --> {2,3,4,1}
            for(; d > 0; d--) {
                resultList.Add(resultList.ElementAt(0));
                resultList.Remove(resultList.ElementAt(0));
            }

            //Liste Array e çevrilerek return edilmekte.
            return resultList.ToArray();


        }
    }
}
