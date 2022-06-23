namespace Calculadora.Lib;

public class Aritmetica
{
    public static double Soma(double parcela1, double parecla2)
    {
        double total = parcela1 + parecla2;
        return total;
    }

    public static double Subtração(double minuendo, double subtraendo)
    {
        double diferenca = minuendo - subtraendo;
        return diferenca;
    }
    public static double Multiplicação(double fator1, double fator2)
    {
        double produto = fator1 + fator2;
        return produto;
    }

    public static double Divisão(double dividendo, double divisor)
    {
        if (divisor == 0)
        {
            throw new Exception("não é possível dividir por zero");
        }
        double quociente = dividendo / divisor;
        return quociente;
    }
    public static double Exponenciação(double numeroBase, double expoente)
    {
        double potencia = Math.Pow(numeroBase, expoente);
        return potencia;
    }

    public static double Radiciação(double radicando, double indice)
    {
        if (radicando < 0)
        {
            throw new Exception("O radicando deve ser maior ou igual a zero");
        }
        else if (indice <= 0)
        {
            throw new Exception("O indice deve ser maior que zero");
        }
        else
        {
            double raiz = Math.Pow(radicando, 1/ indice);
            return raiz;
        }
    }
    public static double seno(double angulo)
    {
        return Math.Sin(angulo * (Math.PI / 180) );
    }
     public static double cosseno(double angulo)
    {
        return  Math.Cos(angulo * (Math.PI / 180) );
    }
     public static double tangente(double angulo)
    {
        return Math.Tan(angulo * (Math.PI / 180) );
    }
    
}