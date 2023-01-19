namespace Task7Part3
{
    public class Printer : Product, IPrint
    {
        private readonly int _paperWidth;
        private readonly int _paperHeight;

        public Printer(string? modelName, decimal price, int paperWidth, int paperHeight) : base(modelName,price)
        {
            _paperWidth = paperWidth;
            _paperHeight = paperHeight;
        }

        public override string Description
        {
            get => $"Price: {price}, model: {modelName}, paper width: {_paperWidth}, paper height: {_paperHeight}";
        }

        public void Print()
        {
            Console.WriteLine("Printing document...");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Press button at the top");
        }
    }
}
