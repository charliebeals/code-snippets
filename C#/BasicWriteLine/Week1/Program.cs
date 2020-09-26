/* Written by:    Charlie Beals
 * Date Created:  2020/08/22
 * Purpose:       To show how C# can be used to print basic information to a console.
 * Class:         CITP 180
 * Assignment:    Chapter 1, Excercise 1 and 6
 */
using System;
using static System.Console;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Black;
            BackgroundColor = ConsoleColor.White;
            WriteLine("-----Excercise 1-----");
            WriteLine("Hello World!");
            WriteLine("My name is Charlie Beals!");
            _ = ReadKey();
            WriteLine("-----Excercise 6-----");
            WriteLine("Output #1");
            Write("If you can't see very far ahead, ");
            Write("go ahead as far ");
            Write("as you can see.\n");
            WriteLine("Output #2");
            Write("If you can't see very far ahead,\n");
            Write("go ahead as far\n");
            Write("as you can see.\n");
            WriteLine("Output #3");
            Write("If\n");
            Write("you\n");
            Write("can't\n");
            Write("see\n");
            Write("very\n");
            WriteLine("far");
            WriteLine("ahead,");
            WriteLine("Go");
            WriteLine("ahead");
            WriteLine("as");
            WriteLine("far");
            WriteLine("as");
            Write("you\n");
            Write("can\n");
            Write("see\n");
        }
    }
}
