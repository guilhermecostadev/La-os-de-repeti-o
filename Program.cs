using System;

namespace Lacos_de_Repeticao
{
    class Program
    {
        static void Main(string[] args)
        {   //TESTANDO O WHILE
            // Console.WriteLine("Qual a idade do ator?");
            // int idade = int.Parse(Console.ReadLine());

            // while(idade != 47)
            // {
            //     Console.WriteLine("Errô!");
            //     Console.WriteLine("Tente novamente");
            //     idade = int.Parse(Console.ReadLine());
            // }
            // Console.WriteLine("Acertô, Mizeravi!");


            //TESTANDO DO WHILE
            // int idade;
            // do{
            //     Console.WriteLine("Qual a idade do ator?");
            //     idade = int.Parse(Console.ReadLine());
            // }while(idade != 47);
            //     Console.WriteLine("Acertô, Mizeravi!");

            //TESTANDO FOR
            Console.WriteLine("Digite um valor");
            int numerofor = int.Parse(Console.ReadLine());

            for(var contador = 0; contador<=numerofor; contador++){
                Console.WriteLine(contador);
            }
        }
        
    }
}
