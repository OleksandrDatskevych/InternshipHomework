namespace FurnitureNS
{
    public class Furniture
    {
        private string? _name;

        public string Name
        {
            get
            {
                if (_name == null)
                {
                    return "Name is null";
                }
                else
                {
                    return _name;
                }
            }

            set => _name = value;
        }

        public int Width { get; protected set; }
        public int Height { get; protected set; }
        public float Cost { get; protected set; }

        public Furniture()
        {
            Name = "IKEA";
            Width = 50;
            Height = 70;
            Cost = 19.99f;
        }

        public Furniture(string name, int width, int height, float cost)
        {
            Name = name;
            Width = width;
            Height = height;
            Cost = cost;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Furniture info:\nName: {Name}, Width: {Width}, Height: {Height}, Cost: {Cost}");
        } 
    }
}
