using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using BSTNS;

namespace Ex09Mon_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
            #region Binary/Linear Search

            //int smallSize = 1000;
            //int largeSize = smallSize * 10;

            //ClubMember[] smallLinear = new ClubMember[smallSize];
            //ClubMember[] largeLinear = new ClubMember[largeSize];

            //ClubMember[] smallBinary = new ClubMember[smallSize];
            //ClubMember[] largeBinary = new ClubMember[largeSize];

            //for (int i = 0; i < smallSize; i++)
            //{
            //    smallLinear[i] = CMFactory.GetClubMember();
            //    smallBinary[i] = CMFactory.GetClubMember();
            //}
            //for (int i = 0; i < largeSize; i++)
            //{
            //    largeLinear[i] = CMFactory.GetClubMember();
            //    largeBinary[i] = CMFactory.GetClubMember();
            //}

            //long SLtime = SearchLinear(smallLinear);
            //Console.WriteLine("SearcLinear(smallLinear): " + SLtime + "ms");
            //long LLtime = SearchLinear(largeLinear);
            //Console.WriteLine("SearcLinear(largeLinear): " + LLtime + "ms");


            //smallBinary = PerformInsertionSort(smallBinary);
            //largeBinary = PerformInsertionSort(largeBinary);
            //BinarySearch(smallBinary);
            //BinarySearch(largeBinary);

            #endregion
            ////MyList x = new MyList();

            ////for (int i = 0; i < 10000; i++)
            ////{
            ////    x.Insert(CMFactory.GetClubMember());
            ////}

            BST bst = new BST();
            
            bst.Insert(20);
            bst.Insert(10);
            bst.Insert(5);
            bst.Insert(15);
            bst.Insert(30);
            
            bst.PrintTree();

            Console.Read();
        }

        public void BinarySearch(ClubMember[] arr)
        {
            Stopwatch timer = new Stopwatch();
            Random rand = new Random();
            ClubMember cm1 = (ClubMember)arr[rand.Next(arr.Length)];
            ClubMember cm2 = (ClubMember)arr[rand.Next(arr.Length)];
            ClubMember cm3 = (ClubMember)arr[rand.Next(arr.Length)];

            timer.Start();

            for (int j = 0; j < 1000; j++)
            {
                Array.BinarySearch(arr, cm1);
                Array.BinarySearch(arr, cm2);
                Array.BinarySearch(arr, cm3);
            }

            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds);
        }

        public static ClubMember[] PerformInsertionSort<ClubMember>(ClubMember[] inputarray, Comparer<ClubMember> comparer = null)
        {
            var equalityComparer = comparer ?? Comparer<ClubMember>.Default;
            for (var counter = 0; counter < inputarray.Length - 1; counter++)
            {
                var index = counter + 1;
                while (index > 0)
                {
                    if (equalityComparer.Compare(inputarray[index - 1], inputarray[index]) > 0)
                    {
                        var temp = inputarray[index - 1];
                        inputarray[index - 1] = inputarray[index];
                        inputarray[index] = temp;
                    }
                    index--;
                }
            }
            return inputarray;
        }


        public long SearchLinear(IComparable[] arr)
        {
            Stopwatch timer = new Stopwatch();
            Random rand = new Random();
            ClubMember cm1 = (ClubMember)arr[rand.Next(arr.Length)];
            ClubMember cm2 = (ClubMember)arr[rand.Next(arr.Length)];
            ClubMember cm3 = (ClubMember)arr[rand.Next(arr.Length)];
            timer.Start();
            for (int j = 0; j < 1000; j++)
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Equals(cm1))
                    {
                        break;
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Equals(cm2))
                    {
                        break;
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Equals(cm3))
                    {
                        break;
                    }
                }

            }
            timer.Stop();
            return timer.ElapsedMilliseconds;
        }
    }
}
