﻿using System;

namespace uri_1007
{
    class uri_1007
    {
        static void Main(string[] args)
        {
            int a, b, c, d, diferenca;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            diferenca = ((a * b) - (c * d));

            Console.WriteLine("DIFERENCA = " + diferenca);
        }
    }
}
