using System;

namespace condicao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double preco = double.Parse(Console.ReadLine());

            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            Console.WriteLine(desconto);*/


            string original = "abcde   FGHIJ  ABC abc DEFG";

            string S1 = original.ToUpper();
            string S2 = original.Trim();
            int n1 = original.IndexOf("bc");/*primeira posicao encontrada*/
            int n2 = original.LastIndexOf("bc");/*ultima posicao*/
            string  S3 = original.Substring(3); /*corta a partir desta posicao*/

            DateTime d1 = DateTime.Now;
            DateTime d2 = DateTime.Today;
            Console.WriteLine(d1);
            Console.WriteLine(d2);


        }
    }
}
