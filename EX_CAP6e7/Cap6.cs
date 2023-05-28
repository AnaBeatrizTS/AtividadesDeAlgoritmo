using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_CAP6e7
{
    internal class Cap6
    {
        public void Ex2()
        {
            double[] temp = new double[7];
            double media = 0, soma = 0;
            int diaAcimadaMedia = 0;

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Digite a temperatura do dia {i + 1}.");
                temp[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < 7; i++)
            {
                soma += temp[i];
            }

            media = soma / 7;

            for (int i = 0; i < 7; i++)
            {
                if (temp[i] > media)
                {
                    diaAcimadaMedia++;
                }
            }


            Console.WriteLine($"A média de temperatura é de: {media:F2} Cº.");
            Console.WriteLine("A temperatura ficou " + diaAcimadaMedia + " dias acima na média.");


            Console.ReadKey();
        }


        public void Ex3()
        {
            char[] vogais = { 'a', 'e', 'i', 'o', 'u' };
            double[] alturas = new double[10];
            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };



            Console.WriteLine("Vogais do alfabeto:");
            foreach (char vogal in vogais)
            {
                Console.WriteLine(vogal);
            }


            Console.WriteLine("Digite as alturas de 10 pessoas:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Altura da pessoa {i + 1}: ");
                alturas[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Alturas das pessoas:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Pessoa {i + 1}: {alturas[i]}");
            }

            Console.WriteLine("Meses do ano:");
            foreach (string mes in meses)
            {
                Console.WriteLine(mes);
            }

            Console.ReadKey();

        }

        public void Ex7()
        {
            double[] temp = new double[7];

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Digite a temperatura do dia {i + 1}.");
                temp[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine($"Dia {i + 1}: ");

                for (int j = 0; j < temp[i]; j++)
                {
                    Console.Write("■");
                }
            }
                        

            Console.ReadKey();
        }

        public void Ex8()
        {
            int[] vetorA = new int[10];
            int[] vetorB = new int[10];
            int[] vetorC = new int[10];
            int indice = 0;

            Console.WriteLine("Digite os elementos do vetor A: ");
            for (int i = 0; i < vetorA.Length; i++)
            {
                Console.WriteLine($"Valor {i + 1}: ");
                vetorA[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Digite os elementos do vetor B: ");
            for (int i = 0; i < vetorB.Length; i++)
            {
                Console.WriteLine($"Valor {i + 1}: ");
                vetorB[i] = Convert.ToInt32(Console.ReadLine());
            }

            indice = vetorB.Length;

            for (int i = 0; i < vetorC.Length; i++)
            {
                indice--;
                vetorC[i] = vetorA[i] + vetorB[indice];

            }


            Console.WriteLine("Valor do Vetor C: ");
            foreach(int i in vetorC)
            {
                Console.Write($"{i} ");
            }

            Console.ReadKey();
        }
        public void Ex9()
        {
            int[] vetorA = new int[10];
            int[] vetorB = new int[10];
            int[] vetorC = new int[10];
            int indice = 0;

            Console.WriteLine("Digite os elementos do vetor A: ");
            for (int i = 0; i < vetorA.Length; i++)
            {
                Console.WriteLine($"Valor {i + 1}: ");
                vetorA[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Digite os elementos do vetor B: ");
            for (int i = 0; i < vetorB.Length; i++)
            {
                Console.WriteLine($"Valor {i + 1}: ");
                vetorB[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < vetorC.Length; i++)
            {
                vetorC[i] = int.Parse(vetorA[i].ToString() + vetorB[i].ToString());
            }

            Array.Sort(vetorC);

            Console.WriteLine("Valor do Vetor C: ");
            foreach (int i in vetorC)
            {
                Console.Write($"{i} ");
            }

            Console.ReadKey();
        }

    }
}
