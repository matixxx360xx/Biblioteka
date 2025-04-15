
class Ksiazka
{
    private string tytul = string.Empty;
    private string autor = string.Empty;

    public string Tytul
    {
        get { return tytul; }
        set { tytul = value; }
    }

    public string Autor
    {
        get { return autor; }
        set { autor = value; }
    }

    public Ksiazka(string tytul, string autor)
    {
        Tytul = tytul;
        Autor = autor;
    }
}

class Biblioteka
{
    List<Ksiazka> lista = new List<Ksiazka>();

    public void Dodaj(Ksiazka ksiazka)
    {
        lista.Add(ksiazka);
    }

    public void Wyswietl()
    {
        foreach (Ksiazka ksiazka in lista)
        {
            Console.WriteLine($"Autor {ksiazka.Autor}:\n - {ksiazka.Tytul}");
        }
    }
}

class Program
{
    static void Main()
    {
        Biblioteka biblioteka = new Biblioteka(); 

        while (true)
        {
            Console.WriteLine("Witaj w bibliotece!");
            Console.WriteLine("1. Dodaj ksiazke");
            Console.WriteLine("2. Wyswietl");
            Console.WriteLine("Wybierz:"); 
            string? wybor = Console.ReadLine();
            
            switch (wybor)
            {
                case "1":
                    Console.WriteLine("Podaj tytul ksiazki:");
                    string? tytul = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(tytul))
                    {
                        Console.WriteLine("Podaj tytul ksiazki:");
                        tytul = Console.ReadLine();
                    }

                    Console.WriteLine("Podaj autora ksiazki:");
                    string? autor = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(autor))
                    {
                        Console.WriteLine("Podaj autora ksiazki:");
                        autor = Console.ReadLine();
                    }

                    Ksiazka ksiazka = new Ksiazka(tytul, autor);
                    biblioteka.Dodaj(ksiazka);
                    break;
                case "2":
                    Console.WriteLine("\nLista ksiazek w bibliotece:");
                    biblioteka.Wyswietl();
                    break;
                default:
                    Console.WriteLine("Nieznany wybor. Sprobuj ponownie.");
                    continue;
            }


          
        }
    }
}
