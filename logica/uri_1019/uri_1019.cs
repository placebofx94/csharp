﻿using System;

namespace uri_1019
{
    class uri_1019
    {
        static void Main(string[] args)
        {
            int horas, minutos, segundos, n, resto;

            n = int.Parse(Console.ReadLine());

            horas = n / 3600;
            resto = n % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}
