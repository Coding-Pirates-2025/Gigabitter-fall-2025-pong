using Raylib_cs;

Raylib.InitWindow(800, 600, "Pong Game");
Raylib.SetTargetFPS(60);

while(!Raylib.WindowShouldClose())
{
    // render
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.White);

    Raylib.DrawFPS(0, 0);

    Raylib.EndDrawing();
}
