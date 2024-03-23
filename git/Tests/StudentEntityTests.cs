namespace Students.Tests
{
    [TestClass]
    public class StudentEntityTests
    {
        [TestMethod]
        public void StudentEntity_Initialization_ShouldSucceed()
        {
            // Arrange
            var student = new Students.Entities.StudentEntity
            {
                Name = "John Doe",
                Age = 20,
                StudentID = 123456,
                Major = "Computer Science"
            };

            // Act
            string expectedName = "John Doe";
            int expectedAge = 20;
            int expectedStudentID = 123456;
            string expectedMajor = "Computer Science";

            // Assert
            Assert.AreEqual(expectedName, student.Name);
            Assert.AreEqual(expectedAge, student.Age);
            Assert.AreEqual(expectedStudentID, student.StudentID);
            Assert.AreEqual(expectedMajor, student.Major);
        }
    }
}