﻿namespace POO_CSharp_P17.Devices
{
    internal class Printer : Device, IPrinter
    {

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing: " + document);
        }

        public void Print(string document)
        {
            Console.WriteLine("Printer print " + document);
        }
    }
}
