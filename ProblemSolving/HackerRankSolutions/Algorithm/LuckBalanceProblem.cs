using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Algorithm {



    public static class LuckBalanceProblem {
        static int luckBalance(int k, int[][] contests) {

            return LuckBalance(k, contests);


        }

        public static int LuckBalance(int k, int[][] contests) {

            List<int> importantContestPoints = new List<int>();
            int points=0;

            foreach(var element in contests) {
                if(element[1] == 1) {
                    importantContestPoints.Append(element[0]);
                } else {
                    points+=element[1];
                }
                
            }
            // importantContestPoints.Sort();
            if(k > importantContestPoints.Count()) {
                k = importantContestPoints.Count();
            }
            importantContestPoints.Sort();
            for(; k > 0; k--) {
                points += importantContestPoints[k-1];
                
            }

            return points;
        }
    }
}
