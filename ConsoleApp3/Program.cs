using System;
class program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la base: ");
        string basetxt=Console.ReadLine();
        float base1=float.Parse(basetxt);

        Console.Write("Ingresa el exponente: ");
        string potenciatxt =Console.ReadLine();
        int potencia = int.Parse(potenciatxt);

        double resultado = 1;

        for (int i = 0; i < potencia; i++)
        {
            resultado *= base1;
        }

        Console.WriteLine("La potencia es:" + resultado);
        Console.ReadKey();
    }
}