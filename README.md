# GigaBit-fall-2025-pong

## Getting started

### Install IDE/Code editor
We recommed `Visual Studio`, but any code editor can be used.

Install `Visual Studio` [here](https://visualstudio.microsoft.com/downloads/)

### Install `.Net` (DotNet)
Install `.Net` [here](https://dotnet.microsoft.com/en-us/download)

### Create Console App
This can be done in the console/terminal with 
```
dotnet new console
```

If you are using `Visual Studio` you can create a new project directly from `Visual Studio`

### Install raylib-cs
We use the `NuGet` package `raylib-cs`.

It can be install in the `Nuget Package Manager` if you are using `Visual Studio`

Otherwise it you can install it in the console/terminal
```
dotnet add package Raylib-cs
```

### Drawing wit `Raylib`

We start by initializing 

```cs
//init
Raylib.InitWindow(800, 480, "Pong");
Raylib.SetTargetFPS(60);
```

Then we create a game loop where we can render
```cs
//game loop
while (!Raylib.WindowShouldClose())
{
    // logic before render can be added here
    
    //render
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.White);

    // Here we can render objects or text

    Raylib.DrawFPS(0, 0); // draw current FPS at pos (0, 0)

    Raylib.EndDrawing();
}
```


### Render DrawRectangle 
```cs
// Draw a color-filled rectangle
// void DrawRectangle(int posX, int posY, int width, int height, Color color); 

Raylib.DrawRectangle(10, 10, 10, 10, Color.Blue); 
```

### Render DrawRectangleV
```cs
// Draw a color-filled rectangle (Vector version)
// void DrawRectangleV(Vector2 position, Vector2 size, Color color); 

Vector2 pos = new Vector2(10, 10);
Vector2 size = new Vector2(10, 10);
Raylib.DrawRectangleV(pos, size, Color.Blue);
```

### Render DrawCircleV
```cs
// Draw a color-filled circle
// DrawCircle(int centerX, int centerY, float radius, Color color);     

Raylib.DrawCircle(10, 10, 10, Color.Blue);

```

### Render DrawCircle 
```cs
// Draw a color-filled circle (Vector version)
// void DrawCircleV(Vector2 center, float radius, Color color); 

Vector2 center = new Vector2(10, 10);
Raylib.DrawCircleV(center, 10, Color.Blue);
```

### Render DrawText
```cs
// Draw text (using default font)
// void DrawText(const char *text, int posX, int posY, int fontSize, Color color); 

Raylib.DrawText("text", 10, 10, 20, Color.Blue);
```


## Run project
```
dotnet run
```
