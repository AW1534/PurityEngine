using Raylib_cs;
using System.Collections.Generic;
using BetterEventSystem;

namespace Purity;

// https://github.com/ChrisDill/Raylib-cs

public class Window {
    public List<Drawable> drawables = new List<Drawable>();
    int height;
    int width;

    public Window(string title = "PurityEngine", int length = 800, int height = 400) {
        Logger.Log("Creating new window");
        Raylib.InitWindow(length, height, title);
        this.height = Raylib.GetRenderHeight();
        this.width = Raylib.GetRenderWidth();
        EventSystem.GetEvent("window_create").Broadcast(this);

        while (!Raylib.WindowShouldClose()) {
            EventSystem.GetEvent("before_update").Broadcast(this);
            if (Raylib.IsWindowResized()) {
                this.height = Raylib.GetRenderHeight();
                this.width = Raylib.GetRenderWidth();
            }
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);
            EventSystem.GetEvent("before_render").Broadcast(this);
        
            //loop through all items in drawables list
            foreach (Drawable x in this.drawables) {
                x.Draw();
            }

            EventSystem.GetEvent("after_render").Broadcast(this);
            
            Raylib.EndDrawing();
            EventSystem.GetEvent("after_update").Broadcast(this);
        }
    }

    public bool IsKeyPressed(KeyboardKey key) {
        return Raylib.IsKeyPressed(key);
    }

    public bool IsKeyDown(KeyboardKey key) {
        return Raylib.IsKeyDown(key);
    }

    public bool IsKeyReleased(KeyboardKey key) {
        return Raylib.IsKeyReleased(key);
    }

    ~Window() {
        Raylib.CloseWindow();
    }
}