using System;


//What is the difference between abstract classes and interfaces?


public interface Canlilar
{
	public void SolunumYap();
	public void Beslen();
	public void UyarilaraTepkiVer();
}





public abstract class Kalem
{
	private string Renk;
	private double Uzunluk;


	public void Ciz()
	{
		Console.WriteLine("Kalem bir şeyler çizdi");
	}
}
