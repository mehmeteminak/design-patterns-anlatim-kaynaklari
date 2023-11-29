


public class Human
{

    public string name;
    public string surname;
    public string height;

    Kola kola = new Kola();

    public void SıvıTuket()
    {
        kola.Tuket();
    }

}

public class Kola
{
    private string marka;
    private string fiyat;

    public void Tuket()
    {
        Console.WriteLine("Kola İçildi!");
    }
}



public class Program5
{
    public static void Main()
    {
        Human celal = new Human();
        celal.SıvıTuket();
    }
}

/*
public class Water
{
    private string marka;
    private string fiyat;
    private string PhDegeri;

    public void Tuket()
    {
        Console.WriteLine("Su İçildi!");
    }
}
*/

