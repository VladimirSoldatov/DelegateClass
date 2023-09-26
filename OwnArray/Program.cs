using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnArray
{
    internal class Program
    {
        public class SortedArrayList:ArrayList
        {
            public void AddSorted(object item)
            {
                int position = BinarySearch(item);
                if (position < 0)
                {
                    position = ~position;
                }
                Insert(position, item);
            }

        }

        static void Main(string[] args)
        {
            SortedArrayList list = new SortedArrayList();
            list.AddSorted(1);
            list.AddSorted(2);
            list.AddSorted(0);
            foreach (object item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
