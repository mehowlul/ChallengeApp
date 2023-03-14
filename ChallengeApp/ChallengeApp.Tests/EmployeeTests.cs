namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeColletctsSetOfPoints_ShouldReturnCorrectResult()
        {
            // arrange
            var employee4 = new Employee("Kazimierz", "Wielki", 45);
            employee4.AddScore(6);
            employee4.AddScore(7);
            employee4.AddScore(4);
            employee4.AddScore(-2);
            employee4.AddScore(-2);                           ;
            
            // act
            var result = employee4.Result;

            // assert
            Assert.AreEqual(17, result);
        }
    }
}