﻿using System;

namespace exe_resolv03
{
    class exe_resolv03
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            int idade1, idade2;
            double media;
            string[] vet;

            Console.WriteLine("Informe o nome e a idade da pessoa n° 1");
            vet = Console.ReadLine().Split(" ");
            nome1 = vet[0];
            idade1 = int.Parse(vet[1]);

            Console.WriteLine("Informe o nome e a idade da pessoa n° 2");
            vet = Console.ReadLine().Split(" ");
            nome2 = vet[0];
            idade2 = int.Parse(vet[1]);

            media = (double)(idade1 + idade2) / 2.0;

            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + media.ToString("F1") + " anos");
        }
    }
}
