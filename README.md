# TECS - Tiny Entity Component System

TECS is a lightweight Entity-Component-System (ECS) framework designed for simplicity and performance. It provides a minimalistic approach to managing entities and their associated components, enabling efficient data-driven design for games and other applications.

## Features
- **Entity Management**: Base class for entities with unique identifiers.
- **Component Interface**: Define components that can be attached to entities.
- **System Utilities**: Extract and manage components attached to entities.

## Installation
Add TECS to your project by including the `TECS` namespace and referencing the required files.

## Usage Example

```csharp
using TECS;

// Define components
public class PositionComponent : IComponent
{
    public float X { get; set; }
    public float Y { get; set; }
}
public class VelocityComponent : IComponent
{
    public float X { get; set; }
    public float Y { get; set; }
}

// Define an entity that attaches the components
public class Player : Entity, IAttach<PositionComponent>, IAttach<VelocityComponent>;

public static class Program
{
    public static void Main()
    {
        // Create a new player entity
        Player player = new();

        // Unpack components from the player entity
        player.Unpack(out PositionComponent position, out VelocityComponent velocity);

        // Initialize components
        position.X = 0;
        position.Y = 0;
        velocity.X = 1;
        velocity.Y = 1;

        // Update position based on velocity
        position.X += velocity.X;
        position.Y += velocity.Y;

        // Print updated position
        Console.WriteLine($"Player Position: X={position.X}, Y={position.Y}");
    }
}
```