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
        }
        static void Main(string[] args)
        {
            Vector2 v1 = new Vector2(1, 1),
                    v2 = new Vector2(1, 1), v3;
            v3 = v1;

            WriteLine("V2 ============");
            WriteLine(Vector2.Equals(v1, v2));
            WriteLine(v1.Equals(v2));
            WriteLine(v1 == v2);

            //WriteLine(v3);

            ReadKey();
        }
    }
}
