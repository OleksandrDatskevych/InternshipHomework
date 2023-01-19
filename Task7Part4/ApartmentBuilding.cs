namespace Task7Part4
{
    internal class ApartmentBuilding : ICloneable, IComparable<ApartmentBuilding>
    {
        public Apartment[]? Apartments { get; private set; }
        public byte Elevators { get; private set; }
        public byte Entrances { get; private set; }
        public byte Floors { get; private set; }
        public float TotalArea { get; private set; }

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

            for (var i = 0; i < building.Apartments.Length; i++)
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

                for (var i = 0; i < Apartments.Length; i++)
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
            Apartments[apart - 1].ChangeRoomInfo(room, roomType, roomArea, numWindows);
            CalculateTotalArea();
            Console.WriteLine("Room info changed");
        }

        public object Clone()
        {
            ApartmentBuilding newBuilding = new(this);

            return newBuilding;
        }

        public int CompareTo(ApartmentBuilding? obj)
        {
            return TotalArea.CompareTo(obj.TotalArea);
        }
    }
}
