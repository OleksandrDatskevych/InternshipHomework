namespace Task7AbstractClassesInterfaces
{
    public abstract class Animal : IMove, ISpeak, IAttack
    {
        public abstract string? Name { get; protected set; }
        public abstract int PosX { get; protected set; }
        public abstract int PosY { get; protected set; }
        protected abstract string? Description { get; }

        protected Animal()
        {
            Name = "";
            PosX = 0;
            PosY = 0;
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
            var animalType = "";

            if (this is Cat)
            {
                animalType = "cat";
            }
            else if (this is Dog)
            {
                animalType = "dog";
            }
            Console.WriteLine($"Position of {animalType} named {Name} has been changed to X: {PosX}, Y: {PosY}");
        }

        public abstract void MakeASound();

        public void DoAttack(Animal animal)
        {
            Console.WriteLine($"{Name} (position: X: {PosX}, Y: {PosY}) attacked {animal.Name} (position: X: {animal.PosX}, Y: {animal.PosY})");
            IAttack.AddAttack();
            MakeASound();
        }

        public void DontAttack()
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
        public void AttackToRight(Animal animal)
        {
            if (PosX == animal.PosX - 1 && PosY == animal.PosY)
            {
                DoAttack(animal);
            }
            else
            {
                DontAttack();
            }
        }

        public void AttackToLeft(Animal animal)
        {
            if (PosX == animal.PosX + 1 && PosY == animal.PosY)
            {
                DoAttack(animal);
            }
            else
            {
                DontAttack();
            }
        }

        public void AttackForward(Animal animal)
        {
            if (PosY == animal.PosY - 1 && PosX == animal.PosX)
            {
                DoAttack(animal);
            }
            else
            {
                DontAttack();
            }
        }

        public void AttackBackward(Animal animal)
        {
            if (PosY == animal.PosY + 1 && PosX == animal.PosX)
            {
                DoAttack(animal);
            }
            else
            {
                DontAttack();
            }
        }
    }
}
