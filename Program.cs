Console.WriteLine("Hello, World!");
// Tablica 6 wartosci losowych
// funkcja zwraca tablice przekazujemy do niej liczbe elementow 

int[] wylosujTablice(int liczbaElementow)
{
    int[] tablicaWylosowana = new int[liczbaElementow]; 
    for (int i = 0; i < tablicaWylosowana.Length; i++)
    {        
        tablicaWylosowana[i] = new Random().Next(1, 100); 
    }
    return tablicaWylosowana;
}
void wypiszTablice(int[] tablicaDoWypisania)
{     for (int i = 0; i < tablicaDoWypisania.Length; i++)
    {
        Console.Write(tablicaDoWypisania[i] + ", ");
    }
   
}
int[] tablicaProbna = wylosujTablice(10);
wypiszTablice(tablicaProbna);

int[] wczytajLiczbyDoTablicy(int ileLiczb)
{
    int[] tablicaZKlawiatury = new int[ileLiczb];
    for (int i = 0; i < ileLiczb; i++)
    {
        Console.WriteLine("Podaj liczbe: ");
        tablicaZKlawiatury[i] = int.Parse(
            Console.ReadLine());
    }
    return tablicaZKlawiatury;
}
int[] tablicaWczytana = wczytajLiczbyDoTablicy(6);
wypiszTablice(tablicaWczytana);

List<int> wylosowanieLiczbBezPowtórzenDOListy(int ileLiczba)
{
    List<int> listaWylosowana = new List<int>();
    // w listach mozna zmieniac rozmiar
    // w trakcie działania programu
    Random random = new Random();
   for(int i = 0; i < ileLiczba; i++)
    {
        int liczba = random.Next(1, 10);
        while (listaLiczbLosowych.Contains(liczba))
        {
            liczba = random.Next(1, 10);
        }
        {
            liczba = random.Next(1, 10);
        }
        listaWylosowana.Add(liczba);
    }
    return listaWylosowana;
}
void wypiszListe(List<int> listaliczb) { 

    {
        for (int i = 0; i < listaliczb.Count; i++)
        {
            Console.Write(listaliczb[i] + ", ");
        }
}
}
List<int> listaProbna = wylosowanieLiczbBezPowtórzenDOListy(10);
wypiszListe(listaProbna);

HashSet<int> wylosujLiczbyBezPowtorzenDoZbioru(int ileLiczb)
{
    HashSet<int> zbiorWylosowany = new HashSet<int>();
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        zbiorWylosowany.Add(random.Next(1, 10));
    }
    return zbiorWylosowany;
}
void wypiszZbior(HashSet<int> zbiorLiczb)
{
   Console
}