namespace ZooManager;

public class Zoo: IZoo
{
    private readonly IZooRepository _repository;
    private readonly IVeterinaryClinic _veterinaryClinic;
    private readonly IOutput _output;
    
    public void AddAnimal(Animal animal)
    {
        try
        {
            if (_veterinaryClinic.CheckHealth(animal))
            {
                _repository.AddAnimal(animal);
            }
        }
        catch
        {
            _output.WriteError("Передано null значение.");
        }
    }
    
    public void AddThing(Thing thing)
    {
        try
        {
            _repository.AddThing(thing);
        }
        catch
        {
            _output.WriteError("Передано null значение.");
        }
    }
    
    public void ReportAnimalsAndFoodAmount()
    {
        int animalsAmount = _repository.GetAnimals().Count();
        int foodAmount = _repository.GetAnimals().Sum(animal => animal.Food);
        _output.WriteAnimalsAndFoodAmount(animalsAmount, foodAmount);
    }
    
    public void ReportAllAnimalsList()
    {
        _output.WriteAllAnimalsList(_repository.GetAnimals());
    }
    
    public void ReportContactAnimalsList()
    {
        _output.WriteContactAnimalsList(_repository.GetContactAnimals());
    }
    
    public void ReportThingsList()
    {
        _output.WriteThingsList(_repository.GetThings());
    }
    
    public Zoo(IZooRepository repository, IVeterinaryClinic veterinaryClinic, IOutput output)
    {
        _repository = repository;
        _veterinaryClinic = veterinaryClinic;
        _output = output;
    }
}