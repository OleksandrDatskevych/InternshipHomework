using FurnitureNS;

namespace TableNS
{
    public class Table : Furniture
    {
        private bool isAssembled;
        private int length;

        public int Length { get => length; private set => length = value; }
        public bool IsAssembled { get => isAssembled; private set => isAssembled = value; }

        public Table() : base("IKEA", 80, 80, 39.99f)
        {
            this.Length = 120;
            this.IsAssembled = false;
        }
        public Table(string name, int width, int height, int lenght, float cost) : base(name, width, height, cost)
        {
            Name = name;
            this.Width = width;
            this.Height = height;
            this.Length = lenght;
            this.Cost = cost;
            this.IsAssembled = false;
        }

        public override void Print()
        {
            Console.WriteLine($"Table info:\nName: {Name}, Width: {Width}, Height: {Height}, Length: {Length}, Cost: {Cost}");
        }

        public void Assemble()
        {
            if (IsAssembled)
            {
                Console.WriteLine($"Table {Name} has already been assembled");
            }
            else
            {
                Console.WriteLine("Assembling table...");
                this.IsAssembled = true;
                Console.WriteLine($"Table {Name} has been assembled");
            }
        }
    }
}