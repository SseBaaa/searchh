﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searchh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Search ObjektSearch = new Search();
            int[] arrSearch = new int[100];
            int neparnibroj = 1;
            for (int i = 0; i < 100; i++)
            {
                arrSearch[i] = neparnibroj;
                neparnibroj += 2;
            }
            Console.WriteLine("Index broja 75 je:" + ObjektSearch.BinarySearch(arrSearch, 75));
            Console.ReadKey();
        }
    }
}
