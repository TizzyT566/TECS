using System.Runtime.CompilerServices;
using static TECS.System;

namespace TECS;

/// <summary>
/// Provides components methods for entities.
/// </summary>
public static class System
{
    public static void Components<C>(this Entity e, out C c)
        where C : class, IComponent, new()
    {
        c = Internal<C>.GetOrAdd(e);
    }

    public static void Components<C1, C2>(this Entity e, out C1 c1, out C2 c2)
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
    {
        c1 = Internal<C1>.GetOrAdd(e);
        c2 = Internal<C2>.GetOrAdd(e);
    }

    public static void Components<C1, C2, C3>(this Entity e, out C1 c1, out C2 c2, out C3 c3)
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
        where C3 : class, IComponent, new()
    {
        c1 = Internal<C1>.GetOrAdd(e);
        c2 = Internal<C2>.GetOrAdd(e);
        c3 = Internal<C3>.GetOrAdd(e);
    }

    public static void Components<C1, C2, C3, C4>(this Entity e, out C1 c1, out C2 c2, out C3 c3, out C4 c4)
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
        where C3 : class, IComponent, new()
        where C4 : class, IComponent, new()
    {
        c1 = Internal<C1>.GetOrAdd(e);
        c2 = Internal<C2>.GetOrAdd(e);
        c3 = Internal<C3>.GetOrAdd(e);
        c4 = Internal<C4>.GetOrAdd(e);
    }

    public static void Components<C1, C2, C3, C4, C5>(this Entity e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5)
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
        where C3 : class, IComponent, new()
        where C4 : class, IComponent, new()
        where C5 : class, IComponent, new()
    {
        c1 = Internal<C1>.GetOrAdd(e);
        c2 = Internal<C2>.GetOrAdd(e);
        c3 = Internal<C3>.GetOrAdd(e);
        c4 = Internal<C4>.GetOrAdd(e);
        c5 = Internal<C5>.GetOrAdd(e);
    }

    public static void Components<C1, C2, C3, C4, C5, C6>(this Entity e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6)
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
        where C3 : class, IComponent, new()
        where C4 : class, IComponent, new()
        where C5 : class, IComponent, new()
        where C6 : class, IComponent, new()
    {
        c1 = Internal<C1>.GetOrAdd(e);
        c2 = Internal<C2>.GetOrAdd(e);
        c3 = Internal<C3>.GetOrAdd(e);
        c4 = Internal<C4>.GetOrAdd(e);
        c5 = Internal<C5>.GetOrAdd(e);
        c6 = Internal<C6>.GetOrAdd(e);
    }

    public static void Components<C1, C2, C3, C4, C5, C6, C7>(this Entity e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7)
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
        where C3 : class, IComponent, new()
        where C4 : class, IComponent, new()
        where C5 : class, IComponent, new()
        where C6 : class, IComponent, new()
        where C7 : class, IComponent, new()
    {
        c1 = Internal<C1>.GetOrAdd(e);
        c2 = Internal<C2>.GetOrAdd(e);
        c3 = Internal<C3>.GetOrAdd(e);
        c4 = Internal<C4>.GetOrAdd(e);
        c5 = Internal<C5>.GetOrAdd(e);
        c6 = Internal<C6>.GetOrAdd(e);
        c7 = Internal<C7>.GetOrAdd(e);
    }

    public static void Components<C1, C2, C3, C4, C5, C6, C7, C8>(this Entity e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7, out C8 c8)
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
        where C3 : class, IComponent, new()
        where C4 : class, IComponent, new()
        where C5 : class, IComponent, new()
        where C6 : class, IComponent, new()
        where C7 : class, IComponent, new()
        where C8 : class, IComponent, new()
    {
        c1 = Internal<C1>.GetOrAdd(e);
        c2 = Internal<C2>.GetOrAdd(e);
        c3 = Internal<C3>.GetOrAdd(e);
        c4 = Internal<C4>.GetOrAdd(e);
        c5 = Internal<C5>.GetOrAdd(e);
        c6 = Internal<C6>.GetOrAdd(e);
        c7 = Internal<C7>.GetOrAdd(e);
        c8 = Internal<C8>.GetOrAdd(e);
    }

    public static void Components<C1, C2, C3, C4, C5, C6, C7, C8, C9>(this Entity e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7, out C8 c8, out C9 c9)
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
        c1 = Internal<C1>.GetOrAdd(e);
        c2 = Internal<C2>.GetOrAdd(e);
        c3 = Internal<C3>.GetOrAdd(e);
        c4 = Internal<C4>.GetOrAdd(e);
        c5 = Internal<C5>.GetOrAdd(e);
        c6 = Internal<C6>.GetOrAdd(e);
        c7 = Internal<C7>.GetOrAdd(e);
        c8 = Internal<C8>.GetOrAdd(e);
        c9 = Internal<C9>.GetOrAdd(e);
    }

    public static void Components<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10>(this Entity e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7, out C8 c8, out C9 c9, out C10 c10)
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
        c1 = Internal<C1>.GetOrAdd(e);
        c2 = Internal<C2>.GetOrAdd(e);
        c3 = Internal<C3>.GetOrAdd(e);
        c4 = Internal<C4>.GetOrAdd(e);
        c5 = Internal<C5>.GetOrAdd(e);
        c6 = Internal<C6>.GetOrAdd(e);
        c7 = Internal<C7>.GetOrAdd(e);
        c8 = Internal<C8>.GetOrAdd(e);
        c9 = Internal<C9>.GetOrAdd(e);
        c10 = Internal<C10>.GetOrAdd(e);
    }

    public static void Components<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11>(this Entity e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7, out C8 c8, out C9 c9, out C10 c10, out C11 c11)
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
        c1 = Internal<C1>.GetOrAdd(e);
        c2 = Internal<C2>.GetOrAdd(e);
        c3 = Internal<C3>.GetOrAdd(e);
        c4 = Internal<C4>.GetOrAdd(e);
        c5 = Internal<C5>.GetOrAdd(e);
        c6 = Internal<C6>.GetOrAdd(e);
        c7 = Internal<C7>.GetOrAdd(e);
        c8 = Internal<C8>.GetOrAdd(e);
        c9 = Internal<C9>.GetOrAdd(e);
        c10 = Internal<C10>.GetOrAdd(e);
        c11 = Internal<C11>.GetOrAdd(e);
    }

    public static void Components<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12>(this Entity e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7, out C8 c8, out C9 c9, out C10 c10, out C11 c11, out C12 c12)
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
        c1 = Internal<C1>.GetOrAdd(e);
        c2 = Internal<C2>.GetOrAdd(e);
        c3 = Internal<C3>.GetOrAdd(e);
        c4 = Internal<C4>.GetOrAdd(e);
        c5 = Internal<C5>.GetOrAdd(e);
        c6 = Internal<C6>.GetOrAdd(e);
        c7 = Internal<C7>.GetOrAdd(e);
        c8 = Internal<C8>.GetOrAdd(e);
        c9 = Internal<C9>.GetOrAdd(e);
        c10 = Internal<C10>.GetOrAdd(e);
        c11 = Internal<C11>.GetOrAdd(e);
        c12 = Internal<C12>.GetOrAdd(e);
    }

    public static void Components<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13>(this Entity e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7, out C8 c8, out C9 c9, out C10 c10, out C11 c11, out C12 c12, out C13 c13)
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
        c1 = Internal<C1>.GetOrAdd(e);
        c2 = Internal<C2>.GetOrAdd(e);
        c3 = Internal<C3>.GetOrAdd(e);
        c4 = Internal<C4>.GetOrAdd(e);
        c5 = Internal<C5>.GetOrAdd(e);
        c6 = Internal<C6>.GetOrAdd(e);
        c7 = Internal<C7>.GetOrAdd(e);
        c8 = Internal<C8>.GetOrAdd(e);
        c9 = Internal<C9>.GetOrAdd(e);
        c10 = Internal<C10>.GetOrAdd(e);
        c11 = Internal<C11>.GetOrAdd(e);
        c12 = Internal<C12>.GetOrAdd(e);
        c13 = Internal<C13>.GetOrAdd(e);
    }

    public static void Components<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14>(this Entity e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7, out C8 c8, out C9 c9, out C10 c10, out C11 c11, out C12 c12, out C13 c13, out C14 c14)
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
        c1 = Internal<C1>.GetOrAdd(e);
        c2 = Internal<C2>.GetOrAdd(e);
        c3 = Internal<C3>.GetOrAdd(e);
        c4 = Internal<C4>.GetOrAdd(e);
        c5 = Internal<C5>.GetOrAdd(e);
        c6 = Internal<C6>.GetOrAdd(e);
        c7 = Internal<C7>.GetOrAdd(e);
        c8 = Internal<C8>.GetOrAdd(e);
        c9 = Internal<C9>.GetOrAdd(e);
        c10 = Internal<C10>.GetOrAdd(e);
        c11 = Internal<C11>.GetOrAdd(e);
        c12 = Internal<C12>.GetOrAdd(e);
        c13 = Internal<C13>.GetOrAdd(e);
        c14 = Internal<C14>.GetOrAdd(e);
    }

    public static void Components<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15>(this Entity e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7, out C8 c8, out C9 c9, out C10 c10, out C11 c11, out C12 c12, out C13 c13, out C14 c14, out C15 c15)
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
        c1 = Internal<C1>.GetOrAdd(e);
        c2 = Internal<C2>.GetOrAdd(e);
        c3 = Internal<C3>.GetOrAdd(e);
        c4 = Internal<C4>.GetOrAdd(e);
        c5 = Internal<C5>.GetOrAdd(e);
        c6 = Internal<C6>.GetOrAdd(e);
        c7 = Internal<C7>.GetOrAdd(e);
        c8 = Internal<C8>.GetOrAdd(e);
        c9 = Internal<C9>.GetOrAdd(e);
        c10 = Internal<C10>.GetOrAdd(e);
        c11 = Internal<C11>.GetOrAdd(e);
        c12 = Internal<C12>.GetOrAdd(e);
        c13 = Internal<C13>.GetOrAdd(e);
        c14 = Internal<C14>.GetOrAdd(e);
        c15 = Internal<C15>.GetOrAdd(e);
    }

    public static void Components<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16>(this Entity e, out C1 c1, out C2 c2, out C3 c3, out C4 c4, out C5 c5, out C6 c6, out C7 c7, out C8 c8, out C9 c9, out C10 c10, out C11 c11, out C12 c12, out C13 c13, out C14 c14, out C15 c15, out C16 c16)
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
        c1 = Internal<C1>.GetOrAdd(e);
        c2 = Internal<C2>.GetOrAdd(e);
        c3 = Internal<C3>.GetOrAdd(e);
        c4 = Internal<C4>.GetOrAdd(e);
        c5 = Internal<C5>.GetOrAdd(e);
        c6 = Internal<C6>.GetOrAdd(e);
        c7 = Internal<C7>.GetOrAdd(e);
        c8 = Internal<C8>.GetOrAdd(e);
        c9 = Internal<C9>.GetOrAdd(e);
        c10 = Internal<C10>.GetOrAdd(e);
        c11 = Internal<C11>.GetOrAdd(e);
        c12 = Internal<C12>.GetOrAdd(e);
        c13 = Internal<C13>.GetOrAdd(e);
        c14 = Internal<C14>.GetOrAdd(e);
        c15 = Internal<C15>.GetOrAdd(e);
        c16 = Internal<C16>.GetOrAdd(e);
    }

    public static void RemoveComponents<C>(this Entity e)
        where C : class, IComponent, new()
    {
        Internal<C>.Remove(e);
    }

    public static void RemoveComponents<C1, C2>(this Entity e)
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
    {
        Internal<C1>.Remove(e);
        Internal<C2>.Remove(e);
    }

    public static void RemoveComponents<C1, C2, C3>(this Entity e)
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
        where C3 : class, IComponent, new()
    {
        Internal<C1>.Remove(e);
        Internal<C2>.Remove(e);
        Internal<C3>.Remove(e);
    }

    public static void RemoveComponents<C1, C2, C3, C4>(this Entity e)
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
        where C3 : class, IComponent, new()
        where C4 : class, IComponent, new()
    {
        Internal<C1>.Remove(e);
        Internal<C2>.Remove(e);
        Internal<C3>.Remove(e);
        Internal<C4>.Remove(e);
    }

    public static void RemoveComponents<C1, C2, C3, C4, C5>(this Entity e)
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
        where C3 : class, IComponent, new()
        where C4 : class, IComponent, new()
        where C5 : class, IComponent, new()
    {
        Internal<C1>.Remove(e);
        Internal<C2>.Remove(e);
        Internal<C3>.Remove(e);
        Internal<C4>.Remove(e);
        Internal<C5>.Remove(e);
    }

    public static void RemoveComponents<C1, C2, C3, C4, C5, C6>(this Entity e)
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
        where C3 : class, IComponent, new()
        where C4 : class, IComponent, new()
        where C5 : class, IComponent, new()
        where C6 : class, IComponent, new()
    {
        Internal<C1>.Remove(e);
        Internal<C2>.Remove(e);
        Internal<C3>.Remove(e);
        Internal<C4>.Remove(e);
        Internal<C5>.Remove(e);
        Internal<C6>.Remove(e);
    }

    public static void RemoveComponents<C1, C2, C3, C4, C5, C6, C7>(this Entity e)
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
        where C3 : class, IComponent, new()
        where C4 : class, IComponent, new()
        where C5 : class, IComponent, new()
        where C6 : class, IComponent, new()
        where C7 : class, IComponent, new()
    {
        Internal<C1>.Remove(e);
        Internal<C2>.Remove(e);
        Internal<C3>.Remove(e);
        Internal<C4>.Remove(e);
        Internal<C5>.Remove(e);
        Internal<C6>.Remove(e);
        Internal<C7>.Remove(e);
    }

    public static void RemoveComponents<C1, C2, C3, C4, C5, C6, C7, C8>(this Entity e)
        where C1 : class, IComponent, new()
        where C2 : class, IComponent, new()
        where C3 : class, IComponent, new()
        where C4 : class, IComponent, new()
        where C5 : class, IComponent, new()
        where C6 : class, IComponent, new()
        where C7 : class, IComponent, new()
        where C8 : class, IComponent, new()
    {
        Internal<C1>.Remove(e);
        Internal<C2>.Remove(e);
        Internal<C3>.Remove(e);
        Internal<C4>.Remove(e);
        Internal<C5>.Remove(e);
        Internal<C6>.Remove(e);
        Internal<C7>.Remove(e);
        Internal<C8>.Remove(e);
    }

    public static void RemoveComponents<C1, C2, C3, C4, C5, C6, C7, C8, C9>(this Entity e)
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
        Internal<C1>.Remove(e);
        Internal<C2>.Remove(e);
        Internal<C3>.Remove(e);
        Internal<C4>.Remove(e);
        Internal<C5>.Remove(e);
        Internal<C6>.Remove(e);
        Internal<C7>.Remove(e);
        Internal<C8>.Remove(e);
        Internal<C9>.Remove(e);
    }

    public static void RemoveComponents<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10>(this Entity e)
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
        Internal<C1>.Remove(e);
        Internal<C2>.Remove(e);
        Internal<C3>.Remove(e);
        Internal<C4>.Remove(e);
        Internal<C5>.Remove(e);
        Internal<C6>.Remove(e);
        Internal<C7>.Remove(e);
        Internal<C8>.Remove(e);
        Internal<C9>.Remove(e);
        Internal<C10>.Remove(e);
    }

    public static void RemoveComponents<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11>(this Entity e)
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
        Internal<C1>.Remove(e);
        Internal<C2>.Remove(e);
        Internal<C3>.Remove(e);
        Internal<C4>.Remove(e);
        Internal<C5>.Remove(e);
        Internal<C6>.Remove(e);
        Internal<C7>.Remove(e);
        Internal<C8>.Remove(e);
        Internal<C9>.Remove(e);
        Internal<C10>.Remove(e);
        Internal<C11>.Remove(e);
    }

    public static void RemoveComponents<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12>(this Entity e)
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
        Internal<C1>.Remove(e);
        Internal<C2>.Remove(e);
        Internal<C3>.Remove(e);
        Internal<C4>.Remove(e);
        Internal<C5>.Remove(e);
        Internal<C6>.Remove(e);
        Internal<C7>.Remove(e);
        Internal<C8>.Remove(e);
        Internal<C9>.Remove(e);
        Internal<C10>.Remove(e);
        Internal<C11>.Remove(e);
        Internal<C12>.Remove(e);
    }

    public static void RemoveComponents<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13>(this Entity e)
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
        Internal<C1>.Remove(e);
        Internal<C2>.Remove(e);
        Internal<C3>.Remove(e);
        Internal<C4>.Remove(e);
        Internal<C5>.Remove(e);
        Internal<C6>.Remove(e);
        Internal<C7>.Remove(e);
        Internal<C8>.Remove(e);
        Internal<C9>.Remove(e);
        Internal<C10>.Remove(e);
        Internal<C11>.Remove(e);
        Internal<C12>.Remove(e);
        Internal<C13>.Remove(e);
    }

    public static void RemoveComponents<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14>(this Entity e)
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
        Internal<C1>.Remove(e);
        Internal<C2>.Remove(e);
        Internal<C3>.Remove(e);
        Internal<C4>.Remove(e);
        Internal<C5>.Remove(e);
        Internal<C6>.Remove(e);
        Internal<C7>.Remove(e);
        Internal<C8>.Remove(e);
        Internal<C9>.Remove(e);
        Internal<C10>.Remove(e);
        Internal<C11>.Remove(e);
        Internal<C12>.Remove(e);
        Internal<C13>.Remove(e);
        Internal<C14>.Remove(e);
    }

    public static void RemoveComponents<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15>(this Entity e)
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
        Internal<C1>.Remove(e);
        Internal<C2>.Remove(e);
        Internal<C3>.Remove(e);
        Internal<C4>.Remove(e);
        Internal<C5>.Remove(e);
        Internal<C6>.Remove(e);
        Internal<C7>.Remove(e);
        Internal<C8>.Remove(e);
        Internal<C9>.Remove(e);
        Internal<C10>.Remove(e);
        Internal<C11>.Remove(e);
        Internal<C12>.Remove(e);
        Internal<C13>.Remove(e);
        Internal<C14>.Remove(e);
        Internal<C15>.Remove(e);
    }

    public static void RemoveComponents<C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11, C12, C13, C14, C15, C16>(this Entity e)
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
        Internal<C1>.Remove(e);
        Internal<C2>.Remove(e);
        Internal<C3>.Remove(e);
        Internal<C4>.Remove(e);
        Internal<C5>.Remove(e);
        Internal<C6>.Remove(e);
        Internal<C7>.Remove(e);
        Internal<C8>.Remove(e);
        Internal<C9>.Remove(e);
        Internal<C10>.Remove(e);
        Internal<C11>.Remove(e);
        Internal<C12>.Remove(e);
        Internal<C13>.Remove(e);
        Internal<C14>.Remove(e);
        Internal<C15>.Remove(e);
        Internal<C16>.Remove(e);
    }

    internal static class Internal<C>
        where C : class, IComponent, new()
    {
        private static readonly ConditionalWeakTable<Entity, C> _components = new();

        internal static bool TryGet(Entity e, out C c) => _components.TryGetValue(e, out c);

        internal static C GetOrAdd(Entity e) => _components.GetOrCreateValue(e);

        internal static void Remove(Entity e) => _components.Remove(e);
    }
}