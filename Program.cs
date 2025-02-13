using POO_CSharp_P17.Devices;

namespace POO_CSharp_P17
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Herança múltipla e o problema do diamante");
            Console.WriteLine();
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
        }
    }
}