namespace ZooManager;

public class Computer: Thing
{
    public Computer(int number, string name): base(number, name)
    {
    }
    
    public override string ThingType => "Компьютер";
}