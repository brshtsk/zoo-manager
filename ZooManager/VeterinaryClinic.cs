namespace ZooManager;

public class VeterinaryClinic: IVeterinaryClinic
{
    public bool CheckHealth(Animal animal)
    {
        if (animal == null)
        {
            throw new ArgumentNullException();
        }
        return animal.IsHealthy;
    }
}