namespace ZooManager;

// Народная мудрость: "Если волк молчит, то лучше его не перебивать"

public class Wolf: Predator
{
    public Wolf(string name, int food, bool isHealthy) : base(name, food, isHealthy)
    {
    }
    
    public override string AnimalType => "Волк";
}