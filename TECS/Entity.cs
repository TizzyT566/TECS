using System.Threading;

namespace TECS;

/// <summary>
/// Base class for entities.
/// </summary>
public abstract class Entity
{
    private static long _entityIdCounter = -1;

    private readonly long _id = Interlocked.Increment(ref _entityIdCounter);

    /// <summary>
    /// Gets the unique identifier for the entity.
    /// </summary>
    public long Id => _id;
}
