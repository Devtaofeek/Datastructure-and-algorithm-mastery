using System;
using System.Collections.Generic;

namespace GsPractice
{
    public class ArrayQuestions
    {
        public static void SubArraygivenSum(int[] numbers, int K)
        {
            if (numbers.Length == 0)
            {
                Console.WriteLine(0);
            }
            int checksum;
            for (int i = 0; i < numbers.Length; i++)
            {
                checksum = numbers[i];
                for (int j = i + 1; j <= numbers.Length; j++)
                {
                    if (checksum == K)
                    {
                        Console.WriteLine($"the sum is between index {i} and index {j - 1}");
                        return;
                    }

                    if (checksum > K || numbers.Length == j)
                    {
                        break;
                    }
                    else
                    {
                        checksum += numbers[j];
                    }
                }
            }

            Console.WriteLine("Nothing found");
        }

        public static void AllPossibleSubArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    for (int k = i; k <= j; k++)
                    {
                        Console.WriteLine(arr[k] + " ");
                        Console.WriteLine("");
                    }
                }
            }
        }

        public static int returnsmallestwiththesamedigit(int N)
        {
            int smallestNumber = 0;
            if (N <= 1 || N.ToString().Length == 1)
            {
                return smallestNumber;
            }

            int numberOfDigits = N.ToString().Length;

            return (int)Math.Pow(10, numberOfDigits - 1);
        }
        Dictionary<char, int> freq = new Dictionary<char, int>();
        List<int> mylist = new List<int>();
        public  int minimumdelete(string S)
        {
            var chararray = S.ToCharArray();
           
           
            int count = 0;

            for (int i = 0; i < chararray.Length; i++)
            {
                if (freq.ContainsKey(chararray[i]))
                {
                    freq[chararray[i]]++;
                }
                else
                {   
                    freq.Add(chararray[i], 1);
                }
            }

            foreach (var item in freq)
            {
                mylist.Add(item.Value);
            }
            mylist.Sort();
            mylist.Reverse();

            while (mylist.Count != 0)
            {
                mylist.Sort();
                mylist.Reverse();
                int occured = mylist[0];
                mylist.RemoveAt(0);
                if (mylist.Count == 0)
                {
                    return count;
                }

                if(occured == mylist[0])
                {
                    if (occured > 1)
                    {
                        mylist.Add(occured - 1);
                        mylist.Sort();
                    }
                    count++;
                }
            }

            return count;
            
        }

        public int largesrpos(int[] A, int K)
        {
            if (K > A.Length)
            {
                return -1;
            }

            int highest = 0;

            List<int> EvenNumbers = new List<int>();
            List<int> OddNumbers = new List<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if(A[i] %2 == 1)
                {
                    OddNumbers.Add(A[i]);
                }
                else
                {
                    EvenNumbers.Add(A[i]);
                }
            }

            OddNumbers.Sort();
            EvenNumbers.Sort();

            int evenindex = EvenNumbers.Count - 1;
            int oddindex = OddNumbers.Count - 1;

            
            while (K > 0)
            {
                if (K % 2 == 1)
                {

                    if (evenindex >= 0)
                    {
                        highest += EvenNumbers[evenindex];
                        evenindex--;
                    }
                    else {
                        return -1;
                    }

                    K--;
                }

                else if (evenindex>=1 &&  oddindex>=1)
                {
                    if(EvenNumbers[evenindex] + EvenNumbers[evenindex-1] <= OddNumbers[oddindex] + OddNumbers[oddindex - 1])
                    {
                        highest += OddNumbers[oddindex] + OddNumbers[oddindex - 1];
                        oddindex -= 2;
                    }

                    else
                    {
                        highest += EvenNumbers[evenindex] + EvenNumbers[evenindex - 1];
                        evenindex -= 2;

                    }

                    K -= 2;
                }


                else if (evenindex >= 1)
                {
                    highest += EvenNumbers[evenindex] + EvenNumbers[evenindex - 1];
                    evenindex -= 2;
                    K -= 2;
                }

                else if (oddindex >=2)
                {
                    highest += OddNumbers[oddindex] + OddNumbers[oddindex - 1];
                    oddindex -= 2;
                    K -= 2;

                }
               
            }
            return highest;
        }
       public static int returnsmallestnotin(int[] arr)
        {
            if (arr.Length == 0)
            {
                return 0;
            }
            int highest = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                highest = Math.Max(highest, arr[i]);
            }
            return highest - 1;
        }
        public static int CountTheTriplets(int[] arr)
        {
            // 1,2,3,4,5   123 134 145 235
            // 
            int maxvalue = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                maxvalue = Math.Max(maxvalue, arr[i]);
            }
            int[] Freq = new int[maxvalue + 1];

            for (int i = 0; i < arr.Length; i++)
            {
               int dd = Freq[arr[i]]++;

            }
            var ds = 5;
            return 0;

        }
    }


}