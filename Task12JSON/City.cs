namespace Task12JSON
{
    internal class City
    {
        public string? cityName;
        public int id;
        public bool isOkay;
        public DateTime dateTime;
        public List<Person>? listOfPeople;

        public City(string? cityName, int id, bool isOkay, DateTime dateTime, List<Person>? listOfPeople)
        {
            this.cityName = cityName;
            this.id = id;
            this.isOkay = isOkay;
            this.dateTime = dateTime;
            this.listOfPeople = listOfPeople;
        }
    }
}
