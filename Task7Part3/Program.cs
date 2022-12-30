using Task7Part3;

internal class Program
{
    static void Main(string[] args)
    {
        Printer printer = new("Canon", 50.00m, 15, 30);
        printer.TurnOn();
        printer.Print();
        printer.TurnOff();
        Polaroid polaroid = new(12, 10, 10, "Nikon", 40);
        polaroid.TurnOn();
        polaroid.TakePhoto();
        polaroid.Print();
        Console.WriteLine(polaroid.Description);
        polaroid.TurnOff();
    }
}