using FurnitureNS;

namespace TableNS
{
    public class Table : Furniture
    {
        private bool _isAssembled;
        private int _length;

        public int Length { get => _length; private set => _length = value; }
        public bool IsAssembled { get => _isAssembled; private set => _isAssembled = value; }

        public Table() : base("IKEA", 80, 80, 39.99f)
        {
            Length = 120;
            IsAssembled = false;
        }

        public Table(string name, int width, int height, int lenght, float cost) : base(name, width, height, cost)
        {
            Length = lenght;
            IsAssembled = false;
        }

        public override void Print()
        {
            Console.WriteLine($"Table info:\nName: {Name}, Width: {Width}, Height: {Height}, Length: {Length}, Cost: {Cost}");
        }

        public void Assemble()
        {
            if (!IsAssembled)
            {
                Console.WriteLine("Assembling table...");
                IsAssembled = true;
                Console.WriteLine($"Table {Name} has been assembled");
            }
            else
            {
                Console.WriteLine($"Table {Name} has already been assembled");
            }
        }
    }
}