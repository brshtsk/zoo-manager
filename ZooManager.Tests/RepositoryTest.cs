namespace ZooManager.Tests;

public class RepositoryTest
{
    [Fact]
    public void AddAnimal_Adds()
    {
        var tiger = new Tiger("Тигр", 6, true);
        var repository = new ZooRepository();
        
        repository.AddAnimal(tiger);
        
        Assert.Contains(tiger, repository.GetAnimals());
    }
    
    [Fact]
    public void AddThing_Adds()
    {
        var pc = new Computer(6, "PC");
        var repository = new ZooRepository();
        
        repository.AddThing(pc);
        
        Assert.Contains(pc, repository.GetThings());
    }
    
    [Fact]
    public void GetContactAnimals_Filters_Correct()
    {
        var tiger = new Tiger("Тигр", 6, true);
        var rabbit = new Rabbit("Кролик", 3, 8, true);
        var maonkey = new Monkey("Обезьяна", 4, 3, true);
        var repository = new ZooRepository();
        
        repository.AddAnimal(tiger);
        repository.AddAnimal(rabbit);
        repository.AddAnimal(maonkey);
        
        Assert.Equal(1, repository.GetContactAnimals().ToList().Count);
    }
}