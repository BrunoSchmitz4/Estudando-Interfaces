using System;
using System.Reflection.Metadata;

namespace InterAppOne.Devices
{
    class ComboDevide : Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("ComboDevice print" + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice processing" + document);

        }

        public string Scan()
        {
            return "ComboDevice scan result";
        }
    }
}
