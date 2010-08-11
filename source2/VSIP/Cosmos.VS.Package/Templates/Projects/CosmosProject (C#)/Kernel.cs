﻿using System;
using System.Collections.Generic;
using System.Text;

namespace $safeprojectname$
{
    public class Kernel
    {
	    public static void Boot()
        {
            // Boot the Cosmos kernel:
            Cosmos.Sys.Boot xBoot = new Cosmos.Sys.Boot();
            xBoot.Execute();
            
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back:");
            string xResult = Console.ReadLine();
            Console.Write("Text typed: ");
            Console.WriteLine(xResult);
        }
    }
}