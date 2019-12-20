using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving {
    public class AVeryBigSumProblem {

        public static long AVeryBigSum(long[] ar) {
            long result = 0;
            foreach(long element in ar) {
                result = result + element;

            }
            return result;
        }
    }
}
