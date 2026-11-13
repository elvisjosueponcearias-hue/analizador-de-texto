using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Escriba una frase: ");
        string frase = Console.ReadLine().Trim();

        Console.WriteLine("Texto original: " + frase);

        MostrarAnálisis(frase);
    }
    static int ContarVocales(string texto)
    {
        int contador = 0;
        string vocales = "aeiouáéíóúAEIOUÁÉÍÓÚ";

        foreach (char c in texto)
        {
            if (vocales.Contains(c))
            {
                contador++;
            }
        }

        return contador;
    }
    static void MostrarAnálisis(string texto)
    {
        Console.WriteLine("Longitud: " + texto.Length);
        Console.WriteLine("Mayúsculas: " + texto.ToUpper());
        Console.WriteLine("Minúsculas: " + texto.ToLower());

        int totalVocales = ContarVocales(texto);
        Console.WriteLine($"Vocales: {totalVocales}");

        string conGuiones = texto.Replace(' ', '_');
        Console.WriteLine("Con guiones: " + conGuiones);

        string primeraPalabra = texto.Split(' ')[0];
        Console.WriteLine("Primera palabra: " + primeraPalabra);

    }
}