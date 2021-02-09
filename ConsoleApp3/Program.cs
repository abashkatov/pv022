﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using static System.Console;

namespace ConsoleApp3
{
    public class Program
    {
        protected delegate void LightChanged();

        class TrafficLight {
            //public LightChanged lightChanged;
            public event LightChanged LightChanged;

            private bool canGo = false;
            public bool CanGo {
                get => canGo;
                set {
                    canGo = value;
                    LightChanged?.Invoke();
                } 
            }
        }
        class Car {
            public string Color;

            public Car(string color)
            {
                Color = color;
            }

            public void GoToNextTrafficLight(TrafficLight trafficLight) {
                string end = "!";
                trafficLight.LightChanged += () => WriteLine("Car " + Color + " has been moved" + end);
            }
            // x => WriteLine(x);
            // (x) => WriteLine(x);
            // x => { WriteLine(x); }
            // (x) => { WriteLine(x); }
            // () => WriteLine(x);
            // (x, y) => WriteLine(x);
            // (x, y) => {WriteLine(x); WriteLine(y); }
            public void GoToDetour(TrafficLight trafficLight) {
                trafficLight.LightChanged -= delegate () { WriteLine("Car " + Color + " has been moved"); };
            }
            private void move()
            {
                WriteLine("Car " + Color + " has been moved");
            }
        }
        static void Main(string[] args)
        {
            TrafficLight tl = new TrafficLight();
            Car carGreen = new Car("Green"), carRed = new Car("Red");
            carGreen.GoToNextTrafficLight(tl);
            carRed.GoToNextTrafficLight(tl);
            carRed.GoToDetour(tl);
            
            string input;
            do {
                Write("Введите `д`, чтобы включить светофор: ");
                input = ReadLine();
                if (input == "д") {
                    tl.CanGo = true;
                }
            } while (true);

            ReadKey();
        }
    }
}
