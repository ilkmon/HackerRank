using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving {
    public class SimpleArraySumProblem {
        
        
        public static int SimpleArraySum(int[] ar) {
            int sum = 0;

            foreach(int i in ar) {
                sum += i;
            }

            return sum;

        }



    }
}
