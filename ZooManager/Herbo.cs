namespace ZooManager;

public abstract class Herbo: Animal
{
    public int Kindness { get; set; }

    public Herbo(string name, int food, int kindness, bool isHealthy) : base(name, food, isHealthy)
    {
        if (kindness >= 0 && kindness <= 10)
        {
            Kindness = kindness;
        }
        else
        {
            throw new ArgumentException();
        }
    }
}