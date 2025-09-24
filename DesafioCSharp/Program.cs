using System;

public class Desafio
{
    public static void Main()
    {
        double valorSalario = double.Parse(Console.ReadLine());
        double valorBeneficios = double.Parse(Console.ReadLine());
        double valorImposto = 0;

        if (valorSalario >= 0 && valorSalario <= 1100)
        {
            valorImposto = 0.05 * valorSalario;
        }
        else if (valorSalario >= 1100.01 && valorSalario <= 2500)
        {
            valorImposto = 0.10 * valorSalario;
        }
        else
        {
            valorImposto = 0.15 * valorSalario;
        }

        double saida = valorSalario - valorImposto + valorBeneficios;
        Console.WriteLine(saida);
    }
}
