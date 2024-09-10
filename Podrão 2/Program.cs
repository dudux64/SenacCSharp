// See https://aka.ms/new-console-template for more information
Console.Write("Ao clicar em 1, Solicite um taxi \nAo clicar em 2, Solicite um Uber\nAo clicar em 3, Solicite um UberMoto\nInsira Sua Opção: ");
int resposta = Convert.ToInt32(Console.ReadLine());
switch (resposta)
{
    case 1:
        Console.WriteLine("O Taxi Foi solicitado!");
        break;
    case 2:
        Console.WriteLine("O Uber Foi solicitado!");
        break;
    case 3:
        Console.WriteLine("O UberMoto Foi solicitado");
        break;
}

Console.ReadKey();