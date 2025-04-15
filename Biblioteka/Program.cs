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
        this.tytul = tytul;
        this.autor = autor;
    }
}

class Biblioteka
{
    List<string> lista = new List<string>();

    public void Dodaj(Ksiazka ksiazka)
    {
        lista.Add("Autor "+ksiazka.Autor + ":\n - " + ksiazka.Tytul);
    }

    public void Wyswietl()
    {
        foreach (string element in lista)
        {
            Console.WriteLine(element);
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Witaj w bibliotece!");
        Console.WriteLine("Podaj tytul ksiazki:");
        string? tytul = Console.ReadLine();
        

        Console.WriteLine("Podaj autora ksiazki:");
        string? autor = Console.ReadLine();


        Ksiazka ksiazka = new Ksiazka(tytul, autor);
        Biblioteka biblioteka = new Biblioteka();
        biblioteka.Dodaj(ksiazka);

        Console.WriteLine("\nLista ksiazek w bibliotece:");
        biblioteka.Wyswietl();
    }
}
