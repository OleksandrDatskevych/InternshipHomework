namespace Task7AbstractClassesInterfaces
{
    public class Dog : Animal
    {
        private uint _tailLenght;

        public uint TailLenght { get => _tailLenght; private set => _tailLenght = value; }
        public override string? Name { get => name; protected set => name = value; }
        public override int PosX { get => posX; protected set => posX = value; }
        public override int PosY { get => posY; protected set => posY = value; }
        protected override string? Description { get => $"Name: {Name}\nTail length: {TailLenght}\nPosition: X:{PosX}, Y:{PosY}"; }

        public Dog() : base()
        {
            Name = "Bilba";
            TailLenght = 15;
        }

        public override void MoveForward(uint steps)
        {
            PosY += (int)steps * 4;
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
            Console.WriteLine("Woof");
        }

        public override void PrintDescription()
        {
            Console.WriteLine($"Dog's info:\n{Description}");
        }

        public void DoABackflip()
        {
            Console.WriteLine($"{Name} did a backflip");
        }
    }
}
