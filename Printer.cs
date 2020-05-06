using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas5
{
    public class Printer
    {
        public string Name { get; set; }
        public virtual void Show()
        {
            
        }
        public virtual void Print()
        {

        }
    }
    public class Epson : Printer
    {
        public override void Show()
        {
            Console.WriteLine("Epsone Display Dimension : 10*11");
            
        }
        public override void Print()
        {
            Console.WriteLine("Epsone Printer Printing....");
        }
    }
    public class Canon : Printer
    {
        public override void Show()
        {
            Console.WriteLine("Cannon Display Dimension : 9.5*12");
            
        }
        public override void Print()
        {
            Console.WriteLine("Cannon Printer Printing....");
        }
    }
    public class LaserJet : Printer
    {
        public override void Show()
        {
            Console.WriteLine("LaserJe Display Dimension : 12*12");
            
        }
        public override void Print()
        {
            Console.WriteLine("LaserJe Printer Printing....");
        }
    }
}


