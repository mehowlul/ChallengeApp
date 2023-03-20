namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void GetUserShouldReturnDifferentObjects()
        {
            // arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");
            // act
            // assert
            Assert.AreNotEqual(user1, user2);
        }
        [Test]
        public void TwoStringsAreEqual()
        {
            // arrange
            string name1 = "Ewa";
            string name2 = "Ewa";
            // act
            // assert
            Assert.AreEqual(name1, name2);
        }
        [Test]
        public void TwoIntegerNumbersAreEqual()
        {
            // arrange
            int int_number1 = 123;
            int int_number2 = 123;
            // act
            // assert
            Assert.AreEqual(int_number1, int_number2);
        }
        [Test]
        public void TwofloatNumbersAreNotEqual()
        {
            // arrange
            float number1 = 1.56f;
            float number2 = 1.65f;
            // act
            // assert
            Assert.AreNotEqual(number1, number2);
        }
        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}
