namespace Task7AbstractClassesInterfaces
{
    public class Dog : Animal, IMove, ISpeak, IAttack
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

        public void Move()
        {
            PosX+=2;
            PosY+=2;
            Console.WriteLine($"Dog {Name} has moved to X:{PosX}, Y:{PosY}");
        }

        public void MoveForward()
        {
            MoveForward(1);
        }

        public void MoveForward(uint steps)
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

        public void MoveTo(int x, int y)
        {
            PosX = x;
            PosY = y;
            Console.WriteLine($"Dog's position with name {Name} has been changed to X: {PosX}, Y: {PosY}");
        }

        public void MakeASound()
        {
            Console.WriteLine("Woof");
        }

        public void AttackToRight(Animal animal)
        {
            if (PosX == animal.PosX + 1)
            {
                Console.WriteLine($"{Name} (position: X: {PosX}, Y: {PosY}) attacked {animal.Name} (position: X: {animal.PosX}, Y: {animal.PosY})");
            }
            else
            {
                Console.WriteLine($"Dog {Name} has nothing to attack");
            }
        }

        public void AttackToLeft(Animal animal)
        {
            if (PosX == animal.PosX - 1)
            {
                Console.WriteLine($"{Name} (position: X: {PosX}, Y: {PosY}) attacked {animal.Name} (position: X: {animal.PosX}, Y: {animal.PosY})");
            }
            else
            {
                Console.WriteLine($"Dog {Name} has nothing to attack");
            }
        }

        public void AttackForward(Animal animal)
        {
            if (PosY == animal.PosY + 1)
            {
                Console.WriteLine($"{Name} (position: X: {PosX}, Y: {PosY}) attacked {animal.Name} (position: X: {animal.PosX}, Y: {animal.PosY})");
            }
            else
            {
                Console.WriteLine($"Dog {Name} has nothing to attack");
            }
        }

        public void AttackBackward(Animal animal)
        {
            if (PosY == animal.PosY - 1)
            {
                Console.WriteLine($"{Name} (position: X: {PosX}, Y: {PosY}) attacked {animal.Name} (position: X: {animal.PosX}, Y: {animal.PosY})");
            }
            else
            {
                Console.WriteLine($"Dog {Name} has nothing to attack");
            }
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
