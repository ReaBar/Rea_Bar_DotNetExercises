﻿

using System;
using System.Diagnostics;

namespace CustomAwaiter
{
    class Program
    {
        static void Main(string[] args)
        {
            var helper = new Helper();
            helper.IntDelay(1000);
            helper.ProcessAwaiter(Process.GetProcessById(6724));
            Console.ReadLine();
        }
    }
}
