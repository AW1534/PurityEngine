using System.Collections.Generic;
using Raylib_cs;

namespace Purity;

public class Drawable {
    public Vector2D position = new Vector2D(0, 0);
    public int size;
    public Color color = new Color(255, 255, 255, 255);

    public virtual void Draw() {
        Logger.Warn("No draw function specified");
    }
}

public class DrawableText : Drawable {
    public string text;
    public DrawableText(string text, Vector2D position = null, int size = 1)  {
        this.text = text;
        this.position = (position == null) ? new Vector2D(0, 0) : position;
        this.size = size;
    }

    public override void Draw() {
        Raylib.DrawText(this.text, (int)this.position.x, (int)this.position.y, (int)this.size, this.color);
    }
}

public enum Shape {
    SQUARE,
    CIRCLE
}

public class DrawableShape : Drawable {
    Shape type = Shape.SQUARE;

    public DrawableShape(Shape type, Vector2D position = null, int size = 1) {
        this.type = type;
        this.position = (position == null) ? new Vector2D(0, 0) : position;
        this.size = size;
    }

    public override void Draw() {
        switch(this.type) {
            case Shape.SQUARE:
                Raylib.DrawRectangle((int)this.position.x, (int)this.position.y, (int)this.size, (int)this.size, this.color);
                break;
            
            case Shape.CIRCLE:
                Raylib.DrawCircle((int)this.position.x, (int)this.position.y, (int)this.size, this.color);
                break;
        }
    }
}