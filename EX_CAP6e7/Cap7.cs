using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_CAP6e7
{
    internal class Cap7
    {
        public void Ex1()
        {

            void OrdenarNum(int numero1, int numero2, int numero3)
            {

                int[] num = new int[3];
                num[0] = numero1;
                num[1] = numero2;
                num[2] = numero3;



                Array.Sort(num);
                Console.WriteLine("Números digitados: ");

                foreach (int item in num)
                {
                    Console.WriteLine($"{item}");
                }


            }

            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o primeiro número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o primeiro número: ");
            int num3 = int.Parse(Console.ReadLine());

            OrdenarNum(num1, num2, num3);

            Console.ReadKey();

        }
        public void Ex2()
        {
            void OrdenarMatriz(int[] matriz)
            {
                Array.Sort(matriz);

                foreach (int item in matriz)
                {
                    Console.Write($"{item},");
                }

            }

            void NumerosPares(int[] matriz)
            {

                int contador = 0;

                for (int i = 0; i < matriz.Length; i++)
                {
                    if (matriz[i] % 2 == 0)
                    {
                        contador++;
                    }
                }

                int[] matrizPares = new int[contador];

                contador = 0;

                for (int i = 0; i < matriz.Length; i++)
                {
                    if (matriz[i] % 2 == 0)
                    {
                        matrizPares[contador] = matriz[i];
                        contador++;
                    }
                }

                foreach (int item in matrizPares)
                {
                    Console.Write($"{item},");
                }

            }

            void MultiplosDeCinco(int[] matriz)
            {
                int contador = 0;

                for (int i = 0; i < matriz.Length; i++)
                {
                    if (matriz[i] % 5 == 0)
                    {
                        contador++;


                    }
                }

                int[] matrizMultiplos = new int[contador];

                contador = 0;

                for (int i = 0; i < matriz.Length; i++)
                {
                    if (matriz[i] % 5 == 0)
                    {
                        matrizMultiplos[contador] = matriz[i];
                        contador++;
                    }
                }

                foreach (int item in matrizMultiplos)
                {
                    Console.Write($"{item},");
                }

            }


            int[] matrizA;
            int tamanhoDaMatriz = 0;
            Console.WriteLine("Qual o tamanho da Matriz? ");
            tamanhoDaMatriz = int.Parse(Console.ReadLine());
            matrizA = new int[tamanhoDaMatriz];

            for (int i = 0; i < matrizA.Length; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º valor");
                matrizA[i] = int.Parse(Console.ReadLine());

            }

            foreach (int item in matrizA)
            {
                Console.Write($"{item},");
            }

            Console.WriteLine("---MENU---");
            Console.WriteLine("Digite o número correspondente à sua escolha: ");
            Console.WriteLine("1.Ordenar os elementos da MatrizA.");
            Console.WriteLine("2.Gerar a Matriz apenas com os números pares.");
            Console.WriteLine("3.Gerar a Matriz apenas com os números múltiplos de 5.");
            int opcao = int.Parse(Console.ReadLine());


            switch (opcao)
            {
                case 1:

                    OrdenarMatriz(matrizA);

                    break;
                case 2:

                    NumerosPares(matrizA);

                    break;
                case 3:

                    MultiplosDeCinco(matrizA);

                    break;
            }



            Console.ReadKey();
        }
        public void Ex3()
        {
            double Conversor(int op)
            {

                double DolarParaReal = 5.06;
                double LibraParaReal = 6.28;
                double FrancoParaReal = 5.58;
                double IeneParaReal = 0.038;
                double valor = 0;
                double valorConvertido = 0;

                switch (op)
                {
                    case 1:
                        Console.Write("Digite o valor em Real: ");
                        valor = double.Parse(Console.ReadLine());
                        valorConvertido = valor / DolarParaReal;

                        break;
                    case 2:
                        Console.Write("Digite o valor em Real: ");
                        valor = double.Parse(Console.ReadLine());
                        valorConvertido = valor / LibraParaReal;

                        break;
                    case 3:
                        Console.Write("Digite o valor em Real: ");
                        valor = double.Parse(Console.ReadLine());
                        valorConvertido = valor / FrancoParaReal;

                        break;
                    case 4:
                        Console.Write("Digite o valor em Real: ");
                        valor = double.Parse(Console.ReadLine());
                        valorConvertido = valor / IeneParaReal;

                        break;
                    case 5:
                        Console.Write("Digite o valor em Real: ");
                        valor = double.Parse(Console.ReadLine());
                        valorConvertido = valor * DolarParaReal;

                        break;
                    case 6:
                        Console.Write("Digite o valor em Real: ");
                        valor = double.Parse(Console.ReadLine());
                        valorConvertido = valor * LibraParaReal;

                        break;
                    case 7:
                        Console.Write("Digite o valor em Real: ");
                        valor = double.Parse(Console.ReadLine());
                        valorConvertido = valor * FrancoParaReal;

                        break;
                    case 8:
                        Console.Write("Digite o valor em Real: ");
                        valor = double.Parse(Console.ReadLine());
                        valorConvertido = valor * IeneParaReal;

                        break;
                }

                return valorConvertido;
            }

            int opcao = 0;
            double aux = 0;

            Console.WriteLine("Conversor de Moedas");
            Console.WriteLine("1. Real para Dólar");
            Console.WriteLine("2. Real para Libra");
            Console.WriteLine("3. Real para Franco");
            Console.WriteLine("4. Real para Iene");
            Console.WriteLine("5. Dólar para Real");
            Console.WriteLine("6. Libra para Real");
            Console.WriteLine("7. Franco para Real");
            Console.WriteLine("8. Iene para Real");

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());



            aux = Conversor(opcao);
            Console.WriteLine("Valor convertido é igual a: " + aux);

            Console.ReadKey();



        }

        public void Ex4()
        {

            void divisivel(double num1, double num2)
            {

                if (num1 % num2 == 0)
                {
                    Console.WriteLine($"O número {num1} é divisivel por {num2}");
                }
                else
                {
                    Console.WriteLine($"O número {num1} não é divisivel por {num2}");
                }


            }


            double num1 = 0, num2 = 0;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            divisivel(num1, num2);

            Console.ReadKey();

        }
        public void Ex5()
        {
            double numReal = 0;
            int resultado = 0;
            Console.WriteLine("Digite um número real: ");
            numReal = double.Parse(Console.ReadLine());


            resultado = (int)Math.Round(numReal);

            Console.WriteLine($"O número {numReal} arredondado é igual a: {resultado}");




        }
        public void Ex9()
        {

            void CriarVetor(int[] Vetor)
            {
                Random random = new Random();
                for (int i = 0; i < Vetor.Length; i++)
                {
                    Vetor[i] = random.Next();
                }
            }


            void OrdenarVetor(int[] vetor)
            {
                Array.Sort(vetor);

                foreach (int item in vetor)
                {
                    Console.Write($"{item},");
                }

            }


            void MultiplosDeSete(int[] vetor)
            {
                int contador = 0;

                for (int i = 0; i < vetor.Length; i++)
                {
                    if (vetor[i] % 7 == 0)
                    {
                        contador++;


                    }
                }
                Console.WriteLine($"A quantidade de múltilos de 7 presentes no vetor é de: {contador}");

            }
            int[] VetorA = new int[30];

            Console.WriteLine("---MENU---");
            Console.WriteLine("Digite o número correspondente à sua escolha: ");
            Console.WriteLine("1.Criar Vetor.");
            Console.WriteLine("2.Ordenar Vetor.");
            Console.WriteLine("3.Quantidade de Multiplos por 7.");
            int opcao = int.Parse(Console.ReadLine());


            switch (opcao)
            {
                case 1:

                    CriarVetor(VetorA);

                    break;
                case 2:

                    OrdenarVetor(VetorA);

                    break;
                case 3:

                    MultiplosDeSete(VetorA);

                    break;
            }

            Console.ReadKey();
        }
        
    }
}
