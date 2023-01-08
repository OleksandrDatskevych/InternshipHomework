namespace Task12JSON
{
    internal class City
    {
        public string? CityName { get; set; }
        public int Id { get; set; }
        public bool IsOkay { get; set; }
        public DateTime DateAndTime { get; set; }
        public List<Person>? ListOfPeople { get; set; }

        public City(string? cityName, int id, bool isOkay, DateTime dateAndTime, List<Person>? listOfPeople)
        {
            CityName = cityName;
            Id = id;
            IsOkay = isOkay;
            DateAndTime = dateAndTime;
            ListOfPeople = listOfPeople;
        }
    }
}
