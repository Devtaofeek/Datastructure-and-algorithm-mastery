using System;
using System.Collections.Generic;
using System.Text;

namespace GsPractice
{
 public   class Dictionari
    {
        public void firstnonrepeating(string name)
        {
             char[] chara = name.ToCharArray();
            char ch = char.MinValue;
            Dictionary<char, int> dics = new Dictionary<char, int>();
            foreach (var item in chara)
            {
                if (dics.ContainsKey(item)){
                    var count = dics[item];
                    dics[item] = count + 1;
                }
                else
                {
                    dics.Add(item, 1);
                   
                }
            }
            foreach (var item in dics)
            {
                if (dics[item.Key] == 1)
                {
                    ch = item.Key;
                    break;
                }
            }
            Console.WriteLine(ch);
        }
        public void firstrepeating(string name)
        {
            char[] chara = name.ToCharArray();
            char ch = char.MinValue;
            HashSet<char> dics = new HashSet<char>();
            foreach (var item in chara)
            {
                if (dics.Contains(item))
                {
                    ch = item;
                    break;
                }
                else
                {
                    dics.Add(item);

                }
            }
          
            Console.WriteLine(ch);
        }
        public void highestrepeating(string name)
        {
            char[] chara = name.ToCharArray();
            char ch = char.MinValue;
            Dictionary<char, int> dics = new Dictionary<char, int>();
            foreach (var item in chara)
            {
                if (dics.ContainsKey(item))
                {
                    var count = dics[item];
                    dics[item] = count + 1;
                }
                else
                {
                    dics.Add(item, 1);

                }
            }
            foreach (var item in dics)
            {
                if (dics[item.Key] == 1)
                {
                    ch = item.Key;
                    break;
                }
            }
            Console.WriteLine(ch);
        }
    }
}
