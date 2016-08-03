﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstProject = new Task(() =>
            {
                Console.WriteLine("first project is running");
                Thread.Sleep(1000);
                Console.WriteLine("first project finished");
            });

            var secondProject = new Task(() =>
            {
                Console.WriteLine("second project is running");
                Thread.Sleep(1000);
                Console.WriteLine("second project finished");
            });

            var thirdProject = new Task(() =>
            {
                Console.WriteLine("third project is running");
                Thread.Sleep(1000);
                Console.WriteLine("third project finished");
            });

            var fourthProject = firstProject.ContinueWith(t =>
            {
                Console.WriteLine("fourth project is running");
                Thread.Sleep(1000);
                Console.WriteLine("fourth project finished");
            });

            var fifthProject = Task.Factory.ContinueWhenAll(new Task[] {firstProject, secondProject, thirdProject},
                completedTasks =>
                {
                    Console.WriteLine("fifth project is running");
                    Thread.Sleep(1000);
                    Console.WriteLine("fifth project finished");
                });

            var sixProject = Task.Factory.ContinueWhenAll(new Task[] {fourthProject, thirdProject}, completedTasks =>
            {
                Console.WriteLine("sixth project is running");
                Thread.Sleep(1000);
                Console.WriteLine("sixth project finished");
            });


            firstProject.Start();
            secondProject.Start();
            thirdProject.Start();
            fourthProject.Wait();
            fifthProject.Wait();
            sixProject.Wait();

        }
    }
}
