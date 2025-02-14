namespace ZooManager;

public class ConsoleOutput: IOutput
{
    private void WriteAnimalsAmount(int amount)
    {
        Console.WriteLine($"В зоопарке {amount} животных.");
    }
    
    private void WriteDailyFoodAmount(int amount)
    {
        Console.WriteLine($"Ежедневно животные съедают {amount} кг корма.");
    }
    
    public void WriteAnimalsAndFoodAmount(int animalsAmount, int foodAmount)
    {
        WriteAnimalsAmount(animalsAmount);
        WriteDailyFoodAmount(foodAmount);
        Console.WriteLine();
    }
    
    public void WriteAllAnimalsList(IEnumerable<Animal> animals)
    {
        Console.WriteLine("Список всех животных:");
        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }
        Console.WriteLine();
    }
    
    public void WriteContactAnimalsList(IEnumerable<Animal> animals)
    {
        Console.WriteLine("Список ивотных, которые можно поместить в контактный зоопарк:");
        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }
        Console.WriteLine();
    }
    
    public void WriteThingsList(IEnumerable<Thing> things)
    {
        Console.WriteLine("Список инвентаря на учете зоопарка:");
        foreach (var thing in things)
        {
            Console.WriteLine(thing);
        }
        Console.WriteLine();
    }
    
    public void WriteError(string message)
    {
        Console.WriteLine($"Ошибка: {message}");
        Console.WriteLine();
    }
}