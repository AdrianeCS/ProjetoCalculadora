using Calculadora.Lib;

string opcaoDesejada;

Console.Clear();

Console.WriteLine("---Calculadora---\n");

Console.WriteLine("[+] Soma");
Console.WriteLine("[-] Subtração");
Console.WriteLine("[*] Multiplicação");
Console.WriteLine("[/] Divisão");
Console.WriteLine("[^] Exponenciação");
Console.WriteLine("[x] Radiciação");
Console.WriteLine("[S] Seno");
Console.WriteLine("[C] conseno");
Console.WriteLine("[T] Tangente");
Console.Write("\nSelecione a operação desejada: ");

opcaoDesejada = Console.ReadLine()!;

switch (opcaoDesejada)
{
    case "+":
        AritmeticaVisuais.CalcularSoma();
        break;
    case "-":
        AritmeticaVisuais.CalcularSubtracao();
        break;
    case "*":
        AritmeticaVisuais.CalcularMultiplicacao();
        break;
    case "/":
        AritmeticaVisuais.CalcularDivisao();
        break;
    case "^":
        AritmeticaVisuais.CalcularExponenciação();
        break;
    case "x":
        AritmeticaVisuais.CalcularRadiciação();
        break;
    case "S":
        AritmeticaVisuais.CalcularSeno();
        break;
    case "C":
        AritmeticaVisuais.CalcularConseno();
        break;
    case "T":
        AritmeticaVisuais.Calculartangente();
        break;


    default:
        Console.WriteLine("Opção inválida.");
        break;
}

Console.WriteLine("\nObrigado por utilizar nosso programa... :D");


