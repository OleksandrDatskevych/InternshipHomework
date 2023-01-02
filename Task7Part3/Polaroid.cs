namespace Task7Part3
{
    public class Polaroid : Product, IPhoto, IPrint
    {
        private readonly int paperWidth;
        private readonly int paperHeight;
        private readonly double numberOfPixelsInCamera;

        public Polaroid(int paperWidth, int paperHeight, double numberOfPixelsInCamera, string? modelName, decimal price) : base(modelName, price)
        {
            this.paperWidth = paperWidth;
            this.paperHeight = paperHeight;
            this.numberOfPixelsInCamera = numberOfPixelsInCamera;
        }

        public override string Description
        {
            get => $"Price: {price}, model:{modelName}, number of pixels in camera: {numberOfPixelsInCamera}, paper width: {paperWidth}, " +
                $"paper height: {paperHeight}";
        }

        public void TakePhoto()
        {
            Console.WriteLine("Press black button at the top and photo is ready");
        }

        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Press right side button");
        }
    }
}
