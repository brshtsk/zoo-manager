namespace ZooManager.Tests;

public class InventoryTest
{
    [Fact]
    public void Constructor_SetsProperties()
    {
        var pc = new Computer(6, "PC");
            
        Assert.Equal(6, pc.Number);
        Assert.Equal("PC", pc.Name);
    }
    
    [Fact]
    public void Constructor_ThrowsException_WhenNumberIsNegative()
    {
        Assert.Throws<ArgumentException>(() => new Computer(-1, "PC"));
    }
}