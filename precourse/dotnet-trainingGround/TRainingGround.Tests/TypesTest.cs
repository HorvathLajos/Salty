namespace TrainingGround.Tests;

public class TypesTest
{
    [Fact]
    public void reference_types_can_be_changed_via_reference()
    {
        Person a = new Person("Person A", 2000, 1.80);
        Person b = a;
        b.LengthInMeters = 1.70;
        Assert.Equal(1.70, b.LengthInMeters);
        Assert.Equal(1.70, a.LengthInMeters);
    }

    [Fact]
    public void getting_age_from_person()
    {
    // arrange
    var p = new Person("Tom", 1972, 1.8);

    // act
    var age = p.getAge();

    // assert
    Assert.Equal(50, age);
    Assert.IsType<Person>(p);
    Assert.IsType<int>(age);
    }
}