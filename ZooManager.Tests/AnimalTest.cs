namespace ZooManager.Tests
{
    public class AnimalTest
    {
        [Fact]
        public void Predator_Constructor_SetsProperties()
        {
            var tiger = new Tiger("Тигр", 6, true);
            
            Assert.Equal("Тигр", tiger.Name);
            Assert.Equal(6, tiger.Food);
            Assert.True(tiger.IsHealthy);
        }
        
        [Fact]
        public void Herbal_Constructor_SetsProperties()
        {
            var rabbit = new Rabbit("Кролик", 3, 8, true);
            
            Assert.Equal("Кролик", rabbit.Name);
            Assert.Equal(3, rabbit.Food);
            Assert.Equal(8, rabbit.Kindness);
            Assert.True(rabbit.IsHealthy);
        }
        
        [Fact]
        public void Predator_Constructor_ThrowsException_WhenFoodIsNegative()
        {
            Assert.Throws<ArgumentException>(() => new Tiger("Тигр", -1, true));
        }
        
        [Fact]
        public void Herbal_Constructor_ThrowsException_WhenFoodIsNegative()
        {
            Assert.Throws<ArgumentException>(() => new Rabbit("Кролик", -1, 8, true));
        }
        
        [Fact]
        public void Herbal_Constructor_ThrowsException_WhenKindnessIsNegative()
        {
            Assert.Throws<ArgumentException>(() => new Rabbit("Кролик", 3, -1, true));
        }
    }
}