namespace Task7AbstractClassesInterfaces
{
    public class Cat : Animal
    {
        public string? Color { get; private set; }
        public override string? Name { get; protected set; }
        public override int PosX { get; protected set; }
        public override int PosY { get; protected set; }
        protected override string? Description { get => $"Name: {Name}\nColor: {Color}\nPosition: X:{PosX}, Y:{PosY}"; }

        public Cat() : base()
        {
            Name = "Nėra";
            Color = "Black";
        }

        public override void MoveForward(uint steps)
        {
            PosY += (int)steps * 2;

            if (steps == 1)
            {
                Console.WriteLine($"{Name} moved one step forward");
            }
            else
            {
                Console.WriteLine($"{Name} moved {steps} steps forward");
            }
        }

        public override void MakeASound()
        {
            Console.WriteLine("Meow");
        }

        public override void PrintDescription()
        {
            Console.WriteLine($"Cat's info:\n{Description}");
        }
    }
}
