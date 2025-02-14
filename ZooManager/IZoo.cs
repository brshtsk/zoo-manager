namespace ZooManager;

public interface IZoo
{
    public void AddAnimal(Animal animal);
    public void AddThing(Thing thing);
    public void ReportAnimalsAndFoodAmount();
    public void ReportAllAnimalsList();
    public void ReportContactAnimalsList();
    public void ReportThingsList();
}