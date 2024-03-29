﻿using System;
using System.Threading;

namespace Perfvane.Example
{
    public class Anomalies
    {
        public static void Degradation()
        {
            Thread.Sleep(500);
        }

        public static void Acceleration()
        {
            Thread.Sleep(100);
        }

        public static void Bimodal()
        {
            switch (new Random().Next(0, 2))
            {
                case 0:
                    Thread.Sleep(500);
                    return;
                case 1:
                    Thread.Sleep(1000);
                    return;
                default:
                    throw new NotImplementedException();
            }
        }

        public static void Multimodal()
        {
            switch (new Random().Next(0, 3))
            {
                case 0:
                    Thread.Sleep(509);
                    return;
                case 1:
                    Thread.Sleep(1021);
                    return;
                case 2:
                    Thread.Sleep(1500);
                    return;
                default:
                    throw new NotImplementedException();
            }
        }

        public static void Changepoint()
        {
            Multimodal();
        }

        public static void Changepoint2()
        {
            Thread.Sleep(750);
        }
    }   
}
