using ZooManager;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
    .AddSingleton<IZooRepository, ZooRepository>()
    .AddSingleton<IVeterinaryClinic, VeterinaryClinic>()
    .AddSingleton<IOutput, ConsoleOutput>()
    .AddSingleton<IZoo, Zoo>()
    .BuildServiceProvider();

var zoo = serviceProvider.GetService<IZoo>();

zoo.AddAnimal(new Rabbit("Крол",2, 10, true));
zoo.AddAnimal(new Wolf("Антон", 5, true));
zoo.AddAnimal(new Monkey("Австралопитек старший", 4, 6, false));
zoo.AddAnimal(new Monkey("Австралопитек младший", 3, 2, true));
zoo.AddAnimal(new Tiger("Танк", 7, true));

zoo.AddThing(new Computer(12, "Asus Ultrabook PRO 52-gen"));
zoo.AddThing(new Computer(3, "MacBook Air (2077)"));
zoo.AddThing(new Table(4, "Обеденный стол для австралопитеков 'Люкс'"));

zoo.ReportAnimalsAndFoodAmount();
zoo.ReportAllAnimalsList();
zoo.ReportContactAnimalsList();
zoo.ReportThingsList();