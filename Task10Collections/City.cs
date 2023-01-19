namespace Task10Collections
{
    internal class City
    {
        public int Population { get; private set; }
        public double Area { get; private set; }

        public City(int population, double area)
        {
            Population = population;
            Area = area;
        }
    }
}
