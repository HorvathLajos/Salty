using System.Collections;

namespace TrainingGround.Tests
{
    internal class getAgeWorksWellData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {2000,22};
            yield return new object[] {2020,2};
            yield return new object[] {1989,33};
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}