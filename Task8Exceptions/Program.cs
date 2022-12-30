using Task8Exceptions;

internal class Program
{
    static void Main(string[] args)
    {
        MassiveElement m = new();
        m.ShowMassiveElement();

        Cat cat = new();
        cat.Print();
        cat.ChangeInfo();
        cat.Print();
    }
}