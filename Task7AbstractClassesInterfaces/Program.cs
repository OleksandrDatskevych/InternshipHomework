using Task7AbstractClassesInterfaces;

class Program
{
    static void Main(string[] args)
    {
        Cat cat = new();
        Dog dog = new();
        cat.PrintPosition();
        dog.PrintPosition();
        dog.MoveTo(-1, 0);
        cat.AttackToLeft(dog);
        IAttack.PrintAttackCounter();
        dog.AttackToRight(cat);
        IAttack.PrintAttackCounter();
        dog.MoveForward();
        cat.MoveForward(2);
        cat.AttackToLeft(dog);
        Console.WriteLine($"Cat name: {cat.Name}");
        Console.WriteLine($"X position of cat {cat.Name} is {cat.PosX}");
        cat.PrintDescription();
        cat.PrintPosition();
        cat.MoveForward(20);
        cat.PrintPosition();
        cat.MoveForward();
        cat.PrintPosition();
        cat.MoveTo(4, 3);
        dog.MoveTo(100, -15);
        dog.PrintDescription();
        cat.PrintPosition();
        dog.PrintPosition();
        dog.PrintPosition();
    }
}