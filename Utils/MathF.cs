﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Just Simple utils tool

namespace AnotherRpgMod.Utils
{
    public static class Mathf // float math
    {
        static Random Rdn = new Random();

        public static T Clamp<T>(this T val, T min, T max) where T : IComparable<T>
        {
            if (val.CompareTo(min) < 0) return min;
            else if (val.CompareTo(max) > 0) return max;
            else return val;
        }

        public static int RandomInt(int a,int b)
        {
            return Rdn.Next(a, b);
        }

        public static float Pow(double number,double power)
        {
            return (float)Math.Pow(number, power);
        }
        public static float Pow(float number, float power)
        {
            return (float)Math.Pow(number, power);
        }
        public static float Pow(int number, int power)
        {
            return (float)Math.Pow(number, power);
        }
        public static float Pow(float number, int power)
        {
            return (float)Math.Pow(number, power);
        }
        public static float Pow(int number, float power)
        {
            return (float)Math.Pow(number, power);
        }

        public static float Log(double number)
        {
            return (float)Math.Log(number);
        }
        public static float Log(float number)
        {
            return (float)Math.Log((double)number);
        }
        public static float Log(int number)
        {
            return (float)Math.Log((double)number);
        }


        public static int RoundInt(double number)
        {
            return (int)Math.Round(number);
        }
        public static int RoundInt(float number)
        {
            return (int)Math.Round((double)number);
        }
        public static int RoundInt(int number)
        {
            return (int)Math.Round((double)number);
        }

        public static float Round(double number,int dec = 1)
        {
            return (float)Math.Round(number,dec);
        }
        public static float Round(float number, int dec = 1)
        {
            return (float)Math.Round((double)number, dec);
        }
        public static float Round(int number, int dec = 1)
        {
            return (float)Math.Round((double)number, dec);
        }

        public static float Ceil(double number)
        {
            return (float)Math.Ceiling(number);
        }
        public static float Ceil(float number)
        {
            return (float)Math.Ceiling((double)number);
        }
        public static float Ceil(int number)
        {
            return (float)Math.Ceiling((double)number);
        }

        public static int CeilInt(double number)
        {
            return (int)Math.Ceiling(number);
        }
        public static int CeilInt(float number)
        {
            return (int)Math.Ceiling((double)number);
        }
        public static int CeilInt(int number)
        {
            return (int)Math.Ceiling((double)number);
        }


        public static float Floor(double number)
        {
            return (float)Math.Floor(number);
        }
        public static float Floor(float number)
        {
            return (float)Math.Floor((double)number);
        }
        public static float Floor(int number)
        {
            return (float)Math.Floor((double)number);
        }

        public static int FloorInt(double number)
        {
            return (int)Math.Floor(number);
        }
        public static int FloorInt(float number)
        {
            return (int)Math.Floor((double)number);
        }
        public static int FloorInt(int number)
        {
            return (int)Math.Floor((double)number);
        }
    }
}