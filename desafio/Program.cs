using System;
using System.Runtime.InteropServices;


namespace desafio
{
    internal class Program
    {
        static void Main (string[ ] args)
        {
            //abaixo o programa número 1 - repare que no programa 2, as variáveis são diferentes do programa 1
            int numeroLinhas;
            Console.WriteLine("How many lines? ");
            numeroLinhas = int.Parse(Console.ReadLine());

            StreamWriter escritor = new StreamWriter("desafio.txt");


            for (int i = 1; i <= numeroLinhas; i++)
           {
                escritor.WriteLine(i);
           }

           escritor.Close();

           Console.WriteLine("Arquivo Criado!");

           //abaixo seria o programa número 2 do desafio

           StreamReader reader = new StreamReader("desafio.txt");

           int number2 = 0;
           bool hasLines = true;
           do  
           {
               string number = reader.ReadLine();

               if (number == null)
               {
                   hasLines = false;
               }
               else

               {
                    number2 += Convert.ToInt32(number);
               }

           } while (hasLines);

           Console.WriteLine(number2);
        }
    }
}