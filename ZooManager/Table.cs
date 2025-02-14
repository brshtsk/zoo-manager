namespace ZooManager;

public class Table: Thing
{
    public Table(int number, string name): base(number, name)
    {
    }
    
    public override string ThingType => "Стол";
}