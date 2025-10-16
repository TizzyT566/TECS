using System.Runtime.CompilerServices;

namespace TECS;

/// <summary>
/// Interface for components that can be attached to entities.
/// </summary>
public abstract class Component<TSelf>
    where TSelf : Component<TSelf>, new()
{
    private static readonly ConditionalWeakTable<Entity, TSelf> _EntityComponents = new();

    public static bool TryGet<E>(in E entity, TSelf c) where E : Entity
    {
        return _EntityComponents.TryGetValue(entity, out c);
    }

    public static TSelf GetOrAdd<E>(in E entity) where E : Entity
    {
        return _EntityComponents.GetOrCreateValue(entity);
    }

    public static void Remove<E>(in E entity) where E : Entity
    {
        _EntityComponents.Remove(entity);
    }
}