namespace Task7Part3
{
    public abstract class Product : IPower
    {
        protected readonly string? modelName;
        protected decimal price;

        public abstract string? Description { get; }

        protected Product(string? modelName, decimal price)
        {
            this.modelName = modelName;
            this.price = price;
        }

        public abstract void TurnOn();
        public void TurnOff()
        {
            Console.WriteLine("Press Turn Off button");
        }
    }
}
