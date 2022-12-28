namespace Task7AbstractClassesInterfaces
{
    public abstract class Animal : IMove, ISpeak, IAttack
    {
        protected string? name;
        protected int posX;
        protected int posY;
        protected string? description;

        public abstract string Name { get; protected set; }
        public abstract int PosX { get; protected set; }
        public abstract int PosY { get; protected set; }
        protected abstract string? Description { get; }

        public Animal()
        {
            Name = "";
            posX = 0;
            posY = 0;
        }
        public void PrintPosition()
        {
            Console.WriteLine($"{Name} position is X:{PosX}, Y:{PosY}");
        }

        public abstract void PrintDescription();
        public void MoveForward()
        {
            MoveForward(1);
        }

        public abstract void MoveForward(uint steps);
        public void MoveTo(int x, int y)
        {
            PosX = x;
            PosY = y;
            if (this is Cat)
            {
                Console.WriteLine($"Position of cat named {Name} has been changed to X: {PosX}, Y: {PosY}");
            }
            else if (this is Dog)
            {
                Console.WriteLine($"Position of dog named {Name} has been changed to X: {PosX}, Y: {PosY}");
            }
        }

        public abstract void MakeASound();
        public void AttackToRight(Animal animal)
        {
            if (PosX == animal.PosX - 1 || PosY == animal.PosY)
            {
                Console.WriteLine($"{Name} (position: X: {PosX}, Y: {PosY}) attacked {animal.Name} (position: X: {animal.PosX}, Y: {animal.PosY})");
                IAttack.AddAttack();
                MakeASound();
            }
            else
            {
                if (this is Cat)
                {
                    Console.WriteLine($"Cat {Name} has nothing to attack");
                }
                else if (this is Dog)
                {
                    Console.WriteLine($"Dog {Name} has nothing to attack");
                }
            }
        }

        public void AttackToLeft(Animal animal)
        {
            if (PosX == animal.PosX + 1 || PosY == animal.PosY)
            {
                Console.WriteLine($"{Name} (position: X: {PosX}, Y: {PosY}) attacked {animal.Name} (position: X: {animal.PosX}, Y: {animal.PosY})");
                IAttack.AddAttack();
                MakeASound();
            }
            else
            {
                if (this is Cat)
                {
                    Console.WriteLine($"Cat {Name} has nothing to attack");
                }
                else if (this is Dog)
                {
                    Console.WriteLine($"Dog {Name} has nothing to attack");
                }
            }
        }

        public void AttackForward(Animal animal)
        {
            if (PosY == animal.PosY - 1 || PosX == animal.PosX)
            {
                Console.WriteLine($"{Name} (position: X: {PosX}, Y: {PosY}) attacked {animal.Name} (position: X: {animal.PosX}, Y: {animal.PosY})");
                IAttack.AddAttack();
                MakeASound();
            }
            else
            {
                if (this is Cat)
                {
                    Console.WriteLine($"Cat {Name} has nothing to attack");
                }
                else if (this is Dog)
                {
                    Console.WriteLine($"Dog {Name} has nothing to attack");
                }
            }
        }

        public void AttackBackward(Animal animal)
        {
            if (PosY == animal.PosY + 1 || PosX == animal.PosX)
            {
                Console.WriteLine($"{Name} (position: X: {PosX}, Y: {PosY}) attacked {animal.Name} (position: X: {animal.PosX}, Y: {animal.PosY})");
                IAttack.AddAttack();
                MakeASound();
            }
            else
            {
                if (this is Cat)
                {
                    Console.WriteLine($"Cat {Name} has nothing to attack");
                }
                else if (this is Dog)
                {
                    Console.WriteLine($"Dog {Name} has nothing to attack");
                }
            }
        }
    }
}
