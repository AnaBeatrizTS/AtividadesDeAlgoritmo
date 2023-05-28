using  EX_CAP6e7;

Cap6 cap6 = new Cap6();
Cap7 cap7 = new Cap7();

int escolha = 0;
int escolha2 = 0;

Console.WriteLine("Exercicos cap 6 e 7");
Console.WriteLine("Digite 1 para o capitulo 6");
Console.WriteLine("Digite 2 para o capitulo 7");
escolha = int.Parse(Console.ReadLine());


if(escolha == 1)
{
    Console.WriteLine("Digite 2 para o exercicio 2");
    Console.WriteLine("Digite 3 para o exercicio 3");
    Console.WriteLine("Digite 7 para o exercicio 7");
    Console.WriteLine("Digite 8 para o exercicio 8");
    Console.WriteLine("Digite 9 para o exercicio 9");
    escolha2 = int.Parse(Console.ReadLine());
    if (escolha2 == 2)
    {
        cap6.Ex2();
    }
    if (escolha2 == 3)
    {
        cap6.Ex3();
    }
    if (escolha2 == 7)
    {
        cap6.Ex7();
    }
    if (escolha2 == 8)
    {
        cap6.Ex8();
    }
    if (escolha2 == 9)
    {
        cap6.Ex9();
    }
}
else
{
    Console.WriteLine("Digite 1 para o exercicio 1");
    Console.WriteLine("Digite 2 para o exercicio 2");
    Console.WriteLine("Digite 3 para o exercicio 3");
    Console.WriteLine("Digite 4 para o exercicio 4");
    Console.WriteLine("Digite 5 para o exercicio 5");
    Console.WriteLine("Digite 9 para o exercicio 9");
    escolha2 = int.Parse(Console.ReadLine());
    if (escolha2 == 1)
    {
        cap7.Ex1();
    }
    if (escolha2 == 2)
    {
        cap7.Ex2();
    }
    if (escolha2 == 3)
    {
        cap7.Ex3();
    }
    if (escolha2 == 4)
    {
        cap7.Ex4();
    }
    if (escolha2 == 5)
    {
        cap7.Ex5();
    }  
    if (escolha2 == 9)
    {
        cap7.Ex9();
    }
}

Console.ReadKey();

