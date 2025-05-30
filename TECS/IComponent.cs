namespace TECS;

/// <summary>
/// Interface for components.
/// </summary>
public interface IComponent;

/// <summary>
/// Interface for attaching components to entities.
/// </summary>
/// <typeparam name="C"></typeparam>
public interface IAttach<C> where C : class, IComponent, new();