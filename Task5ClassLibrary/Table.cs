namespace TableNS
{
    public class Table
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public float Cost { get; set; }
        private bool IsAssembled { get; set; }

        public Table() : this("IKEA", 150, 80, 39.99f)
        {

        }

        public Table(string name) : this(name, 150, 80, 39.99f)
        {

        }

        public Table(int width, int height, float cost) : this("IKEA", width, height, cost)
        {

        }

        public Table(string name, int width, int height, float cost)
        {
            Name = name;
            Width = width;
            Height = height;
            Cost = cost;
            IsAssembled = false;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Width: {Width}, Height: {Height}, Cost: {Cost}");
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
                IsAssembled = true;
                Console.WriteLine($"Table {Name} has been assembled");
            }
        }
    }
}
