namespace ZooManager;

public interface IOutput
{
    public void WriteAnimalsAndFoodAmount(int animalsAmount, int foodAmount);
    public void WriteAllAnimalsList(IEnumerable<Animal> animals);
    public void WriteContactAnimalsList(IEnumerable<Animal> animals);
    public void WriteThingsList(IEnumerable<Thing> things);
    public void WriteError(string message);
}