using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string nazwaPliku = "plikdoodczytu.txt";

        try
        {
            using (StreamReader sr = new StreamReader(nazwaPliku))
            {
                string linia;
                while ((linia = sr.ReadLine()) != null)
                {
                    Console.WriteLine(OdwrocLinie(linia));
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wystąpił błąd: " + ex.Message);
        }

        Console.ReadKey();
    }

    static string OdwrocLinie(string linia)
    {
        char[] znaki = linia.ToCharArray();
        Array.Reverse(znaki);
        return new string(znaki);
    }
}
