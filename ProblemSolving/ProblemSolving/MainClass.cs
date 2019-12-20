using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving {
    class MainClass {

        static void Main(string[] args) {
            RunCompareTheTripletsProblem();
            RunSimpleArraySumProblem();
            RunAVeryBigSumProblem();
            RunPlusMinusProblem();
            RunTwoDArrayDSProblem();

            Console.WriteLine("Press a button to exit. ");
            Console.ReadLine(); //Ekranın hemen kapanmaması için.
        }

        public static void RunCompareTheTripletsProblem() {

            List<int> firstList = new List<int> { 17, 28, 30 };
            List<int> secondtList = new List<int> { 99, 16, 8 };

            Console.Write("Compare The Triplets Output: ");
            foreach(int element in CompareTheTripletsProblem.compareTriplets(firstList, secondtList)) {
                Console.Write(element.ToString() + " ");
            }
            Console.WriteLine(); //Write komutu ile yazdırdığımdan alt satıra geçmedi, sonrasının alt satırdan devam etmesi için yazdım.


        }
        public static void RunSimpleArraySumProblem() {
            int[] ar = { 1, 2, 3, 4, 10, 11 };
            int result = SimpleArraySumProblem.simpleArraySum(ar);
            Console.Write("Simple Array Sum Problem Output: ");
            foreach(int element in ar) {
                Console.Write(element + " ");
            }
            Console.WriteLine(); //Write komutu ile yazdırdığımdan alt satıra geçmedi, sonrasının alt satırdan devam etmesi için yazdım.
        }
        public static void RunAVeryBigSumProblem() {
            long[] ar = { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };

            Console.WriteLine("A Very Big Sum Problem Output: " + AVeryBigSumProblem.aVeryBigSum(ar));


        }
        public static void RunPlusMinusProblem() {
            int[] arr = { -4, 3, -9, 0, 4, 1 };
            Console.WriteLine("Plus Minus Problem Output(Next 3 Rows, Negative, Positive and Zero Ratios): ");
            PlusMinusProblem.plusMinus(arr);
        }
        public static void RunTwoDArrayDSProblem() {
            //Bu şekilde doldurmak zorunda kaldım, çünki C deki gibi doldurmama izin vermedi.

            int[][] arr = new int[6][];
            int[] first = { 1, 1, 1, 0, 0, 0 };
            int[] second = { 0, 1, 0, 0, 0, 0 };
            int[] third = { 1, 1, 1, 0, 0, 0 };
            int[] fourth = { 0, 0, 2, 4, 4, 0 };
            int[] fifth = { 0, 0, 0, 2, 0, 0 };
            int[] sixth = { 0, 0, 1, 2, 4, 0 };
            arr[0] = first;
            arr[1] = second;
            arr[2] = third;
            arr[3] = fourth;
            arr[4] = fifth;
            arr[5] = sixth;


            TwoDArrayDSProblem ProblemRunner = new TwoDArrayDSProblem();

            Console.WriteLine("2D Array - DS Problem Output: " + ProblemRunner.TwoDArrayDS(arr));



        }


    }


}
