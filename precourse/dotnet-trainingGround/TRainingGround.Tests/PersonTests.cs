using TrainingGround;

namespace TrainingGround.Tests;

public class PersonTests
{
    [Fact]
    public void while_loop()
    {
    // arrange
    var ints = new int[] { 1, 2, 3, 4, 5 };

    // act
    var i = 0;
    while (i < ints.Length)
    {
        var currentValueInTheLoop = ints[i];

        Console.WriteLine($"i is now '{i}'");
        Console.WriteLine($"currentValueInTheLoop is now '{currentValueInTheLoop}'");

        // assert
        Assert.Equal(i + 1, currentValueInTheLoop);

        i = i + 1;
    }
    }
    // Person p = new Person("Tom", 2000, 1.34);

    // [Fact]
    // public void an_employee_gets_a_nice_printed_address()
    // {
    // // arrange
    // var emp = new Employee("Marcus", "234-BDAS");
    // emp.Address = new Address();
    // emp.Address.Street = "A Street";
    // emp.Address.StreetNo = 23;
    // emp.Address.City = "Stockholm";

    // // act
    // var printString = emp.GetPrintString();

    // // assert
    // Assert.Equal(@"Marcus (234-BDAS)
    // A Street 23
    // Stockholm
    // ", printString);
    // }
    // [Fact]
    // public void a_person_has_an_address()
    // {
    // // arrange
    // var pers = new Person("Marcus");

    // // act
    // pers.Address = new Address("A Street", 23, "Stockholm");

    // // assert
    // Assert.NotNull(pers.Address);
    // Assert.IsType<Address>(pers.Address);

    // Assert.Equal("A Street", pers.Address.Street);
    // Assert.Equal(23, pers.Address.StreetNo);
    // Assert.Equal("Stockholm", pers.Address.City);
    // }

    // [Fact]
    // public void can_print_printables()
    // {
    // // arrange
    // Employee emp = new Employee("Ossian", "234-BDAS");
    // Address theEmpAddress = new Address("B Street", 22, "Malmö");
    // emp.Address = theEmpAddress;

    // Person p = new Person("Marcus");
    // Address thePersonAddress = new Address("A Street", 23, "Stockholm");
    // p.Address = thePersonAddress;

    // // act
    // this.Print(p);
    // this.Print(emp);
    // }
    
    public void Print(IPrintable printable) {
    var printString = printable.GetPrintString();
    Console.WriteLine(printString);
    }
    [Fact]
    public void an_employee_has_an_employeeId()
    {
    // act
    var emp = new Employee("Marcus", "234-BDAS");

    // assert
    Assert.IsType<Employee>(emp);
    Assert.Equal("Marcus", emp.Name);
    Assert.Equal("234-BDAS", emp.EmployeeId);
    }
    [Fact]
    public void an_employee_is_a_person()
    {
    // act
    var emp = new Employee();
    emp.LengthInMeters = 1.95;

    // assert
    Assert.IsType<Employee>(emp);
    Assert.Equal(1.95, emp.LengthInMeters);
    }

    [Fact]
    public void create_person_using_params()
    {
        Person p = new Person("Tom", 2000, 1.34);
        Assert.NotNull(p);
        Assert.Equal("Tom",p.Name);
        Assert.Equal(2000, p.BirthYear);
        Assert.Equal(1.34, p.LengthInMeters);
        int age = p.getAge();
        Assert.Equal(22,age);
    }
    [Fact]
    public void test_the_age_of_someone_born_in_some_year()
    {
        Person p = new Person("Tom", 2000, 1.34);
        p.BirthYear = 1982;
        Assert.Equal(40,p.getAge());

        p.BirthYear = 1992;
        Assert.Equal(30,p.getAge());

        p.BirthYear = 2022;
        Assert.Equal(0,p.getAge());
    }
    
    [Theory]
    [MemberData(nameof(cucc))]
    public void getAge_works_well_theory(int birthYear, int expected)
    {
        Person p = new Person("Tom", 2000, 1.34);
        p.BirthYear = birthYear;
        Assert.Equal(expected,p.getAge());
    }
    public static IEnumerable<object[]> cucc =>
    new List<object[]>
    {
        new object[] {2000,22},
        new object[] {2020,2},
        new object[] {1989,33}
    };
    
    // [Theory]
    // [ClassData(typeof (getAgeWorksWellData))]
    // public void getAge_works_well_theory(int birthYear, int expected)
    // {
    //     p.BirthYear = birthYear;
    //     Assert.Equal(expected,p.getAge());
    // }
    [Fact]
    public void test_the_age_of_someone_born_in_1982()
    {
        int age = AgeCalculator.getAge(1982, 2022);
        Assert.Equal(40,age);
    }
    // [Fact]
    // public void test_the_age_of_someone_born_in_1992()
    // {
    //     // uses custom person
    //     p.BirthYear = 1992;
    //     int age = p.getAge();
    //     Assert.Equal(30,age);
    // }
    // [Fact]
    // public void test_the_age_of_someone_born_in_2022()
    // {
    //     // uses custom person
    //     p.BirthYear = 2022;
    //     int age = p.getAge();
    //     Assert.Equal(0,age);
    // }
}