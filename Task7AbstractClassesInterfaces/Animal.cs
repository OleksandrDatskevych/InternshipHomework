namespace Task7AbstractClassesInterfaces
{
    public abstract class Animal
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
    }
}
