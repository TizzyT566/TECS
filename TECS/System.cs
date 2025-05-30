using System.Runtime.CompilerServices;

namespace TECS;

/// <summary>
/// Provides methods to unpack components from entities.
/// </summary>
public static class System
{
    /// <summary>
    /// Extracts and assigns components attached to the specified entity.
    /// </summary>
    /// <remarks>This method retrieves components attached to the specified entity and assigns them to the
    /// provided output parameters. The entity must implement <see cref="IAttach{C}"/> for all component types
    /// specified.</remarks>
    public static void Unpack<E, C>(this E e, out C c)
        where E : Entity, IAttach<C>
        where C : class, IComponent, new()
    {
        c = Internal<E, C>.Get(e);
    }

    /// <summary>
    /// Extracts and assigns components attached to the specified entity.
    /// </summary>
    /// <remarks>This method retrieves components attached to the specified entity and assigns them to the
    /// provided output parameters. The entity must implement <see cref="IAttach{C}"/> for all component types
    /// specified.</remarks>
    public static void Unpack<E, C1, C2>(this E e, out C1 c1, out C2 c2)
        where E : Entity, IAttach<C1>, IAttach<C2>
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
    {
        c1 = Internal<E, C1>.Get(e);
        c2 = Internal<E, C2>.Get(e);
    }

    /// <summary>
    /// Extracts and assigns components attached to the specified entity.
    /// </summary>
    /// <remarks>This method retrieves components attached to the specified entity and assigns them to the
    /// provided output parameters. The entity must implement <see cref="IAttach{C}"/> for all component types
    /// specified.</remarks>
    public static void Unpack<E, C1, C2, C3>(this E e, out C1 c1, out C2 c2, out C3 c3)
        where E : Entity, IAttach<C1>, IAttach<C2>, IAttach<C3>
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
        where C3 : class, IComponent, new()
    {
        c1 = Internal<E, C1>.Get(e);
        c2 = Internal<E, C2>.Get(e);
        c3 = Internal<E, C3>.Get(e);
    }

    /// <summary>
    /// Extracts and assigns components attached to the specified entity.
    /// </summary>
    /// <remarks>This method retrieves components attached to the specified entity and assigns them to the
    /// provided output parameters. The entity must implement <see cref="IAttach{C}"/> for all component types
    /// specified.</remarks>
    public static void Unpack<E, C1, C2, C3, C4>(this E e, out C1 c1, out C2 c2, out C3 c3, out C4 c4)
        where E : Entity, IAttach<C1>, IAttach<C2>, IAttach<C3>, IAttach<C4>
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
        where C3 : class, IComponent, new()
        where C4 : class, IComponent, new()
    {
        c1 = Internal<E, C1>.Get(e);
        c2 = Internal<E, C2>.Get(e);
        c3 = Internal<E, C3>.Get(e);
        c4 = Internal<E, C4>.Get(e);
    }

    /// <summary>
    /// Extracts and assigns components attached to the specified entity.
    /// </summary>
    /// <remarks>This method retrieves components attached to the specified entity and assigns them to the
    /// provided output parameters. The entity must implement <see cref="IAttach{C}"/> for all component types
    /// specified.</remarks>
    public static void Unpack<E, C1, C2, C3, C4, C5>(this E e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5)
        where E : Entity, IAttach<C1>, IAttach<C2>, IAttach<C3>, IAttach<C4>, IAttach<C5>
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
        where C3 : class, IComponent, new()
        where C4 : class, IComponent, new()
        where C5 : class, IComponent, new()
    {
        c1 = Internal<E, C1>.Get(e);
        c2 = Internal<E, C2>.Get(e);
        c3 = Internal<E, C3>.Get(e);
        c4 = Internal<E, C4>.Get(e);
        c5 = Internal<E, C5>.Get(e);
    }

    /// <summary>
    /// Extracts and assigns components attached to the specified entity.
    /// </summary>
    /// <remarks>This method retrieves components attached to the specified entity and assigns them to the
    /// provided output parameters. The entity must implement <see cref="IAttach{C}"/> for all component types
    /// specified.</remarks>
    public static void Unpack<E, C1, C2, C3, C4, C5, C6>(this E e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6)
        where E : Entity, IAttach<C1>, IAttach<C2>, IAttach<C3>, IAttach<C4>, IAttach<C5>, IAttach<C6>
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
        where C3 : class, IComponent, new()
        where C4 : class, IComponent, new()
        where C5 : class, IComponent, new()
        where C6 : class, IComponent, new()
    {
        c1 = Internal<E, C1>.Get(e);
        c2 = Internal<E, C2>.Get(e);
        c3 = Internal<E, C3>.Get(e);
        c4 = Internal<E, C4>.Get(e);
        c5 = Internal<E, C5>.Get(e);
        c6 = Internal<E, C6>.Get(e);
    }

    /// <summary>
    /// Extracts and assigns components attached to the specified entity.
    /// </summary>
    /// <remarks>This method retrieves components attached to the specified entity and assigns them to the
    /// provided output parameters. The entity must implement <see cref="IAttach{C}"/> for all component types
    /// specified.</remarks>
    public static void Unpack<E, C1, C2, C3, C4, C5, C6, C7>(this E e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7)
        where E : Entity, IAttach<C1>, IAttach<C2>, IAttach<C3>, IAttach<C4>, IAttach<C5>, IAttach<C6>, IAttach<C7>
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
        where C3 : class, IComponent, new()
        where C4 : class, IComponent, new()
        where C5 : class, IComponent, new()
        where C6 : class, IComponent, new()
        where C7 : class, IComponent, new()
    {
        c1 = Internal<E, C1>.Get(e);
        c2 = Internal<E, C2>.Get(e);
        c3 = Internal<E, C3>.Get(e);
        c4 = Internal<E, C4>.Get(e);
        c5 = Internal<E, C5>.Get(e);
        c6 = Internal<E, C6>.Get(e);
        c7 = Internal<E, C7>.Get(e);
    }

    /// <summary>
    /// Extracts and assigns components attached to the specified entity.
    /// </summary>
    /// <remarks>This method retrieves components attached to the specified entity and assigns them to the
    /// provided output parameters. The entity must implement <see cref="IAttach{C}"/> for all component types
    /// specified.</remarks>
    public static void Unpack<E, C1, C2, C3, C4, C5, C6, C7, C8>(this E e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7, out C8 c8)
        where E : Entity, IAttach<C1>, IAttach<C2>, IAttach<C3>, IAttach<C4>, IAttach<C5>, IAttach<C6>, IAttach<C7>, IAttach<C8>
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
        where C3 : class, IComponent, new()
        where C4 : class, IComponent, new()
        where C5 : class, IComponent, new()
        where C6 : class, IComponent, new()
        where C7 : class, IComponent, new()
        where C8 : class, IComponent, new()
    {
        c1 = Internal<E, C1>.Get(e);
        c2 = Internal<E, C2>.Get(e);
        c3 = Internal<E, C3>.Get(e);
        c4 = Internal<E, C4>.Get(e);
        c5 = Internal<E, C5>.Get(e);
        c6 = Internal<E, C6>.Get(e);
        c7 = Internal<E, C7>.Get(e);
        c8 = Internal<E, C8>.Get(e);
    }

    /// <summary>
    /// Extracts and assigns components attached to the specified entity.
    /// </summary>
    /// <remarks>This method retrieves components attached to the specified entity and assigns them to the
    /// provided output parameters. The entity must implement <see cref="IAttach{C}"/> for all component types
    /// specified.</remarks>
    public static void Unpack<E, C1, C2, C3, C4, C5, C6, C7, C8, C9>(this E e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7, out C8 c8, out C9 c9)
        where E : Entity, IAttach<C1>, IAttach<C2>, IAttach<C3>, IAttach<C4>, IAttach<C5>, IAttach<C6>, IAttach<C7>, IAttach<C8>, IAttach<C9>
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
        where C3 : class, IComponent, new()
        where C4 : class, IComponent, new()
        where C5 : class, IComponent, new()
        where C6 : class, IComponent, new()
        where C7 : class, IComponent, new()
        where C8 : class, IComponent, new()
        where C9 : class, IComponent, new()
    {
        c1 = Internal<E, C1>.Get(e);
        c2 = Internal<E, C2>.Get(e);
        c3 = Internal<E, C3>.Get(e);
        c4 = Internal<E, C4>.Get(e);
        c5 = Internal<E, C5>.Get(e);
        c6 = Internal<E, C6>.Get(e);
        c7 = Internal<E, C7>.Get(e);
        c8 = Internal<E, C8>.Get(e);
        c9 = Internal<E, C9>.Get(e);
    }

    /// <summary>
    /// Extracts and assigns components attached to the specified entity.
    /// </summary>
    /// <remarks>This method retrieves components attached to the specified entity and assigns them to the
    /// provided output parameters. The entity must implement <see cref="IAttach{C}"/> for all component types
    /// specified.</remarks>
    public static void Unpack<E, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10>(this E e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7, out C8 c8, out C9 c9, out C10 c10)
        where E : Entity, IAttach<C1>, IAttach<C2>, IAttach<C3>, IAttach<C4>, IAttach<C5>, IAttach<C6>, IAttach<C7>, IAttach<C8>, IAttach<C9>, IAttach<C10>
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
        where C3 : class, IComponent, new()
        where C4 : class, IComponent, new()
        where C5 : class, IComponent, new()
        where C6 : class, IComponent, new()
        where C7 : class, IComponent, new()
        where C8 : class, IComponent, new()
        where C9 : class, IComponent, new()
        where C10 : class, IComponent, new()
    {
        c1 = Internal<E, C1>.Get(e);
        c2 = Internal<E, C2>.Get(e);
        c3 = Internal<E, C3>.Get(e);
        c4 = Internal<E, C4>.Get(e);
        c5 = Internal<E, C5>.Get(e);
        c6 = Internal<E, C6>.Get(e);
        c7 = Internal<E, C7>.Get(e);
        c8 = Internal<E, C8>.Get(e);
        c9 = Internal<E, C9>.Get(e);
        c10 = Internal<E, C10>.Get(e);
    }

    /// <summary>
    /// Extracts and assigns components attached to the specified entity.
    /// </summary>
    /// <remarks>This method retrieves components attached to the specified entity and assigns them to the
    /// provided output parameters. The entity must implement <see cref="IAttach{C}"/> for all component types
    /// specified.</remarks>
    public static void Unpack<E, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11>(this E e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7, out C8 c8, out C9 c9, out C10 c10, out C11 c11)
        where E : Entity, IAttach<C1>, IAttach<C2>, IAttach<C3>, IAttach<C4>, IAttach<C5>, IAttach<C6>, IAttach<C7>, IAttach<C8>, IAttach<C9>, IAttach<C10>, IAttach<C11>
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
        where C3 : class, IComponent, new()
        where C4 : class, IComponent, new()
        where C5 : class, IComponent, new()
        where C6 : class, IComponent, new()
        where C7 : class, IComponent, new()
        where C8 : class, IComponent, new()
        where C9 : class, IComponent, new()
        where C10 : class, IComponent, new()
        where C11 : class, IComponent, new()
    {
        c1 = Internal<E, C1>.Get(e);
        c2 = Internal<E, C2>.Get(e);
        c3 = Internal<E, C3>.Get(e);
        c4 = Internal<E, C4>.Get(e);
        c5 = Internal<E, C5>.Get(e);
        c6 = Internal<E, C6>.Get(e);
        c7 = Internal<E, C7>.Get(e);
        c8 = Internal<E, C8>.Get(e);
        c9 = Internal<E, C9>.Get(e);
        c10 = Internal<E, C10>.Get(e);
        c11 = Internal<E, C11>.Get(e);
    }

    /// <summary>
    /// Extracts and assigns components attached to the specified entity.
    /// </summary>
    /// <remarks>This method retrieves components attached to the specified entity and assigns them to the
    /// provided output parameters. The entity must implement <see cref="IAttach{C}"/> for all component types
    /// specified.</remarks>
    public static void Unpack<E, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12>(this E e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7, out C8 c8, out C9 c9, out C10 c10, out C11 c11, out C12 c12)
        where E : Entity, IAttach<C1>, IAttach<C2>, IAttach<C3>, IAttach<C4>, IAttach<C5>, IAttach<C6>, IAttach<C7>, IAttach<C8>, IAttach<C9>, IAttach<C10>, IAttach<C11>, IAttach<C12>
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
        where C3 : class, IComponent, new()
        where C4 : class, IComponent, new()
        where C5 : class, IComponent, new()
        where C6 : class, IComponent, new()
        where C7 : class, IComponent, new()
        where C8 : class, IComponent, new()
        where C9 : class, IComponent, new()
        where C10 : class, IComponent, new()
        where C11 : class, IComponent, new()
        where C12 : class, IComponent, new()
    {
        c1 = Internal<E, C1>.Get(e);
        c2 = Internal<E, C2>.Get(e);
        c3 = Internal<E, C3>.Get(e);
        c4 = Internal<E, C4>.Get(e);
        c5 = Internal<E, C5>.Get(e);
        c6 = Internal<E, C6>.Get(e);
        c7 = Internal<E, C7>.Get(e);
        c8 = Internal<E, C8>.Get(e);
        c9 = Internal<E, C9>.Get(e);
        c10 = Internal<E, C10>.Get(e);
        c11 = Internal<E, C11>.Get(e);
        c12 = Internal<E, C12>.Get(e);
    }

    /// <summary>
    /// Extracts and assigns components attached to the specified entity.
    /// </summary>
    /// <remarks>This method retrieves components attached to the specified entity and assigns them to the
    /// provided output parameters. The entity must implement <see cref="IAttach{C}"/> for all component types
    /// specified.</remarks>
    public static void Unpack<E, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13>(this E e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7, out C8 c8, out C9 c9, out C10 c10, out C11 c11, out C12 c12, out C13 c13)
        where E : Entity, IAttach<C1>, IAttach<C2>, IAttach<C3>, IAttach<C4>, IAttach<C5>, IAttach<C6>, IAttach<C7>, IAttach<C8>, IAttach<C9>, IAttach<C10>, IAttach<C11>, IAttach<C12>, IAttach<C13>
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
        where C3 : class, IComponent, new()
        where C4 : class, IComponent, new()
        where C5 : class, IComponent, new()
        where C6 : class, IComponent, new()
        where C7 : class, IComponent, new()
        where C8 : class, IComponent, new()
        where C9 : class, IComponent, new()
        where C10 : class, IComponent, new()
        where C11 : class, IComponent, new()
        where C12 : class, IComponent, new()
        where C13 : class, IComponent, new()
    {
        c1 = Internal<E, C1>.Get(e);
        c2 = Internal<E, C2>.Get(e);
        c3 = Internal<E, C3>.Get(e);
        c4 = Internal<E, C4>.Get(e);
        c5 = Internal<E, C5>.Get(e);
        c6 = Internal<E, C6>.Get(e);
        c7 = Internal<E, C7>.Get(e);
        c8 = Internal<E, C8>.Get(e);
        c9 = Internal<E, C9>.Get(e);
        c10 = Internal<E, C10>.Get(e);
        c11 = Internal<E, C11>.Get(e);
        c12 = Internal<E, C12>.Get(e);
        c13 = Internal<E, C13>.Get(e);
    }

    /// <summary>
    /// Extracts and assigns components attached to the specified entity.
    /// </summary>
    /// <remarks>This method retrieves components attached to the specified entity and assigns them to the
    /// provided output parameters. The entity must implement <see cref="IAttach{C}"/> for all component types
    /// specified.</remarks>
    public static void Unpack<E, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14>(this E e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7, out C8 c8, out C9 c9, out C10 c10, out C11 c11, out C12 c12, out C13 c13, out C14 c14)
        where E : Entity, IAttach<C1>, IAttach<C2>, IAttach<C3>, IAttach<C4>, IAttach<C5>, IAttach<C6>, IAttach<C7>, IAttach<C8>, IAttach<C9>, IAttach<C10>, IAttach<C11>, IAttach<C12>, IAttach<C13>, IAttach<C14>
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
        where C3 : class, IComponent, new()
        where C4 : class, IComponent, new()
        where C5 : class, IComponent, new()
        where C6 : class, IComponent, new()
        where C7 : class, IComponent, new()
        where C8 : class, IComponent, new()
        where C9 : class, IComponent, new()
        where C10 : class, IComponent, new()
        where C11 : class, IComponent, new()
        where C12 : class, IComponent, new()
        where C13 : class, IComponent, new()
        where C14 : class, IComponent, new()
    {
        c1 = Internal<E, C1>.Get(e);
        c2 = Internal<E, C2>.Get(e);
        c3 = Internal<E, C3>.Get(e);
        c4 = Internal<E, C4>.Get(e);
        c5 = Internal<E, C5>.Get(e);
        c6 = Internal<E, C6>.Get(e);
        c7 = Internal<E, C7>.Get(e);
        c8 = Internal<E, C8>.Get(e);
        c9 = Internal<E, C9>.Get(e);
        c10 = Internal<E, C10>.Get(e);
        c11 = Internal<E, C11>.Get(e);
        c12 = Internal<E, C12>.Get(e);
        c13 = Internal<E, C13>.Get(e);
        c14 = Internal<E, C14>.Get(e);
    }

    /// <summary>
    /// Extracts and assigns components attached to the specified entity.
    /// </summary>
    /// <remarks>This method retrieves components attached to the specified entity and assigns them to the
    /// provided output parameters. The entity must implement <see cref="IAttach{C}"/> for all component types
    /// specified.</remarks>
    public static void Unpack<E, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15>(this E e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7, out C8 c8, out C9 c9, out C10 c10, out C11 c11, out C12 c12, out C13 c13, out C14 c14, out C15 c15)
        where E : Entity, IAttach<C1>, IAttach<C2>, IAttach<C3>, IAttach<C4>, IAttach<C5>, IAttach<C6>, IAttach<C7>, IAttach<C8>, IAttach<C9>, IAttach<C10>, IAttach<C11>, IAttach<C12>, IAttach<C13>, IAttach<C14>, IAttach<C15>
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
        where C3 : class, IComponent, new()
        where C4 : class, IComponent, new()
        where C5 : class, IComponent, new()
        where C6 : class, IComponent, new()
        where C7 : class, IComponent, new()
        where C8 : class, IComponent, new()
        where C9 : class, IComponent, new()
        where C10 : class, IComponent, new()
        where C11 : class, IComponent, new()
        where C12 : class, IComponent, new()
        where C13 : class, IComponent, new()
        where C14 : class, IComponent, new()
        where C15 : class, IComponent, new()
    {
        c1 = Internal<E, C1>.Get(e);
        c2 = Internal<E, C2>.Get(e);
        c3 = Internal<E, C3>.Get(e);
        c4 = Internal<E, C4>.Get(e);
        c5 = Internal<E, C5>.Get(e);
        c6 = Internal<E, C6>.Get(e);
        c7 = Internal<E, C7>.Get(e);
        c8 = Internal<E, C8>.Get(e);
        c9 = Internal<E, C9>.Get(e);
        c10 = Internal<E, C10>.Get(e);
        c11 = Internal<E, C11>.Get(e);
        c12 = Internal<E, C12>.Get(e);
        c13 = Internal<E, C13>.Get(e);
        c14 = Internal<E, C14>.Get(e);
        c15 = Internal<E, C15>.Get(e);
    }

    /// <summary>
    /// Extracts and assigns components attached to the specified entity.
    /// </summary>
    /// <remarks>This method retrieves components attached to the specified entity and assigns them to the
    /// provided output parameters. The entity must implement <see cref="IAttach{C}"/> for all component types
    /// specified.</remarks>
    public static void Unpack<E, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16>(this E e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7, out C8 c8, out C9 c9, out C10 c10, out C11 c11, out C12 c12, out C13 c13, out C14 c14, out C15 c15, out C16 c16)
        where E : Entity, IAttach<C1>, IAttach<C2>, IAttach<C3>, IAttach<C4>, IAttach<C5>, IAttach<C6>, IAttach<C7>, IAttach<C8>, IAttach<C9>, IAttach<C10>, IAttach<C11>, IAttach<C12>, IAttach<C13>, IAttach<C14>, IAttach<C15>, IAttach<C16>
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
        where C3 : class, IComponent, new()
        where C4 : class, IComponent, new()
        where C5 : class, IComponent, new()
        where C6 : class, IComponent, new()
        where C7 : class, IComponent, new()
        where C8 : class, IComponent, new()
        where C9 : class, IComponent, new()
        where C10 : class, IComponent, new()
        where C11 : class, IComponent, new()
        where C12 : class, IComponent, new()
        where C13 : class, IComponent, new()
        where C14 : class, IComponent, new()
        where C15 : class, IComponent, new()
        where C16 : class, IComponent, new()
    {
        c1 = Internal<E, C1>.Get(e);
        c2 = Internal<E, C2>.Get(e);
        c3 = Internal<E, C3>.Get(e);
        c4 = Internal<E, C4>.Get(e);
        c5 = Internal<E, C5>.Get(e);
        c6 = Internal<E, C6>.Get(e);
        c7 = Internal<E, C7>.Get(e);
        c8 = Internal<E, C8>.Get(e);
        c9 = Internal<E, C9>.Get(e);
        c10 = Internal<E, C10>.Get(e);
        c11 = Internal<E, C11>.Get(e);
        c12 = Internal<E, C12>.Get(e);
        c13 = Internal<E, C13>.Get(e);
        c14 = Internal<E, C14>.Get(e);
        c15 = Internal<E, C15>.Get(e);
        c16 = Internal<E, C16>.Get(e);
    }

    internal static class Internal<E, C> where E : Entity, IAttach<C> where C : class, IComponent, new()
    {
        private static readonly ConditionalWeakTable<E, C> _entityComponents = new();

        internal static C Get(E entity) => _entityComponents.GetOrCreateValue(entity);
    }
}