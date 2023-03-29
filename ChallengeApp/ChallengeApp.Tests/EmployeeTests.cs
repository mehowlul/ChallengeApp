namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenGetStatisticsIsUsed_ShouldReturnCorrectAverage()
        {
            // arrange
            var employee = new Employee();
            employee.AddGrade('e');
            employee.AddGrade(40);
            employee.AddGrade('C');
            employee.AddGrade("80");

            // act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(50, statistics.Average);
        }

        [Test]
        public void WhenGetStatisticsIsUsed_ShouldReturnCorrectMin()
        {
            // arrange
            var employee = new Employee();
            employee.AddGrade('e');
            employee.AddGrade(40);
            employee.AddGrade('C');
            employee.AddGrade("80");

            // act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(20, statistics.Min);
        }

        [Test]
        public void WhenGetStatisticsIsUsed_ShouldReturnCorrectMax()
        {
            // arrange
            var employee = new Employee();
            employee.AddGrade('e');
            employee.AddGrade(40);
            employee.AddGrade('C');
            employee.AddGrade("80");

            // act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(80, statistics.Max);
        }

        [Test]
        public void WhenGetStatisticsIsUsed_ShouldReturnCorrectAverageLetter()
        {
            // arrange
            var employee = new Employee();
            employee.AddGrade('e');
            employee.AddGrade(40);
            employee.AddGrade('C');
            employee.AddGrade("80");

            // act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual('C', statistics.AverageLetter);
        }
    }
}