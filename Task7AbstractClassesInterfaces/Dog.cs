namespace Task7AbstractClassesInterfaces
{
    public class Dog : Animal
    {
        public uint TailLenght { get; private set; }
        public override string? Name { get; protected set; }
        public override int PosX { get; protected set; }
        public override int PosY { get; protected set; }
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
