namespace ZooManager;

public class Monkey: Herbo
{
    public Monkey(string name, int food, int kindness, bool isHealthy) : base(name, food, kindness, isHealthy)
    {
    }
    
    public override string AnimalType => "Обезьяна";
}