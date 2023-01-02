namespace FurnitureNS
{
    public class Furniture
    {
        private float _cost;
        private int _height;
        private int _width;
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
        public int Width { get => _width; protected set => _width = value; }
        public int Height { get => _height; protected set => _height = value; }
        public float Cost { get => _cost; protected set => _cost = value; }

        public Furniture()
        {
            _name = "IKEA";
            _width = 50;
            _height = 70;
            _cost = 19.99f;
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
