namespace Task7Part4
{
    internal class ApartmentBuilding
    {
        private Apartment[]? _apartments;
        private byte _elevators;
        private byte _entrances;
        private byte _floors;
        private float _totalArea;

        public Apartment[]? Apartments { get => _apartments; private set => _apartments = value; }
        public byte Elevators { get => _elevators; private set => _elevators = value; }
        public byte Entrances { get => _entrances; private set => _entrances = value; }
        public byte Floors { get => _floors; private set => _floors = value; }
        public float TotalArea { get => _totalArea; private set => _totalArea = value; }

        public ApartmentBuilding()
        {
            Apartments = new Apartment[4]
            {
                new Apartment(),
                new Apartment(),
                new Apartment(),
                new Apartment()
            };
            Elevators = 0;
            Entrances = (byte)(Apartments.Length + 1);
            Floors = 1;
            CalculateTotalArea();
        }

        public ApartmentBuilding(Apartment[] apartments, byte elevators, byte floors)
        {
            Apartments = apartments;
            Elevators = elevators;
            Entrances = (byte)(Apartments.Length + 1);
            Floors = floors;
            CalculateTotalArea();
        }

        public ApartmentBuilding(ApartmentBuilding building)
        {
            Apartment[] newAparts = new Apartment[building.Apartments.Length];
            for (int i = 0; i < building.Apartments.Length; i++)
            {
                newAparts[i] = new(building.Apartments[i]);
            }
            Apartments = newAparts;
            Elevators = building.Elevators;
            Floors = building.Floors;
            CalculateTotalArea();
        }

        public void Print()
        {
            Console.WriteLine("Building info:");
            if (Apartments is not null)
            {
                Console.WriteLine($"Floors: {Floors}, Entrances: {Entrances}, Elevators: {Elevators}, Number of apartments: {Apartments.Length}, " +
                    $"Total area: {TotalArea}");
                for (int i = 0; i < Apartments.Length; i++)
                {
                    Console.WriteLine($"\nApartment {i + 1} info:");
                    Apartments[i].Print();
                }
            }
            else
            {
                Console.WriteLine("No apartments in building");
            }
        }

        private void CalculateTotalArea()
        {
            TotalArea = 0;
            foreach (Apartment apartment in Apartments)
            {
                foreach (Room room in apartment.Rooms)
                {
                    TotalArea += room.RoomArea;
                }
            }
        }

        public void ChangeRoomInfo(int apart, int room, string roomType, float roomArea, byte numWindows)
        {
            this.Apartments[apart - 1].Rooms[room - 1].RoomType = roomType;
            this.Apartments[apart - 1].Rooms[room - 1].RoomArea = roomArea;
            this.Apartments[apart - 1].Rooms[room - 1].NumWindows = numWindows;
            CalculateTotalArea();
            Console.WriteLine("Room info changed");
        }

        public ApartmentBuilding Clone()
        {
            ApartmentBuilding newBuilding = new(this);

            return newBuilding;
        }
    }
}
