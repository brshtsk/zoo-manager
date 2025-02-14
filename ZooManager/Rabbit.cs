namespace ZooManager;

public class Rabbit: Herbo
{
    public Rabbit(string name, int food, int kindness, bool isHealthy) : base(name, food, kindness, isHealthy)
    {
    }
    
    public override string AnimalType => "Кролик";
}