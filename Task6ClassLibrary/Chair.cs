using FurnitureNS;

namespace ChairNS
{
    public class Chair : Furniture
    {
        private bool _hasBack;

        public bool HasBack { get => _hasBack; private set => _hasBack = value; }

        public Chair() : base("IKEA", 40, 60, 13.99f)
        {
            HasBack = true;
        }

        public Chair(string name, int width, int height, float cost, bool back) : base(name, width, height, cost)
        {
            HasBack = back;
        }

        public override void Print()
        {
            Console.WriteLine($"Chair info:\nName: {Name}, Width: {Width}, Height: {Height}, Has Back?: {HasBack}, Cost: {Cost}");
        }
    }
}
