using TrainingGround;

namespace TRainingGround.Tests;


public class AgeCalculatorTests
{
    // public AgeCalculator _calc;
    // public AgeCalculatorTests()
    // {
    //     _calc = new AgeCalculator();
    // }
    [Fact]
    public void someone_born_1972_is_50_in_2022()
    {
        var age = AgeCalculator.getAge(1972, 2022);
        Assert.Equal(50, age);
    }
    
    [Fact]
    public void someone_born_in_2022_is_0_in_2022() {
        var age = AgeCalculator.getAge(2022, 2022);
        Assert.Equal(0, age);
    }
}