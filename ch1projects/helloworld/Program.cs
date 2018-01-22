using System;
using static System.Console;

namespace helloworld
{
    /// <summary>
    /// Program:        Hellos world
    /// Developer:      robert oleary
    /// Date:           1/22/18
    /// Purpose:        say hello
    /// </summary>
    class Program
    {
        /// <summary>
        /// this is where the main begins
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //the output
            Write("hello world!");
            Write(" Welcome to C#.\n");
            //pauses so that you can see it
            Read();
        }
    }
}
