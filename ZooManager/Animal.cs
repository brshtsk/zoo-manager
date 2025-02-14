namespace ZooManager;

public abstract class Animal: IAlive
{
    public int Food { get; set; }
    public string Name { get; set; }
    public bool IsHealthy { get; set; }
    public abstract string AnimalType { get; }
    
    public Animal(string name, int food, bool isHealthy)
    {
        Name = name;
        if (food >= 0)
        {
            Food = food;
        }
        else
        {
            throw new ArgumentException();
        }
        IsHealthy = isHealthy;
    }

    public override string ToString()
    {
        return $"{AnimalType} по имени {Name}. Ест {Food} кг еды в день";
    }
}