namespace FurnitureNS
{
    public class Furniture
    {
        private float cost;
        private int height;
        private int width;
        private string name;

        public string Name { get => name; protected set => name = value; }
        public int Width { get => width; protected set => width = value; }
        public int Height { get => height; protected set => height = value; }
        public float Cost { get => cost; protected set => cost = value; }

        public Furniture()
        {
            this.name = "IKEA";
            this.width = 50;
            this.height = 70;
            this.cost = 19.99f;
        }
        public Furniture(string name, int width, int height, float cost)
        {
            this.Name = name;
            this.Width = width;
            this.Height = height;
            this.Cost = cost;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Furniture info:\nName: {Name}, Width: {Width}, Height: {Height}, Cost: {Cost}");
        } 
    }
}
