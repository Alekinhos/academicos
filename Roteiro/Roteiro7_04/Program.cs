using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Alex Gonçalves da Silva
//Roteiro7_04
//05/05/2016

namespace Roteiro7_04
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream arq = new FileStream("letras.txt", FileMode.Create);            StreamWriter comandoescreve = new StreamWriter(arq);            string letra,tudo;            int i, contA = 0, contE = 0, contI = 0, contO = 0, contU = 0;            Console.WriteLine("digite 100 letras: ");            for (i=0;i<100;i++)
            {
                letra = Console.ReadLine();
                comandoescreve.WriteLine(letra);
            }
            comandoescreve.Close();
            FileStream arq1 = new FileStream("letras.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arq1);
            tudo = ler.ReadToEnd();
            Console.WriteLine("Tudo que foi escrito no arquivo: " + tudo);
            for (i = 0; i < 100; i++)
            {
                switch (tudo[i])
                {
                    case 'a':
                        contA++;
                        break;
                    case 'e':
                        contE++;
                        break;
                    case 'i':
                        contI++;
                        break;
                    case 'o':
                        contO++;
                        break;
                    case 'u':
                        contU++;
                        break;
                }
            }
            Console.Write("\n Vogal A: " + contA + "\n Vogal E : " + contE + "\n Vogal I: " + contI + "\n Vogal O: " + contO +            "\n Vogal U: " + contU);

            Console.ReadKey();
        }
    }
}
