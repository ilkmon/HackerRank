using InterviewPreparationKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparationKit {
    static class RunInterviewPreparationKitMethods {
        public static void Run() {
            RunArraysLeftRotation();
            RunMinimumSwaps2();
        }

        public static void RunArraysLeftRotation() {
            int[] a = { 41, 73, 89, 7, 10, 1, 59, 58, 84, 77, 77, 97, 58, 1, 86, 58, 26, 10, 86, 51 };
            int d = 30;
            Console.Write("Arrays Left Rotation Input: ");
            foreach(int element in a) {
                Console.Write(element + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Array Elements Will Push " + d + " Times To Left.");
            Console.Write("Arrays Left Rotation Output: ");

            foreach(int element in ArraysLeftRotationProblem.ArraysLeftRotation(a, d)) {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
        public static void RunMinimumSwaps2() {
            int[] arr = { 1, 3, 5, 2, 4, 6, 7 };
            //beklenen cevap 3
            Console.Write("Minimum Swaps 2 Output: ");
            Console.WriteLine(MinimumSwaps2Problem.MinimumSwaps(arr).ToString());



        }

    }
}
