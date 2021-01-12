using System;
using System.Collections.Generic;
using System.Text;

namespace GsPractice
{
  public static class MicrosoftInterviewPractice
    {
        public static int SmallestNumberWiththesamedigits(int N)
        {
            int smallestNumber = 0;
            if (N <= 1 || N.ToString().Length == 1)
            {
                return smallestNumber;
            }

            int numberOfDigits = N.ToString().Length;

            return (int)Math.Pow(10, numberOfDigits - 1);
        }
        
        public static int  MaximumEvensSumSubSequence(int[] arr, int K)
        {
            // if k < arrlenght then we cannot have a maxeven sum then return -1
            // store all evennumber in an list
            // store all odd numbers in lise
            // sort odd
            // sort even
            // while k >0 check for the following comdition
           // if k is an odd number then at least one even number will be needed to get a maximum even sum
           // so add that even number to the to the initial maximum sum , if i has no element return -1
           // decreament k 
           //if the oddnumber list and even number list have more than two numbers then pick the top two from each one, check which is bigger afer adding two top even and two top odd, if it is odd add to max sum if it even add to maxsum
           // check id even list has more than two, add the two top two to the max sum
           // if odd list has more than two pick the top two and add to maxsum
           // the loop will run umtil k ==0




            ////// what was used 
            /// if k is odd,to get an even number you need at least one even
            /// if k even, you need two even or two odd

            
            if (K < arr.Length)
            {
                return -1;
            }

            int maxSum = 0;

            List<int> EvenNumbers = new List<int>();
            List<int> OddNumbers = new List<int>();

            for (int a = 0; a < arr.Length; a++)
            {
                if (arr[a] % 2 == 0)
                {
                    EvenNumbers.Add(arr[a]);
                }
                else
                {
                    OddNumbers.Add(arr[a]);
                }
            }

            EvenNumbers.Sort();
            OddNumbers.Sort();

            int i = EvenNumbers.Count - 1;
            int j = OddNumbers.Count - 1;
            while (K > 0)
            {
                // if is odd 
                if (K % 2 == 1)// if k is odd then at least on even number will make up the maximum sum
                {
                    if (i >= 0) // check if there is an element in the EvenNumbers list
                    {
                        maxSum += EvenNumbers[i];
                        i--;
                    }

                    else
                    {
                        return -1; // return -1 if k is odd and we cannnot find an even number 
                    }

                    K--; // this is just to terminate the loop
                }

                else if (i>= 1 && j>=1) // check if we have two numbers to reference
                {
                    if (EvenNumbers[i] + EvenNumbers[i - 1] <=  // if the two remaining needed is even even or odd odd , check the highese
                            OddNumbers[j] + OddNumbers[j - 1]){

                        maxSum += OddNumbers[j] + OddNumbers[j - 1];
                        j -= 2;  // two picked already from odd

                    }
                    else
                    {
                        maxSum += EvenNumbers[i] + EvenNumbers[i - 1];
                        i -= 2;
                    }

                    K -= 2;  // break the loop
                }

                else if (i >= 1)
                {
                    maxSum += EvenNumbers[i] + EvenNumbers[i - 1];
                    i -= 2;
                    K -= 2;  // break the loop
                }

                else if (j >= 1)
                {
                    maxSum +=OddNumbers[j] + EvenNumbers[j - 1];
                    j -= 2;
                    K -= 2;
                }
            }
                return maxSum;

        }


        public static int maximumcharacterrequired(string a)
        {
            // string Taofeek    // first find all the frequency
            // initialize a variable to store the count of characters required to be removed
            // create a priority  queue to add the frequency
            // sort the priority queue
            // reverse the priority queue 
            //this way the highest frequency comes first
            //check to see if the highest frequency and the one before it are the same 
            //check if that highest is greater than one 
            //if they are remove the highest from the pq and the topmost -1 to th pq
            // increament count everytime you remove from the pq, the count is the number of times
            var chararray = a.ToCharArray();
            int ctnchar = 0;
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            int[] freq = new int[a.Length];
            foreach (var item in chararray)
            {
                keyValuePairs[item] = 0;
            }
            for (int i = 0; i < a.Length; i++)  
            {
                if (keyValuePairs.ContainsKey(a[i]))
                {
                    keyValuePairs[a[i]]++;
                };
                    
            }

            var pq = new List<int>();

            foreach (var item in keyValuePairs)
            {
                pq.Add(item.Value);
            }

            pq.Sort();
            pq.Sort();
            pq.Reverse();

            while (pq.Count != 0)
            {
                pq.Sort();
                pq.Reverse();

                int topmostfrequent = pq[0];

                pq.RemoveAt(0);

                if (pq.Count == 0)
                {
                    return ctnchar;
                }

                if (topmostfrequent == pq[0])
                {
                    if (topmostfrequent > 1)
                    {
                        pq.Add(topmostfrequent - 1);
                        pq.Sort()
;                    }
                    ctnchar++;
                };
            }

            return ctnchar;
        }
    }
}
