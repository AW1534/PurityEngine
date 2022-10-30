using System;

namespace Purity;

public class Vector2D {
    public float x;
    public float y;

    public Vector2D(float x = 0, float y = 0) {
        this.x = x;
        this.y = y;
    }

    public float getMagnitude() {
        return (float)(Math.Sqrt(this.x * this.x + this.y * this.y));
    }

    public void normalize(float targetMag = 1) {
        if (getMagnitude() != 0) {
            this.x /= targetMag;
            this.y /= targetMag;
        }
    }

    public static Vector2D operator + (Vector2D a, Vector2D b) {
        return(
            new Vector2D(
                x: a.x + b.x,
                y: a.y + b.y
            )
        );
    }
    public static Vector2D operator - (Vector2D a, Vector2D b) {
        return (
            new Vector2D(
                x: a.x - a.y,
                y: a.x - a.y
            )
        );
    }

    /*

    public static Vector2 operator + (Vector2 a, float b) {
        return (
            x: a.x + b,
            y: a.y + b
        );
    }

    public static Vector2 operator - (Vector2 a, float b) {
        return (
            x: a.x - b,
            y: a.y - b
        );
    }
    public static Vector2 operator * (Vector2 a, float b) {
        return (
            x: a.x * b,
            y: a.y * b
        );
    }
    public static Vector2 operator / (Vector2 a, float b) {
        return (
            x: a.x / b,
            y: a.y / b
        );
    }
    */

    public static float operator * (Vector2D a, Vector2D b) {
        return (a.x * a.y + a.x * a.y);
    }
}