using System.Windows.Input;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        private class Vector2 
        {
            public Vector2(int x, int y)
            {
                X = x;
                Y = y;
            }
            public int X {  get; set; }
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
            public int this[int index] {
                get
                {
                    return index == 0 ? X : Y;
                }
                set
                {
                    if (index == 0)
                    {
                        X = value;
                    }
                    else {
                        Y = value;
                    }
                }
            }
            public int this[string index] {
                get
                {

                    return index == "X" ? X : index == "Y" ? Y : 0;
                }
                set
                {
                    if (index == "X")
                    {
                        X = value;
                    }
                    else if (index == "Y") {
                        Y = value;
                    }
                }
            }
            public int this[Vector2 index2, string index] {
                set
                {
                    X = value;
                }
            }
            public int this[string index, Vector2 index2] {
                get
                {

                    return index == "X" ? X : index == "Y" ? Y : 0;
                }
                set
                {
                    if (index == "X")
                    {
                        X = value;
                    }
                    else if (index == "Y") {
                        Y = value;
                    }
                }
            }
            public int Length { get => 2; }
        }
        static void Main(string[] args)
        {
            Vector2 v = new Vector2(5, 10);
            string[] o = { "X", "Y" };
            
            v.X = 2;
            v["X"] = 1;
            v["Y"] = 2;

            v["X"] = 1;
            v["Y"] = 2;

            WriteLine(v[0]);
            WriteLine(v[1]);

            ReadKey();
        }
    }
}
