namespace Subjects.Tests
{
    [TestClass]
    public class SubjectEntityTests
    {
        [TestMethod]
        public void SubjectEntity_Initialization_ShouldSucceed()
        {
            // Arrange
            var subject = new Subjects.Entities.SubjectEntity
            {
                SubjectName = "Math",
                TeacherName = "Jane Doe"
            };

            // Act
            string expectedSubjectName = "Math";
            string expectedTeacherName = "Jane Doe";

            // Assert
            Assert.AreEqual(expectedSubjectName, subject.SubjectName);
            Assert.AreEqual(expectedTeacherName, subject.TeacherName);
        }
    }
}