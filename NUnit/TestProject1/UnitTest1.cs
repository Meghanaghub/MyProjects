using demo;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
    
        [Test]
        public void WhetherStdNameCorrect()
        {
            //Arrange
            var testStudent = new Student()
            {
                Id = 1,
                Name = "John",
                Standard = 1,
                Marks = 150
            };

            //Act
            var expected = "John";
            var actual = testStudent.Name;

            //Assert
            Assert.AreSame(actual,expected);
        }
    }
}