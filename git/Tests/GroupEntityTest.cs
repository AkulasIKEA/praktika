using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class GroupEntityTests
{
    [TestMethod]
    public void GroupEntity_Initialization_ShouldSucceed()
    {
        // Arrange
        string id = "1";
        string name = "Group 1";

        // Act
        var group = new GroupEntity(id, name);

        // Assert
        Assert.IsNotNull(group);
        Assert.AreEqual(id, group.ID);
        Assert.AreEqual(name, group.Name);
    }
}
