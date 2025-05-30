using TECS;

EntityTest entity = new();
EntityTest2 entity2 = new();

Console.WriteLine(entity.Id);
Console.WriteLine(entity2.Id);

entity.Unpack(out ComponentTest component1, out ComponentTest2 component2);

public sealed class ComponentTest : IComponent
{
    public int Value { get; set; }
}
public sealed class ComponentTest2 : IComponent
{
    public int Value { get; set; }
}

public sealed class EntityTest : Entity, IAttach<ComponentTest>, IAttach<ComponentTest2>;
public sealed class EntityTest2 : Entity, IAttach<ComponentTest>, IAttach<ComponentTest2>
{
    public EntityTest2()
    {
        this.Unpack(out ComponentTest component1, out ComponentTest2 component2);
    }
}