# Event HasDied

Implement an event for all 3 classes **Player**,**Turtle** and **Ork**.
The event is called **HasDied**.
This event is fired if an object loses so much hp that the hp is zero or
negative.
The event is fired with one parameter of type integer. 
The value of the parameter is the amount of damage, dealt by the last attack.

We have the following code. This code will run forever without the event.
Once you implemented the event, register a lambda. This lambda should do
2 things.
1. Print out which amount of damage of the last attack which killed the player.
2. Terminate the while loop. Tip: Closure can help here.
```csharp
// Test code
var player = new Player(100, 10);
var ork = new Ork(200, 20, 10);

bool playerIsDead = false;
int turnNumber = 1;
while (!playerIsDead)
{
    Console.WriteLine($"{turnNumber}. Turn");
    Fight(player, ork);
}
```