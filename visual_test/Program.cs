using System.ComponentModel;
using System.Drawing;
using System;
using Raylib_cs;

Raylib.InitWindow(800, 600, "testvisual");
Raylib.SetTargetFPS(30);
Rectangle playerRect = new Rectangle(20, 20, 20, 20);
Rectangle enemyRect = new Rectangle(20,20,20,20);
float speed = 2.25f;
float SPEED = speed *= 2f;

Texture2D playerImage = Raylib.LoadTexture("New Piskel-1.png");
Texture2D enemyImage = Raylib.LoadTexture("");

while (Raylib.WindowShouldClose() == false)
{

    if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT_SHIFT)){
    if (Raylib.IsKeyDown(KeyboardKey.KEY_D)) playerRect.x += SPEED;
    if (Raylib.IsKeyDown(KeyboardKey.KEY_A)) playerRect.x -= SPEED;
    if (Raylib.IsKeyDown(KeyboardKey.KEY_S)) playerRect.y += SPEED;
    if (Raylib.IsKeyDown(KeyboardKey.KEY_W)) playerRect.y -= SPEED;
    if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) playerRect.x += SPEED;
    if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) playerRect.x -= SPEED;
    if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)) playerRect.y += SPEED;
    if (Raylib.IsKeyDown(KeyboardKey.KEY_UP)) playerRect.y -= SPEED;    
    }

    if (Raylib.IsKeyDown(KeyboardKey.KEY_D)) playerRect.x += speed;
    if (Raylib.IsKeyDown(KeyboardKey.KEY_A)) playerRect.x -= speed;
    if (Raylib.IsKeyDown(KeyboardKey.KEY_S)) playerRect.y += speed;
    if (Raylib.IsKeyDown(KeyboardKey.KEY_W)) playerRect.y -= speed;
    if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) playerRect.x += speed;
    if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) playerRect.x -= speed;
    if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)) playerRect.y += speed;
    if (Raylib.IsKeyDown(KeyboardKey.KEY_UP)) playerRect.y -= speed;





    Raylib.BeginDrawing();


    Raylib.ClearBackground(Color.WHITE);
    Raylib.DrawTexture(playerImage, (int)playerRect.x, (int)playerRect.y, Color.WHITE);

    Raylib.DrawTexture(enemyImage, (int) enemyRect.x, (int) enemyRect.y, Color.WHITE);

    Raylib.EndDrawing();
}