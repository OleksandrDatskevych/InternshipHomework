using Task7Part4;

internal class Program
{
    static void Main(string[] args)
    {
        ApartmentBuilding building1 = new();
        ApartmentBuilding building2 = new(
            new Apartment[3]
            {
                new Apartment(
                    new Room[3]
                    {
                        new Room("Bedroom",14.5f,2),
                        new Room("Bathroom",6f,0),
                        new Room("Kitchen",10f,1)
                    },
                    2.4f,
                    false,
                    "Forced air heating"),
                new Apartment(
                    new Room[5]
                    {
                        new Room("Bedroom",16.2f,2),
                        new Room("Bathroom",5f,0),
                        new Room("Toilet",2f,0),
                        new Room("Living room",20f,3),
                        new Room("Kitchen",12f,2)
                    },
                    2.6f,
                    true,
                    "In-floor radiant heating"),
                new Apartment(
                    new Room[2]
                    {
                        new Room("Bedroom", 12.5f, 2),
                        new Room("Bathroom", 6.4f, 0)
                    },
                    2.2f,
                    false,
                    "Boiler and radiator system")
            },
            0,
            1
            );
        building2.Print();
        Console.ReadKey();
        Console.Clear();
        ApartmentBuilding building3 = (ApartmentBuilding)building2.Clone();
        building3.ChangeRoomInfo(3, 2, "Toilet", 5f, 1);
        Console.WriteLine("BUILDING 3");
        building3.Print();
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("BUILDING 2");
        building2.Print();
        Console.ReadKey();
        Console.Clear();
        ApartmentBuilding building4 = (ApartmentBuilding)building3.Clone();
        building4.ChangeRoomInfo(2, 1, "Gym", 10f, 2);
        building4.ChangeRoomInfo(2, 4, "Bedroom", 15f, 2);
        building4.Print();
        Console.ReadKey();
        Console.Clear();
        ApartmentBuilding[] buildings = { building2, building1, building4, building3 };
        Console.WriteLine("Array of building before sorting by area");
        foreach (ApartmentBuilding building in buildings)
        {
            building.Print();
            Console.ReadKey();
            Console.Clear();
        }
        Array.Sort(buildings);
        Console.WriteLine("Array of building after sorting by area");
        foreach(ApartmentBuilding building in buildings)
        {
            building.Print();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
