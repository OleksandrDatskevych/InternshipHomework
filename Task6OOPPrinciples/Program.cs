using ChairNS;
using FactoryNS;
using FurnitureNS;
using TableNS;

namespace Task6OOPPriciples
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factoryOfFurniture = new Factory();

            int amountOfFurniture = factoryOfFurniture.GetAmountOfFurniture();
            Console.WriteLine($"Amount of tables in factory {amountOfFurniture}");

            Console.WriteLine("List of tables in factory:");
            factoryOfFurniture.ListOfFurniture();

            Console.WriteLine("\nEnter a number of table to assemble:");
            int furnitureNumber = Convert.ToInt32(Console.ReadLine());
            if (furnitureNumber <= amountOfFurniture && furnitureNumber > 0 && factoryOfFurniture.furniture[furnitureNumber - 1] is Table)
            {
                Table table = (Table)factoryOfFurniture.furniture[furnitureNumber - 1];
                table.Assemble();
            }
            else if (factoryOfFurniture.furniture[furnitureNumber - 1] is not Table)
            {
                Console.WriteLine($"This furniture is not a table and can't be assembled");
            }

            Console.WriteLine("\nEnter a name of furniture to get the list of furniture by name");
            factoryOfFurniture.ListOfFurnitureByName(Console.ReadLine());

            Console.WriteLine("\nEnter your estimated budget");
            factoryOfFurniture.ListOfFurnitureByCost(Convert.ToSingle(Console.ReadLine()));
        }
    }
}
