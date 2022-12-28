namespace Task7AbstractClassesInterfaces
{
    public class Cat : Animal, IMove, ISpeak, IAttack
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

        public void Move()
        {
            PosX++;
            PosY++;
            Console.WriteLine($"Cat {Name} has moved to X:{PosX}, Y:{PosY}");
        }

        public void MoveForward()
        {
            MoveForward(1);
        }

        public void MoveForward(uint steps)
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

        public void MoveTo(int x, int y)
        {
            PosX = x;
            PosY = y;
            Console.WriteLine($"Cat's position with name {Name} has been changed to X: {PosX}, Y: {PosY}");
        }

        public void MakeASound()
        {
            Console.WriteLine("Meow");
        }

        public void AttackToRight(Animal animal)
        {
            if (PosX == animal.PosX - 1)
            {
                Console.WriteLine($"{Name} (position: X: {PosX}, Y: {PosY}) attacked {animal.Name} (position: X: {animal.PosX}, Y: {animal.PosY})");
                IAttack.AddAttack();
            }
            else
            {
                Console.WriteLine($"Cat {Name} has nothing to attack");
            }
        }

        public void AttackToLeft(Animal animal)
        {
            if (PosX == animal.PosX + 1)
            {
                Console.WriteLine($"{Name} (position: X: {PosX}, Y: {PosY}) attacked {animal.Name} (position: X: {animal.PosX}, Y: {animal.PosY})");
                IAttack.AddAttack();
            }
            else
            {
                Console.WriteLine($"Cat {Name} has nothing to attack");
            }
        }

        public void AttackForward(Animal animal)
        {
            if (PosY == animal.PosY - 1)
            {
                Console.WriteLine($"{Name} (position: X: {PosX}, Y: {PosY}) attacked {animal.Name} (position: X: {animal.PosX}, Y: {animal.PosY})");
            }
            else
            {
                Console.WriteLine($"Cat {Name} has nothing to attack");
            }
        }

        public void AttackBackward(Animal animal)
        {
            if (PosY == animal.PosY + 1)
            {
                Console.WriteLine($"{Name} (position: X: {PosX}, Y: {PosY}) attacked {animal.Name} (position: X: {animal.PosX}, Y: {animal.PosY})");
            }
            else
            {
                Console.WriteLine($"Cat {Name} has nothing to attack");
            }
        }

        public override void PrintDescription()
        {
            Console.WriteLine($"Cat's info:\n{Description}");
        }
    }
}
