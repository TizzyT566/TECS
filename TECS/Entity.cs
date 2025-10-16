using System;
using System.ComponentModel;
using System.Threading;

namespace TECS;

/// <summary>
/// Base class for entities.
/// </summary>
public abstract class Entity
{
    private static long _entityIdCounter = 0L;

    /// <summary>
    /// Gets the unique identifier for the entity.
    /// </summary>
    /// <exception cref="InvalidOperationException">
    /// Number of Entity instances exhausted.
    /// </exception>
    public long Id { get; } = GenerateEntityId();

    private static long GenerateEntityId()
    {
        long id = Interlocked.Increment(ref _entityIdCounter);
        if (id == 0) // Overflow check, 0 is reserved.
            throw new InvalidOperationException("Entity ID overflow.");
        return id;
    }
}
