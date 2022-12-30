namespace Task7Part3
{
    public class Polaroid : Product, IPhoto, IPrint
    {
        private readonly int _paperWidth;
        private readonly int _paperHeight;
        private readonly double _numberOfPixelsInCamera;

        public Polaroid(int paperWidth, int paperHeight, double numberOfPixelsInCamera, string? modelName, decimal price) : base(modelName, price)
        {
            _paperWidth = paperWidth;
            _paperHeight = paperHeight;
            _numberOfPixelsInCamera = numberOfPixelsInCamera;
        }

        public override string Description
        {
            get => $"Price: {price}, model: {modelName}, number of pixels in camera: {_numberOfPixelsInCamera}, paper width: {_paperWidth}, " +
                $"paper height: {_paperHeight}";
        }

        public void TakePhoto()
        {
            Console.WriteLine("Press black button at the top and photo is ready");
        }

        public void Print()
        {
            Console.WriteLine("Printing photo...");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Press right side button");
        }
    }
}
