namespace ZooManager;

public class ZooRepository: IZooRepository
{
    private readonly List<Animal> _animals;
    private readonly List<Thing> _things;

    public ZooRepository()
    {
        _animals = new List<Animal>();
        _things = new List<Thing>();
    }
    
    public void AddAnimal(Animal animal)
    {
        if (animal == null)
        {
            throw new ArgumentNullException();
        }
        _animals.Add(animal);
    }
    
    public void AddThing(Thing thing)
    {
        if (thing == null)
        {
            throw new ArgumentNullException();
        }
        _things.Add(thing);
    }
    
    public IEnumerable<Animal> GetAnimals()
    {
        return _animals;
    }
    
    public IEnumerable<Animal> GetContactAnimals()
    {
        List<Animal> contactAnimals = new();
        foreach (Animal animal in _animals)
        {
            if (animal is Herbo)
            {
                if (((Herbo)animal).Kindness > 5)
                {
                    contactAnimals.Add(animal);
                }
            }
        }
        return contactAnimals;
    }
    
    public IEnumerable<Thing> GetThings()
    {
        return _things;
    }
}