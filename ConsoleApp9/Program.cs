using System;


namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração do vetor
            hospedes[] vect = new hospedes[10];
            //Solicitando o numero de hospedes a ser registrado
            Console.WriteLine("Digite o numero de hospedes que irão alugar quartos: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine(" ");
                //Informações do hospede
                Console.WriteLine($"Hospede #{i}");
                Console.WriteLine("Nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Email");
                string email = Console.ReadLine();
                Console.WriteLine("Quarto");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new hospedes(nome, email);
            }
            Console.WriteLine("");
            //Imprimir quartos ocupados
            Console.WriteLine("Quartos Ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
            Console.ReadKey();
        }
    }
}

