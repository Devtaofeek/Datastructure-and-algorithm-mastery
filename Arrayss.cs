using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GsPractice
{
   public class Arrayss
    {
        // the big o of finding an item in an array is O(1) beacuse the memory location 
        // can be easily calculated
        // look up O(1)
        //insert O(n)
        //delete O(n)

        private int[] items;
        public Arrayss(int length )
        {
            items = new int[length];
        }
        private int count;
       
        string[] cars;
        public void Arraym()
        {
            cars = new string[30];
        }

        public void insert(int item)
        {
            if (items.Length == count)
            {
              int[]  newitems = new int[count * 2];

                for (int i = 0; i < count; i++)
                {
                    newitems[i] = items[i];
                    
                }
                items = newitems;
            }
            items[count++] = item;
        }

        public void removeat(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentException();
            }
            for (int i = index; i < count; i++)
            {
                items[i] = items[i + 1];

            }
            count--; 
        }
        public int indexof(int item) {
            for (int i = 0; i < count; i++)
            {
                if (items[i] == item)
                {
                    return i;
                }
            }
            return -1;

        }

      
        public void print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}
