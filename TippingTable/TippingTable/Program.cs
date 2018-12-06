using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TippingTable
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double dinnerPrice = 10.00;
            double tipRate, tip;
            const double LOWRATE = .1;
            const double MAXRATE = .25;
            const double TIPSTEP = .05;
            const double MAXDINNER = 100.00;
            const double DINNERSTEP = 10.00;

            Write("Price");
            for (tipRate = LOWRATE; tipRate <= MAXRATE; tipRate += TIPSTEP)
            {
                Write("{0, 8}", tipRate.ToString("F"));
                WriteLine();
                WriteLine("-----------------------------------------------------");
                
            }
tipRate = LOWRATE;
            while (dinnerPrice <= MAXRATE)
            {
                Write("{0, 8}", dinnerPrice.ToString("C"));
                while (tipRate <= MAXRATE)
                {
                    tip = dinnerPrice * tipRate;
                    Write("{0, 8}", tip.ToString("F"));
                    tipRate += TIPSTEP;
                }
                dinnerPrice += DINNERSTEP;
                tipRate = LOWRATE;
                WriteLine();
            }

        }
    }
    }

