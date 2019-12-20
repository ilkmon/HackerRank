using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving {
    public static class CompareTheTripletsProblem {

        public static List<int> compareTriplets(List<int> a, List<int> b) {
            List<int> result = new List<int> { 0, 0 };
            //   result.Add(0);//a Liste oluştururken parantez ile ekeleme yapılabiliyormuş.
            //   result.Add(0);//b  Liste oluştururken parantez ile ekeleme yapılabiliyormuş.
            for(int i = 0; i < 3; i++) {
                if(a[i] > b[i]) result[0] = result[0] + 1;
                if(a[i] < b[i]) result[1] = result[1] + 1;
            }

            return result;
        }



    }
}
