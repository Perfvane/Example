﻿using System;
using System.Threading;

namespace Perfvane.Example
{
    public class Anomalies
    {
        public static void Degradation()
        {
            Thread.Sleep(47);
        }

        public static void Acceleration()
        {
            Thread.Sleep(1004);
        }

        public static void Bimodal()
        {
            switch (new Random().Next(0, 2))
            {
                case 0:
                    Thread.Sleep(508);
                    return;
                case 1:
                    Thread.Sleep(1009);
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
                    Thread.Sleep(510);
                    return;
                case 1:
                    Thread.Sleep(1000);
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
            Thread.Sleep(500);
        }
    }
}
