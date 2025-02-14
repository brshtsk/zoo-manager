namespace ZooManager;

public abstract class Thing : IInventory
{
    public int Number { get; set; }
    public string Name { get; set; }
    public abstract string ThingType { get; }
    
    public Thing(int number, string name)
    {
        if (number >= 0)
        {
            Number = number;
        }
        else
        {
            throw new ArgumentException();
        }
        Name = name;
    }
    
    public override string ToString()
    {
        return $"{ThingType} с названием '{Name}'. Номер инвентаризации: {Number}";
    }
}