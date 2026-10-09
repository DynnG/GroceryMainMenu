# Grocery Console Menu

A C# console coursework project in the `GroceryStoreDiscountCalculator` namespace. It explores grocery categories, product selection, and menu-driven interaction.

## Current source

The source is stored in [`Program.cs`](Program.cs). The main menu connects canned goods, fruits, vegetables, snacks, sweets, and a cart display. Several categories and the checkout action are placeholders.

## Run locally

Requires a .NET SDK supporting C# console applications. This repository does not include a `.csproj` file. Create a console project in a separate local folder:

```sh
dotnet new console -n GroceryDemo
```

Replace the generated `GroceryDemo/Program.cs` with the contents of `Program.cs`, then run:

```sh
cd GroceryDemo
dotnet run
```

Alternatively, create a C# Console App in Visual Studio and replace its generated `Program.cs`. Do not keep both entry points.

## Learning topics

- Console input and output.
- Switch statements and menu loops.
- Product/category classes.
- Collections and quantity handling.

This is an exercise snapshot. Review and fix any compiler or runtime issues before extending it; a complete order or payment flow is not implemented by the visible main menu.
