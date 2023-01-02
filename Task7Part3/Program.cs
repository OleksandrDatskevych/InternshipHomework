using Task7Part3;

internal class Program
{
    static void Main(string[] args)
    {
        Printer printer = new("Canon", 50.00m, 15, 30);
        printer.TurnOn();
        printer.TurnOff();
    }
}