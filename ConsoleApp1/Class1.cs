using System;



public abstract class Bird
{

    private string featherColor;
    private double weight;

    public Bird(double weight,string featherColor)
    {
        this.featherColor = featherColor;
        this.weight = weight;
    }

    public abstract void Fly();
}

public class Woodpecker : Bird
{

    public Woodpecker(double weight,string featherColor) : base(weight,featherColor)
    {
        
    }

    public override void Fly()
    {
        Console.WriteLine("Woodpecker is flying...");
    }
}

public class Penguin : Bird
{

    public Penguin(double weight, string featherColor) : base(weight, featherColor)
    {

    }


    public override void Fly()
    {
        throw new InvalidOperationException("Penguins cannot fly.");
    }
}

public class BirdWatcher
{
    public void WatchBirdFly(Bird bird)
    {
        bird.Fly();
    }
}

class Program
{
    static void Main()
    {
        BirdWatcher birdWatcher = new BirdWatcher();


        Bird bird = new Penguin(56.57,"white");

        Bird bird2 = new Woodpecker(2.34, "orange");

        birdWatcher.WatchBirdFly(bird);
        birdWatcher.WatchBirdFly(bird2);
    }
}