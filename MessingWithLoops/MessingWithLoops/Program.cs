﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MessingWithLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            
            while (i <= 5)
            {
                WriteLine(i);
                i++;
            }

            while (i >= 0)
            {
                i--;
                WriteLine(i);
                
            }
            do
            {
                WriteLine(i);
                i++;
            } while (i <= 5);

            for(int j = 0; j <= 5; ++j)
            {
                WriteLine(j);
            }
        }
    }
}
