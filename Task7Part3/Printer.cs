namespace Task7Part3
{
    public class Printer : Product, IPrint
    {
        private readonly int paperWidth;
        private readonly int paperHeight;

        public Printer(string? modelName, decimal price, int paperWidth, int paperHeight) : base(modelName,price)
        {
            this.paperWidth = paperWidth;
            this.paperHeight = paperHeight;
        }

        public override string Description
        {
            get => $"Price: {price}, model:{modelName}, paper width:{paperWidth}, paper height:{paperHeight}";
        }

        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Press button at the top");
        }
    }
}
