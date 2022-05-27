# Network commands
Currently, BootNet has only one command: DHCP command.

In kernel:
```csharp 
case "network setup": Network.DHCP(); break;
```

This is repeated once a boot, and if not working it shows a exception:

```csharp
Console.BackgroundColor = ConsoleColor.Red;
Console.Write("FAILED: ");
Console.BackgroundColor = ConsoleColor.Black;
Console.Write("Network connection.");
```