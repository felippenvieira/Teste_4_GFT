Menu();

void Menu()
{
    Console.Clear();

    Console.WriteLine("Menu de opções:");
    Console.WriteLine();

    Console.WriteLine("1. Soma");
    Console.WriteLine("2. IMC");
    Console.WriteLine();
    Console.WriteLine("3. Sair");

    Console.WriteLine();
    Console.WriteLine("Digite a opção desejada: ");

    int userOption;

    try
    {
        userOption = int.Parse(Console.ReadLine());

        switch (userOption)
        {
            case 1: Sum(); break;
            case 2: IMC(); break;
            case 3: Environment.Exit(0); break;
            default: Menu(); break;
        }
    }
    catch
    {
        Console.Clear();
        Console.WriteLine("Opção inválida.");
        Console.WriteLine("Por favor, escolha uma das opções númericas.");
        Console.WriteLine("Aperte qualquer tecla para continuar.");
        Console.ReadKey();
        Menu();
    }
}

void Sum()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine();

    float result = v1 + v2;
    Console.WriteLine($"O resultado da soma é {result}");
    Console.ReadKey();
    Menu();
}

void IMC()
{
    Console.Clear();

    Console.WriteLine("Digite o peso: ");
    double weight = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a altura: ");
    double height = double.Parse(Console.ReadLine());

    var imc = (weight / (height * height));

    if (imc < 18.5)
    {
        Console.WriteLine("Peso abaixo do normal");
    }
    else if (imc < 25)
    {
        Console.WriteLine("Peso normal");
    }
    else if (imc < 30)
    {
        Console.WriteLine("Sobre o peso");
    }
    else if (imc < 35)
    {
        Console.WriteLine("Grau de obesidade I");
    }
}
