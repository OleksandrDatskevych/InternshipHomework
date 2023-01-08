namespace Task7Part4
{
    internal class Room
    {
        public string? RoomType { get; private set; }
        public float RoomArea { get; private set; }
        public byte NumWindows { get; private set; }

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
