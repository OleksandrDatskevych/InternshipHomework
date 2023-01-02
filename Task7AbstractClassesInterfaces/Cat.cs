namespace Task7AbstractClassesInterfaces
{
    public class Cat : Animal
    {
        private string? _color;

        public string? Color { get => _color; private set => _color = value; }
        public override string? Name { get => name; protected set => name = value; }
        public override int PosX { get => posX; protected set => posX = value; }
        public override int PosY { get => posY; protected set => posY = value; }
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
