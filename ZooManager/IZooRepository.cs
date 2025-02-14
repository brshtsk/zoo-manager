namespace ZooManager;

public interface IZooRepository
{
    void AddAnimal(Animal animal);
    void AddThing(Thing thing);
    
    IEnumerable<Animal> GetAnimals();
    IEnumerable<Animal> GetContactAnimals();
    IEnumerable<Thing> GetThings();
}