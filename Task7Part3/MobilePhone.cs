namespace Task7Part3
{
    public class MobilePhone : Product, IPhoto
    {
        private readonly double numberOfPixelsInCamera;

        public MobilePhone(double numberOfPixelsInCamera, string? modelName, decimal price) : base(modelName, price)
        {
            this.numberOfPixelsInCamera = numberOfPixelsInCamera;
        }

        public override string Description
        {
            get => $"Price: {price}, model:{modelName}, number of pixels in camera: {numberOfPixelsInCamera}";
        }

        public void TakePhoto()
        {
            Console.WriteLine("Press button on the screen and photo is ready");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Press left side button");
        }
    }
}
