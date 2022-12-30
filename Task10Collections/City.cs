namespace Task10Collections
{
    internal class City
    {
        private int population;
        private double area;

        public int Population { get => population; private set => population = value; }
        public double Area { get => area; private set => area = value; }

        public City(int population, double area)
        {
            Population = population;
            Area = area;
        }
    }
}
