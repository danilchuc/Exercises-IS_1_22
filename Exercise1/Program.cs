﻿using System;
using System.Threading;

namespace Exercise1
{
    class Program
    {
        static void Main( string[] args )
        {
            Engine eng = new Engine();
            Console.Out.WriteLine( "State: " + eng.getState() );
            Console.Out.WriteLine();

            eng.Start();
            Console.Out.WriteLine( "State: " + eng.getState() );
            Thread.Sleep( 2000 );
            Console.Out.WriteLine();

            eng.Stop();
            Console.Out.WriteLine( "State: " + eng.getState() );

            Console.ReadKey();
        }
    }
}
