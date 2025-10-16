# TECS - Tiny Entity Component System

TECS is a lightweight Entity-Component-System (ECS) framework designed for simplicity and performance. It provides a minimalistic approach to managing entities and their associated components, enabling efficient design for games and other applications.

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
public class Position : Component<Position>
{
    public float X { get; set; }
    public float Y { get; set; }
}
public class Velocity : Component<Velocity>
{
    public float X { get; set; }
    public float Y { get; set; }
}

// Define an entity that attaches the components
public class Player : Entity;

public static class Program
{
    public static void Main()
    {
        // Create a new player entity
        Player player = new();

        // Get components from the player entity
        player.Components(out Position position, out Velocity velocity);

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

        // Remove the velocity and position components
        player.RemoveComponents<Velocity, Position>();
    }
}
```