namespace ZooManager.Tests;
using NSubstitute;

public class ZooTest
{
    [Fact]
    public void AddAnimal_AddsHealthy()
    {
        IVeterinaryClinic clinic = new VeterinaryClinic();
        IZooRepository repository = new ZooRepository();
        IOutput output = Substitute.For<IOutput>();
        var zoo = new Zoo(repository, clinic, output);
        
        var tiger = new Tiger("Тигр", 6, true);
        zoo.AddAnimal(tiger);
        
        var monkey = new Monkey("Обезьяна", 4, 3, true);
        zoo.AddAnimal(monkey);
        
        Assert.Contains(tiger, repository.GetAnimals());
        Assert.Contains(monkey, repository.GetAnimals());
    }
    
    [Fact]
    public void AddAnimal_NotAddsUnhealthy()
    {
        IVeterinaryClinic clinic = new VeterinaryClinic();
        IZooRepository repository = new ZooRepository();
        IOutput output = Substitute.For<IOutput>();
        var zoo = new Zoo(repository, clinic, output);
        
        var tiger = new Tiger("Тигр", 6, false);
        zoo.AddAnimal(tiger);
        
        var monkey = new Monkey("Обезьяна", 4, 3, false);
        zoo.AddAnimal(monkey);
        
        Assert.DoesNotContain(tiger, repository.GetAnimals());
        Assert.DoesNotContain(monkey, repository.GetAnimals());
    }
    
    [Fact]
    public void AddThing_Adds()
    {
        IVeterinaryClinic clinic = new VeterinaryClinic();
        IZooRepository repository = new ZooRepository();
        IOutput output = Substitute.For<IOutput>();
        var zoo = new Zoo(repository, clinic, output);
        
        var pc = new Computer(6, "PC");
        zoo.AddThing(pc);
        
        Assert.Contains(pc, repository.GetThings());
    }
}