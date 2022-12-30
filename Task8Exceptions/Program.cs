using Task8Exceptions;

internal class Program
{
    static void Main(string[] args)
    {
        MassiveElement.ShowMassiveElement();
        Cat cat = new();
        cat.Print();
        cat.ChangeInfo();
        cat.Print();
        cat.ChangeInfo();
        cat.Print();
        cat.ChangeInfo();
        cat.Print();
    }
}