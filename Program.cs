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