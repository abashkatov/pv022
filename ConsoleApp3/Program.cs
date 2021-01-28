using System.Windows.Input;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        class Vector2 {
            public Vector2(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int X { get; set; }
            public int Y { get; set; }
            public static Vector2 operator +(Vector2 v1, Vector2 v2) {
                return new Vector2(v1.X  + v2.X, v1.Y + v2.Y);
            }
            public static Vector2 operator +(Vector2 v1, int i) {
                return new Vector2(v1.X  + i, v1.Y + i);
            }
            public static Vector2 operator +(int i, Vector2 v1) {
                return v1 + i;
            }
            public override string ToString()
            {
                return $"{{X: {X}, Y: {Y}}}";
            }
            public override int GetHashCode()
            {
                return ToString().GetHashCode();
            }
            public bool Equals(Vector2 v2)
            {
                return X == v2.X && Y == v2.Y;
            }
            public static bool Equals(Vector2 v1, Vector2 v2)
            {
                return v1==v2;
            }
            public static bool operator ==(Vector2 v1, Vector2 v2) 
            {
                return v1.Equals(v2);
            }
            public static bool operator !=(Vector2 v1, Vector2 v2) 
            {
                return !(v1==v2);
            }
            public static bool operator true(Vector2 v) {
                return v.X > 0 && v.Y > 0;
            }
            public static bool operator false(Vector2 v) {
                return !(v.X > 0 && v.Y > 0);
            }
            public static Vector2 operator & (Vector2 v1, Vector2 v2)
            {
                return new Vector2(
                    v1.X > 0 && v2.X > 0 ? 1 : -1,
                    v1.Y > 0 && v2.Y > 0 ? 1 : -1
                );
            }
            public static Vector2 operator | (Vector2 v1, Vector2 v2)
            {
                return new Vector2(
                    v1.X > 0 || v2.X > 0 ? 1 : -1,
                    v1.Y > 0 || v2.Y > 0 ? 1 : -1
                );
            }
            public static explicit operator int(Vector2 v) {
                return v.X + v.Y;
            }
            public static implicit operator Rect(Vector2 v) {
                return new Rect(v.X, v.Y);
            }
        }
        class Rect {
            public Rect(int x, int y)
            {
                X = x;
                Y = y;
            }
            public int X { get; set; }
            public int Y { get; set; }
        }
        static void Main(string[] args)
        {
            Vector2 v = new Vector2(10, 10);
            int i = (int)v;
            Rect rect = v;

            ReadKey();
        }
    }
}
