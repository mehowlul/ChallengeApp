namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeColletctsSetOfPoints_ShouldReturnCorrectResult()
        {
            // arrange
            var employee4 = new Employee("Kazimierz", "Wielki", 45);
            employee4.AddGrade(6);
            employee4.AddGrade(7);
            employee4.AddGrade(4);
            employee4.AddGrade(-2);
            employee4.AddGrade(-2); 

            // act
            var grade = employee4.AddGrade;

            //assert
           
        }
    }
}