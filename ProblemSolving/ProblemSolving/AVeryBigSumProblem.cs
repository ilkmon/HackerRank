using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving {
    public static class AVeryBigSumProblem {

        public static long aVeryBigSum(long[] ar) {
            long result = 0;
            foreach(long element in ar) {
                result = result + element;

            }
            return result;
        }
    }
}
