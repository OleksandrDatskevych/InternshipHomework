namespace Task7Part4
{
    internal class Apartment
    {
        private Room[]? _rooms;
        private float _ceilingHeight;
        private bool _separateBathroom;
        private string? _typeOfHeating;

        public Room[]? Rooms { get => _rooms; private set => _rooms = value; }
        public float CeilingHeight { get => _ceilingHeight; private set => _ceilingHeight = value; }
        public bool SeparateBathroom { get => _separateBathroom; private set => _separateBathroom = value; }
        public string? TypeOfHeating { get => _typeOfHeating; private set => _typeOfHeating = value; }

        public Apartment()
        {
            Rooms = new Room[2]
            {
                new Room(),
                new Room()
            };
            CeilingHeight = 2.5f;
            SeparateBathroom = true;
            TypeOfHeating = "Furnace";
        }

        public Apartment(Room[] rooms, float ceilingHeight, bool separateBathroom, string? typeOfHeating)
        {
            Rooms = rooms;
            CeilingHeight = ceilingHeight;
            SeparateBathroom = separateBathroom;
            TypeOfHeating = typeOfHeating;
        }

        public Apartment(Apartment apartment)
        {
            Room[] newRooms = new Room[apartment.Rooms.Length];
            for (int i = 0; i < apartment.Rooms.Length; i++)
            {
                newRooms[i] = new(apartment.Rooms[i]);
            }
            Rooms = newRooms;
            CeilingHeight = apartment.CeilingHeight;
            SeparateBathroom = apartment.SeparateBathroom;
            TypeOfHeating = apartment.TypeOfHeating;
        }

        public void Print()
        {
            if (Rooms is not null)
            {
                Console.WriteLine($"Ceiling height: {CeilingHeight}, Separate bathroom: {SeparateBathroom}, typeOfHeating: {TypeOfHeating}, " +
                    $"Number of rooms {Rooms.Length}");
                for (int i = 0; i < Rooms.Length; i++)
                {
                    Console.WriteLine($"Room {i + 1} info:");
                    Rooms[i].Print();
                }
            }
            else
            {
                Console.WriteLine("No rooms in apartment");
            }
        }

        public void ChangeRoomInfo(int room, string roomType, float roomArea, byte numWindows)
        {
            Rooms[room - 1].ChangeRoomInfo(roomType, roomArea, numWindows);
        }
    }
}
