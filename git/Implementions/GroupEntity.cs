using Groups.Implementions;

namespace Groups.Implementions;

public class GroupEntity
{
    public string ID { get; set; }
    public string Name { get; set; }

    // ����������� ������ GroupEntity
    public GroupEntity(string id, string name)
    {
        ID = id;
        Name = name;
    }
}
