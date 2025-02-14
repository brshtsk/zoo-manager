namespace ZooManager.Tests;

public class VeterinaryClinicTest
{
    [Fact]
    public void ChechHealth_NotHealthy_DoesntPass()
    {
        var rabbit = new Rabbit("Кролик", 3, 8, false);
        var clinic = new VeterinaryClinic();
        
        Assert.False(clinic.CheckHealth(rabbit));
    }
    
    [Fact]
    public void ChechHealth_Healthy_Passes()
    {
        var rabbit = new Rabbit("Кролик", 3, 8, true);
        var clinic = new VeterinaryClinic();
        
        Assert.True(clinic.CheckHealth(rabbit));
    }
}