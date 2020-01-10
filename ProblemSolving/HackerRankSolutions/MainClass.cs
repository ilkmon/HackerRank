using ProblemSolving;
using InterviewPreparationKit;
using System;
using System.Collections.Generic;
using ProblemSolving.Algorithm;

namespace HackerRankSolutions {
    class MainClass {

        static void Main() {
            /*RunProblemSolvingMethods.Run();
            RunInterviewPreparationKitMethods.Run();
            */
            List<int> arrangelist= new List<int>();
            arrangelist.Add(4);
            arrangelist.Add(1);
            arrangelist.Add(2);
            arrangelist.Add(3);
            arrangelist.Add(4);
            Deneme.arrangeEquipments(arrangelist);

            Console.WriteLine("Press a button to exit.");
            Console.ReadLine(); //Ekranın hemen kapanmaması için.
        }



        


    }


}
