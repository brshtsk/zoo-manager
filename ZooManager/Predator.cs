namespace ZooManager;

public abstract class Predator: Animal
{
    public Predator(string name, int food, bool isHealthy) : base(name, food, isHealthy)
    {
    }
}