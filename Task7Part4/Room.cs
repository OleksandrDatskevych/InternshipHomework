namespace Task7Part4
{
    internal class Room
    {
        private string? _roomType;
        private float _roomArea;
        private byte _numWindows;

        public string? RoomType { get => _roomType; private set => _roomType = value; }
        public float RoomArea { get => _roomArea; private set => _roomArea = value; }
        public byte NumWindows { get => _numWindows; private set => _numWindows = value; }

        public Room()
        {
            RoomType = "Bedroom";
            RoomArea = 15.5f;
            NumWindows = 2;
        }

        public Room(string? roomType, float roomArea, byte numWindows)
        {
            RoomType = roomType;
            RoomArea = roomArea;
            NumWindows = numWindows;
        }

        public Room(Room room)
        {
            RoomType = room.RoomType;
            RoomArea = room.RoomArea;
            NumWindows = room.NumWindows;
        }

        public void Print()
        {
            Console.WriteLine($"Room type: {RoomType}, Room area: {RoomArea}, Number of windows: {NumWindows}");
        }

        public void ChangeRoomInfo(string roomType, float roomArea, byte numWindows)
        {
            RoomType = roomType;
            RoomArea = roomArea;
            NumWindows = numWindows;
        }
    }
}
