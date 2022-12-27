﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Functions
    {
        private LinkedList<int> list;


        public Functions(int ammount)
        {
            if (ammount > 0)
            {
                list = new LinkedList<int>(Enumerable.Range(1, ammount));
            }
            else
            {
                throw new ArgumentException("Ammount of people must be > 0");
            }
        }

        public int LeftNumber()
        {
            var currentItem = list.First;
            while (list.Count > 1)
            {
                list.Remove(currentItem.Next ?? list.First);
                currentItem = currentItem.Next ?? list.First;
            }
            return (list.First.Value);
        }
    }
}
