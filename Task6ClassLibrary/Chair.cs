using FurnitureNS;

namespace ChairNS
{
    public class Chair : Furniture
    {
        private bool hasBack;
        public bool HasBack { get => hasBack; private set => hasBack = value; }

        public Chair() : base("IKEA", 40, 60, 13.99f)
        {
            this.HasBack = true;
        }
        public Chair(string name, int width, int height, float cost, bool back) : base(name, width, height, cost)
        {
            Name = name;
            this.Width = width;
            this.Height = height;
            this.Cost = cost;
            this.HasBack = back;
        }

        public override void Print()
        {
            Console.WriteLine($"Chair info:\nName: {Name}, Width: {Width}, Height: {Height}, Has Back?: {HasBack}, Cost: {Cost}");
        }
    }
}
