namespace TableNS
{
    public class Table
    {
        public string name;
        public int width;
        public int height;
        public float cost;
        private bool isAssembled;
        public Table() : this("IKEA", 150, 80, 39.99f) { }
        public Table(string name) : this(name, 150, 80, 39.99f) { }
        public Table(int width, int height, float cost) : this("IKEA", width, height, cost) { }
        public Table(string name, int width, int height, float cost)
        {
            this.name = name;
            this.width = width;
            this.height = height;
            this.cost = cost;
            this.isAssembled = false;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {name}, Width: {width}, Height: {height}, Cost: {cost}");
        }

        public void Assemble()
        {
            if (isAssembled)
            {
                Console.WriteLine($"Table {name} has already been assembled");
            }
            else
            {
                Console.WriteLine("Assembling table...");
                this.isAssembled = true;
                Console.WriteLine($"Table {name} has been assembled");
            }
        }
    }
}