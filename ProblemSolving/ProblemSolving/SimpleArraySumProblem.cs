using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving {
    public static class SimpleArraySumProblem {
        
        
        public static int simpleArraySum(int[] ar) {
            int sum = 0;

            foreach(int i in ar) {
                sum += i;
            }

            return sum;

        }



    }
}
