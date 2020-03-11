using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            Console.WriteLine("Quantos alunos possui o curso A ? ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso A: ");
            for (int i=0; i < a; i++)
            {
                int x = int.Parse(Console.ReadLine()); 
                A.Add(x);
            }

            Console.Write("Quantos alunos possui o curso B? ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso B: ");
            
            for (int i = 0; i < a; i++)
            {
                int x = int.Parse(Console.ReadLine());
                B.Add(x);
            }


            HashSet<int> Novo = new HashSet<int>();
            Novo.UnionWith(A);
            Novo.UnionWith(B);

            

            Console.WriteLine("Total de Alunos: " + Novo.Count); 
            Console.ReadLine();


            /*A.UnionWith(B);

            foreach ( int x in A)
            {
                Console.WriteLine(x);
            }
            
            Console.WriteLine("Digite um valor inteiro");
            int n = int.Parse(Console.ReadLine());

            if(A.Contains(n))
            {
                Console.WriteLine(n + "Pertence a conjunto A");
            }
            else
            {
                Console.WriteLine(n + "nao Pertence a conjunto A");
            }*/

        }
    }
}