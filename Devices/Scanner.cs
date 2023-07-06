using System;

namespace InterAppOne.Devices
{
    class Scanner : Device, IScanner
    {

        // Agora, com a implementção de uma interface,
        // O método ProcessDoc será herdado de Device,
        // E agora o método Scan é herdado de ISCanner.
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner processing: " + document);
        }

        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
