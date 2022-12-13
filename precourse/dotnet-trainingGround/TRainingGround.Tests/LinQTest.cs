namespace TrainingGround;

public class LinQTest
{
    [Fact]
    public void find_15_plus_ints()
    {
        var theList = new List<int>() {1,2,300,4,5,20,28,445,12,13,3};
        var numsLarger = theList.FindAll(num=> num > 15);
        Assert.Equal(4, numsLarger.Count);
    }
}