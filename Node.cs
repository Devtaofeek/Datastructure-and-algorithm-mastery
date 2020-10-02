using System;
using System.Collections.Generic;
using System.Text;

namespace GsPractice
{
   public  class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int item)
        {
            this.Value = item;
        }
    }
}
