namespace ZooManager;

public class Tiger: Predator
{
    public Tiger(string name, int food, bool isHealthy) : base(name, food, isHealthy)
    {
    }
    
    public override string AnimalType => "Тигр";
}