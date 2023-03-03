using System;
using System.Runtime.InteropServices;


namespace desafio
{
    internal class Program
    {
        static void Main (string[ ] args)
        {

            int numeroLinhas;
           //Entrada
           Console.WriteLine("How many lines? ");
            numeroLinhas = int.Parse(Console.ReadLine());

            StreamWriter escritor = new StreamWriter("desafio.txt");

            //Processamento

            for (int i = 1; i <= numeroLinhas; i++)
           {
                escritor.WriteLine(i);
           }

           escritor.Close();

           Console.WriteLine("");

           StreamReader reader = new StreamReader("desafio.txt");
           

           //string number = reader.ReadLine();


           //Console.WriteLine(number);
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
               
                List<string> test = new List<string>();

                test.
               //Console.WriteLine(number2);

           } while (hasLines);

           Console.WriteLine(number2);
        }
    }
}