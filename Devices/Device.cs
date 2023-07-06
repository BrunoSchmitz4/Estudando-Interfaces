namespace InterAppOne.Devices
{
    abstract class Device
    {
        public int SerialNumber { get; set; }

        // Método declarado
        public abstract void ProcessDoc(string document);
    }
}
