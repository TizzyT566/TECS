namespace TECS;

/// <summary>
/// Provides components methods for entities.
/// </summary>
public static class System
{
    public static void Components<C>(this Entity e, out C c)
        where C : Component<C>, new()
    {
        c = Component<C>.GetOrAdd(e);
    }

    public static void Components<C1, C2>(this Entity e, out C1 c1, out C2 c2)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
    {
        c1 = Component<C1>.GetOrAdd(e);
        c2 = Component<C2>.GetOrAdd(e);
    }

    public static void Components<C1, C2, C3>(this Entity e, out C1 c1, out C2 c2, out C3 c3)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
        where C3 : Component<C3>, new()
    {
        c1 = Component<C1>.GetOrAdd(e);
        c2 = Component<C2>.GetOrAdd(e);
        c3 = Component<C3>.GetOrAdd(e);
    }

    public static void Components<C1, C2, C3, C4>(this Entity e, out C1 c1, out C2 c2, out C3 c3, out C4 c4)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
        where C3 : Component<C3>, new()
        where C4 : Component<C4>, new()
    {
        c1 = Component<C1>.GetOrAdd(e);
        c2 = Component<C2>.GetOrAdd(e);
        c3 = Component<C3>.GetOrAdd(e);
        c4 = Component<C4>.GetOrAdd(e);
    }

    public static void Components<C1, C2, C3, C4, C5>(this Entity e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
        where C3 : Component<C3>, new()
        where C4 : Component<C4>, new()
        where C5 : Component<C5>, new()
    {
        c1 = Component<C1>.GetOrAdd(e);
        c2 = Component<C2>.GetOrAdd(e);
        c3 = Component<C3>.GetOrAdd(e);
        c4 = Component<C4>.GetOrAdd(e);
        c5 = Component<C5>.GetOrAdd(e);
    }

    public static void Components<C1, C2, C3, C4, C5, C6>(this Entity e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
        where C3 : Component<C3>, new()
        where C4 : Component<C4>, new()
        where C5 : Component<C5>, new()
        where C6 : Component<C6>, new()
    {
        c1 = Component<C1>.GetOrAdd(e);
        c2 = Component<C2>.GetOrAdd(e);
        c3 = Component<C3>.GetOrAdd(e);
        c4 = Component<C4>.GetOrAdd(e);
        c5 = Component<C5>.GetOrAdd(e);
        c6 = Component<C6>.GetOrAdd(e);
    }

    public static void Components<C1, C2, C3, C4, C5, C6, C7>(this Entity e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
        where C3 : Component<C3>, new()
        where C4 : Component<C4>, new()
        where C5 : Component<C5>, new()
        where C6 : Component<C6>, new()
        where C7 : Component<C7>, new()
    {
        c1 = Component<C1>.GetOrAdd(e);
        c2 = Component<C2>.GetOrAdd(e);
        c3 = Component<C3>.GetOrAdd(e);
        c4 = Component<C4>.GetOrAdd(e);
        c5 = Component<C5>.GetOrAdd(e);
        c6 = Component<C6>.GetOrAdd(e);
        c7 = Component<C7>.GetOrAdd(e);
    }

    public static void Components<C1, C2, C3, C4, C5, C6, C7, C8>(this Entity e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7, out C8 c8)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
        where C3 : Component<C3>, new()
        where C4 : Component<C4>, new()
        where C5 : Component<C5>, new()
        where C6 : Component<C6>, new()
        where C7 : Component<C7>, new()
        where C8 : Component<C8>, new()
    {
        c1 = Component<C1>.GetOrAdd(e);
        c2 = Component<C2>.GetOrAdd(e);
        c3 = Component<C3>.GetOrAdd(e);
        c4 = Component<C4>.GetOrAdd(e);
        c5 = Component<C5>.GetOrAdd(e);
        c6 = Component<C6>.GetOrAdd(e);
        c7 = Component<C7>.GetOrAdd(e);
        c8 = Component<C8>.GetOrAdd(e);
    }

    public static void Components<C1, C2, C3, C4, C5, C6, C7, C8, C9>(this Entity e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7, out C8 c8, out C9 c9)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
        where C3 : Component<C3>, new()
        where C4 : Component<C4>, new()
        where C5 : Component<C5>, new()
        where C6 : Component<C6>, new()
        where C7 : Component<C7>, new()
        where C8 : Component<C8>, new()
        where C9 : Component<C9>, new()
    {
        c1 = Component<C1>.GetOrAdd(e);
        c2 = Component<C2>.GetOrAdd(e);
        c3 = Component<C3>.GetOrAdd(e);
        c4 = Component<C4>.GetOrAdd(e);
        c5 = Component<C5>.GetOrAdd(e);
        c6 = Component<C6>.GetOrAdd(e);
        c7 = Component<C7>.GetOrAdd(e);
        c8 = Component<C8>.GetOrAdd(e);
        c9 = Component<C9>.GetOrAdd(e);
    }

    public static void Components<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10>(this Entity e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7, out C8 c8, out C9 c9, out C10 c10)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
        where C3 : Component<C3>, new()
        where C4 : Component<C4>, new()
        where C5 : Component<C5>, new()
        where C6 : Component<C6>, new()
        where C7 : Component<C7>, new()
        where C8 : Component<C8>, new()
        where C9 : Component<C9>, new()
        where C10 : Component<C10>, new()
    {
        c1 = Component<C1>.GetOrAdd(e);
        c2 = Component<C2>.GetOrAdd(e);
        c3 = Component<C3>.GetOrAdd(e);
        c4 = Component<C4>.GetOrAdd(e);
        c5 = Component<C5>.GetOrAdd(e);
        c6 = Component<C6>.GetOrAdd(e);
        c7 = Component<C7>.GetOrAdd(e);
        c8 = Component<C8>.GetOrAdd(e);
        c9 = Component<C9>.GetOrAdd(e);
        c10 = Component<C10>.GetOrAdd(e);
    }

    public static void Components<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11>(this Entity e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7, out C8 c8, out C9 c9, out C10 c10, out C11 c11)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
        where C3 : Component<C3>, new()
        where C4 : Component<C4>, new()
        where C5 : Component<C5>, new()
        where C6 : Component<C6>, new()
        where C7 : Component<C7>, new()
        where C8 : Component<C8>, new()
        where C9 : Component<C9>, new()
        where C10 : Component<C10>, new()
        where C11 : Component<C11>, new()
    {
        c1 = Component<C1>.GetOrAdd(e);
        c2 = Component<C2>.GetOrAdd(e);
        c3 = Component<C3>.GetOrAdd(e);
        c4 = Component<C4>.GetOrAdd(e);
        c5 = Component<C5>.GetOrAdd(e);
        c6 = Component<C6>.GetOrAdd(e);
        c7 = Component<C7>.GetOrAdd(e);
        c8 = Component<C8>.GetOrAdd(e);
        c9 = Component<C9>.GetOrAdd(e);
        c10 = Component<C10>.GetOrAdd(e);
        c11 = Component<C11>.GetOrAdd(e);
    }

    public static void Components<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12>(this Entity e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7, out C8 c8, out C9 c9, out C10 c10, out C11 c11, out C12 c12)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
        where C3 : Component<C3>, new()
        where C4 : Component<C4>, new()
        where C5 : Component<C5>, new()
        where C6 : Component<C6>, new()
        where C7 : Component<C7>, new()
        where C8 : Component<C8>, new()
        where C9 : Component<C9>, new()
        where C10 : Component<C10>, new()
        where C11 : Component<C11>, new()
        where C12 : Component<C12>, new()
    {
        c1 = Component<C1>.GetOrAdd(e);
        c2 = Component<C2>.GetOrAdd(e);
        c3 = Component<C3>.GetOrAdd(e);
        c4 = Component<C4>.GetOrAdd(e);
        c5 = Component<C5>.GetOrAdd(e);
        c6 = Component<C6>.GetOrAdd(e);
        c7 = Component<C7>.GetOrAdd(e);
        c8 = Component<C8>.GetOrAdd(e);
        c9 = Component<C9>.GetOrAdd(e);
        c10 = Component<C10>.GetOrAdd(e);
        c11 = Component<C11>.GetOrAdd(e);
        c12 = Component<C12>.GetOrAdd(e);
    }

    public static void Components<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13>(this Entity e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7, out C8 c8, out C9 c9, out C10 c10, out C11 c11, out C12 c12, out C13 c13)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
        where C3 : Component<C3>, new()
        where C4 : Component<C4>, new()
        where C5 : Component<C5>, new()
        where C6 : Component<C6>, new()
        where C7 : Component<C7>, new()
        where C8 : Component<C8>, new()
        where C9 : Component<C9>, new()
        where C10 : Component<C10>, new()
        where C11 : Component<C11>, new()
        where C12 : Component<C12>, new()
        where C13 : Component<C13>, new()
    {
        c1 = Component<C1>.GetOrAdd(e);
        c2 = Component<C2>.GetOrAdd(e);
        c3 = Component<C3>.GetOrAdd(e);
        c4 = Component<C4>.GetOrAdd(e);
        c5 = Component<C5>.GetOrAdd(e);
        c6 = Component<C6>.GetOrAdd(e);
        c7 = Component<C7>.GetOrAdd(e);
        c8 = Component<C8>.GetOrAdd(e);
        c9 = Component<C9>.GetOrAdd(e);
        c10 = Component<C10>.GetOrAdd(e);
        c11 = Component<C11>.GetOrAdd(e);
        c12 = Component<C12>.GetOrAdd(e);
        c13 = Component<C13>.GetOrAdd(e);
    }

    public static void Components<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14>(this Entity e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7, out C8 c8, out C9 c9, out C10 c10, out C11 c11, out C12 c12, out C13 c13, out C14 c14)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
        where C3 : Component<C3>, new()
        where C4 : Component<C4>, new()
        where C5 : Component<C5>, new()
        where C6 : Component<C6>, new()
        where C7 : Component<C7>, new()
        where C8 : Component<C8>, new()
        where C9 : Component<C9>, new()
        where C10 : Component<C10>, new()
        where C11 : Component<C11>, new()
        where C12 : Component<C12>, new()
        where C13 : Component<C13>, new()
        where C14 : Component<C14>, new()
    {
        c1 = Component<C1>.GetOrAdd(e);
        c2 = Component<C2>.GetOrAdd(e);
        c3 = Component<C3>.GetOrAdd(e);
        c4 = Component<C4>.GetOrAdd(e);
        c5 = Component<C5>.GetOrAdd(e);
        c6 = Component<C6>.GetOrAdd(e);
        c7 = Component<C7>.GetOrAdd(e);
        c8 = Component<C8>.GetOrAdd(e);
        c9 = Component<C9>.GetOrAdd(e);
        c10 = Component<C10>.GetOrAdd(e);
        c11 = Component<C11>.GetOrAdd(e);
        c12 = Component<C12>.GetOrAdd(e);
        c13 = Component<C13>.GetOrAdd(e);
        c14 = Component<C14>.GetOrAdd(e);
    }

    public static void Components<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15>(this Entity e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7, out C8 c8, out C9 c9, out C10 c10, out C11 c11, out C12 c12, out C13 c13, out C14 c14, out C15 c15)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
        where C3 : Component<C3>, new()
        where C4 : Component<C4>, new()
        where C5 : Component<C5>, new()
        where C6 : Component<C6>, new()
        where C7 : Component<C7>, new()
        where C8 : Component<C8>, new()
        where C9 : Component<C9>, new()
        where C10 : Component<C10>, new()
        where C11 : Component<C11>, new()
        where C12 : Component<C12>, new()
        where C13 : Component<C13>, new()
        where C14 : Component<C14>, new()
        where C15 : Component<C15>, new()
    {
        c1 = Component<C1>.GetOrAdd(e);
        c2 = Component<C2>.GetOrAdd(e);
        c3 = Component<C3>.GetOrAdd(e);
        c4 = Component<C4>.GetOrAdd(e);
        c5 = Component<C5>.GetOrAdd(e);
        c6 = Component<C6>.GetOrAdd(e);
        c7 = Component<C7>.GetOrAdd(e);
        c8 = Component<C8>.GetOrAdd(e);
        c9 = Component<C9>.GetOrAdd(e);
        c10 = Component<C10>.GetOrAdd(e);
        c11 = Component<C11>.GetOrAdd(e);
        c12 = Component<C12>.GetOrAdd(e);
        c13 = Component<C13>.GetOrAdd(e);
        c14 = Component<C14>.GetOrAdd(e);
        c15 = Component<C15>.GetOrAdd(e);
    }

    public static void Components<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16>(this Entity e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7, out C8 c8, out C9 c9, out C10 c10, out C11 c11, out C12 c12, out C13 c13, out C14 c14, out C15 c15, out C16 c16)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
        where C3 : Component<C3>, new()
        where C4 : Component<C4>, new()
        where C5 : Component<C5>, new()
        where C6 : Component<C6>, new()
        where C7 : Component<C7>, new()
        where C8 : Component<C8>, new()
        where C9 : Component<C9>, new()
        where C10 : Component<C10>, new()
        where C11 : Component<C11>, new()
        where C12 : Component<C12>, new()
        where C13 : Component<C13>, new()
        where C14 : Component<C14>, new()
        where C15 : Component<C15>, new()
        where C16 : Component<C16>, new()
    {
        c1 = Component<C1>.GetOrAdd(e);
        c2 = Component<C2>.GetOrAdd(e);
        c3 = Component<C3>.GetOrAdd(e);
        c4 = Component<C4>.GetOrAdd(e);
        c5 = Component<C5>.GetOrAdd(e);
        c6 = Component<C6>.GetOrAdd(e);
        c7 = Component<C7>.GetOrAdd(e);
        c8 = Component<C8>.GetOrAdd(e);
        c9 = Component<C9>.GetOrAdd(e);
        c10 = Component<C10>.GetOrAdd(e);
        c11 = Component<C11>.GetOrAdd(e);
        c12 = Component<C12>.GetOrAdd(e);
        c13 = Component<C13>.GetOrAdd(e);
        c14 = Component<C14>.GetOrAdd(e);
        c15 = Component<C15>.GetOrAdd(e);
        c16 = Component<C16>.GetOrAdd(e);
    }

    public static void RemoveComponents<C>(this Entity e)
        where C : Component<C>, new()
    {
        Component<C>.Remove(e);
    }

    public static void RemoveComponents<C1, C2>(this Entity e)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
    {
        Component<C1>.Remove(e);
        Component<C2>.Remove(e);
    }

    public static void RemoveComponents<C1, C2, C3>(this Entity e)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
        where C3 : Component<C3>, new()
    {
        Component<C1>.Remove(e);
        Component<C2>.Remove(e);
        Component<C3>.Remove(e);
    }

    public static void RemoveComponents<C1, C2, C3, C4>(this Entity e)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
        where C3 : Component<C3>, new()
        where C4 : Component<C4>, new()
    {
        Component<C1>.Remove(e);
        Component<C2>.Remove(e);
        Component<C3>.Remove(e);
        Component<C4>.Remove(e);
    }

    public static void RemoveComponents<C1, C2, C3, C4, C5>(this Entity e)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
        where C3 : Component<C3>, new()
        where C4 : Component<C4>, new()
        where C5 : Component<C5>, new()
    {
        Component<C1>.Remove(e);
        Component<C2>.Remove(e);
        Component<C3>.Remove(e);
        Component<C4>.Remove(e);
        Component<C5>.Remove(e);
    }

    public static void RemoveComponents<C1, C2, C3, C4, C5, C6>(this Entity e)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
        where C3 : Component<C3>, new()
        where C4 : Component<C4>, new()
        where C5 : Component<C5>, new()
        where C6 : Component<C6>, new()
    {
        Component<C1>.Remove(e);
        Component<C2>.Remove(e);
        Component<C3>.Remove(e);
        Component<C4>.Remove(e);
        Component<C5>.Remove(e);
        Component<C6>.Remove(e);
    }

    public static void RemoveComponents<C1, C2, C3, C4, C5, C6, C7>(this Entity e)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
        where C3 : Component<C3>, new()
        where C4 : Component<C4>, new()
        where C5 : Component<C5>, new()
        where C6 : Component<C6>, new()
        where C7 : Component<C7>, new()
    {
        Component<C1>.Remove(e);
        Component<C2>.Remove(e);
        Component<C3>.Remove(e);
        Component<C4>.Remove(e);
        Component<C5>.Remove(e);
        Component<C6>.Remove(e);
        Component<C7>.Remove(e);
    }

    public static void RemoveComponents<C1, C2, C3, C4, C5, C6, C7, C8>(this Entity e)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
        where C3 : Component<C3>, new()
        where C4 : Component<C4>, new()
        where C5 : Component<C5>, new()
        where C6 : Component<C6>, new()
        where C7 : Component<C7>, new()
        where C8 : Component<C8>, new()
    {
        Component<C1>.Remove(e);
        Component<C2>.Remove(e);
        Component<C3>.Remove(e);
        Component<C4>.Remove(e);
        Component<C5>.Remove(e);
        Component<C6>.Remove(e);
        Component<C7>.Remove(e);
        Component<C8>.Remove(e);
    }

    public static void RemoveComponents<C1, C2, C3, C4, C5, C6, C7, C8, C9>(this Entity e)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
        where C3 : Component<C3>, new()
        where C4 : Component<C4>, new()
        where C5 : Component<C5>, new()
        where C6 : Component<C6>, new()
        where C7 : Component<C7>, new()
        where C8 : Component<C8>, new()
        where C9 : Component<C9>, new()
    {
        Component<C1>.Remove(e);
        Component<C2>.Remove(e);
        Component<C3>.Remove(e);
        Component<C4>.Remove(e);
        Component<C5>.Remove(e);
        Component<C6>.Remove(e);
        Component<C7>.Remove(e);
        Component<C8>.Remove(e);
        Component<C9>.Remove(e);
    }

    public static void RemoveComponents<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10>(this Entity e)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
        where C3 : Component<C3>, new()
        where C4 : Component<C4>, new()
        where C5 : Component<C5>, new()
        where C6 : Component<C6>, new()
        where C7 : Component<C7>, new()
        where C8 : Component<C8>, new()
        where C9 : Component<C9>, new()
        where C10 : Component<C10>, new()
    {
        Component<C1>.Remove(e);
        Component<C2>.Remove(e);
        Component<C3>.Remove(e);
        Component<C4>.Remove(e);
        Component<C5>.Remove(e);
        Component<C6>.Remove(e);
        Component<C7>.Remove(e);
        Component<C8>.Remove(e);
        Component<C9>.Remove(e);
        Component<C10>.Remove(e);
    }

    public static void RemoveComponents<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11>(this Entity e)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
        where C3 : Component<C3>, new()
        where C4 : Component<C4>, new()
        where C5 : Component<C5>, new()
        where C6 : Component<C6>, new()
        where C7 : Component<C7>, new()
        where C8 : Component<C8>, new()
        where C9 : Component<C9>, new()
        where C10 : Component<C10>, new()
        where C11 : Component<C11>, new()
    {
        Component<C1>.Remove(e);
        Component<C2>.Remove(e);
        Component<C3>.Remove(e);
        Component<C4>.Remove(e);
        Component<C5>.Remove(e);
        Component<C6>.Remove(e);
        Component<C7>.Remove(e);
        Component<C8>.Remove(e);
        Component<C9>.Remove(e);
        Component<C10>.Remove(e);
        Component<C11>.Remove(e);
    }

    public static void RemoveComponents<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12>(this Entity e)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
        where C3 : Component<C3>, new()
        where C4 : Component<C4>, new()
        where C5 : Component<C5>, new()
        where C6 : Component<C6>, new()
        where C7 : Component<C7>, new()
        where C8 : Component<C8>, new()
        where C9 : Component<C9>, new()
        where C10 : Component<C10>, new()
        where C11 : Component<C11>, new()
        where C12 : Component<C12>, new()
    {
        Component<C1>.Remove(e);
        Component<C2>.Remove(e);
        Component<C3>.Remove(e);
        Component<C4>.Remove(e);
        Component<C5>.Remove(e);
        Component<C6>.Remove(e);
        Component<C7>.Remove(e);
        Component<C8>.Remove(e);
        Component<C9>.Remove(e);
        Component<C10>.Remove(e);
        Component<C11>.Remove(e);
        Component<C12>.Remove(e);
    }

    public static void RemoveComponents<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13>(this Entity e)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
        where C3 : Component<C3>, new()
        where C4 : Component<C4>, new()
        where C5 : Component<C5>, new()
        where C6 : Component<C6>, new()
        where C7 : Component<C7>, new()
        where C8 : Component<C8>, new()
        where C9 : Component<C9>, new()
        where C10 : Component<C10>, new()
        where C11 : Component<C11>, new()
        where C12 : Component<C12>, new()
        where C13 : Component<C13>, new()
    {
        Component<C1>.Remove(e);
        Component<C2>.Remove(e);
        Component<C3>.Remove(e);
        Component<C4>.Remove(e);
        Component<C5>.Remove(e);
        Component<C6>.Remove(e);
        Component<C7>.Remove(e);
        Component<C8>.Remove(e);
        Component<C9>.Remove(e);
        Component<C10>.Remove(e);
        Component<C11>.Remove(e);
        Component<C12>.Remove(e);
        Component<C13>.Remove(e);
    }

    public static void RemoveComponents<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14>(this Entity e)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
        where C3 : Component<C3>, new()
        where C4 : Component<C4>, new()
        where C5 : Component<C5>, new()
        where C6 : Component<C6>, new()
        where C7 : Component<C7>, new()
        where C8 : Component<C8>, new()
        where C9 : Component<C9>, new()
        where C10 : Component<C10>, new()
        where C11 : Component<C11>, new()
        where C12 : Component<C12>, new()
        where C13 : Component<C13>, new()
        where C14 : Component<C14>, new()
    {
        Component<C1>.Remove(e);
        Component<C2>.Remove(e);
        Component<C3>.Remove(e);
        Component<C4>.Remove(e);
        Component<C5>.Remove(e);
        Component<C6>.Remove(e);
        Component<C7>.Remove(e);
        Component<C8>.Remove(e);
        Component<C9>.Remove(e);
        Component<C10>.Remove(e);
        Component<C11>.Remove(e);
        Component<C12>.Remove(e);
        Component<C13>.Remove(e);
        Component<C14>.Remove(e);
    }

    public static void RemoveComponents<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15>(this Entity e)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
        where C3 : Component<C3>, new()
        where C4 : Component<C4>, new()
        where C5 : Component<C5>, new()
        where C6 : Component<C6>, new()
        where C7 : Component<C7>, new()
        where C8 : Component<C8>, new()
        where C9 : Component<C9>, new()
        where C10 : Component<C10>, new()
        where C11 : Component<C11>, new()
        where C12 : Component<C12>, new()
        where C13 : Component<C13>, new()
        where C14 : Component<C14>, new()
        where C15 : Component<C15>, new()
    {
        Component<C1>.Remove(e);
        Component<C2>.Remove(e);
        Component<C3>.Remove(e);
        Component<C4>.Remove(e);
        Component<C5>.Remove(e);
        Component<C6>.Remove(e);
        Component<C7>.Remove(e);
        Component<C8>.Remove(e);
        Component<C9>.Remove(e);
        Component<C10>.Remove(e);
        Component<C11>.Remove(e);
        Component<C12>.Remove(e);
        Component<C13>.Remove(e);
        Component<C14>.Remove(e);
        Component<C15>.Remove(e);
    }

    public static void RemoveComponents<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16>(this Entity e)
        where C1 : Component<C1>, new()
        where C2 : Component<C2>, new()
        where C3 : Component<C3>, new()
        where C4 : Component<C4>, new()
        where C5 : Component<C5>, new()
        where C6 : Component<C6>, new()
        where C7 : Component<C7>, new()
        where C8 : Component<C8>, new()
        where C9 : Component<C9>, new()
        where C10 : Component<C10>, new()
        where C11 : Component<C11>, new()
        where C12 : Component<C12>, new()
        where C13 : Component<C13>, new()
        where C14 : Component<C14>, new()
        where C15 : Component<C15>, new()
        where C16 : Component<C16>, new()
    {
        Component<C1>.Remove(e);
        Component<C2>.Remove(e);
        Component<C3>.Remove(e);
        Component<C4>.Remove(e);
        Component<C5>.Remove(e);
        Component<C6>.Remove(e);
        Component<C7>.Remove(e);
        Component<C8>.Remove(e);
        Component<C9>.Remove(e);
        Component<C10>.Remove(e);
        Component<C11>.Remove(e);
        Component<C12>.Remove(e);
        Component<C13>.Remove(e);
        Component<C14>.Remove(e);
        Component<C15>.Remove(e);
        Component<C16>.Remove(e);
    }
}