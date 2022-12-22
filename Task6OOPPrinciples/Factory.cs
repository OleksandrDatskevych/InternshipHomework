using FurnitureNS;
using TableNS;
using ChairNS;

namespace FactoryNS
{
    internal class Factory
    {
        public Furniture[] furniture = new Furniture[5] {
            new Table(),
            new Chair(),
            new Table("Epicenter", 80, 100, 150, 39.99f),
            new Chair("New Line", 50, 60, 8.99f, false),
            new Table("Table & Chair", 100, 100, 200, 35.99f)
        };

        public void AssembleTable(Table table)
        {
            table.Assemble();
        }

        public int GetAmountOfFurniture()
        {
            return furniture.Length;
        }

        public void ListOfFurniture()
        {
            for (int i = 0; i < furniture.Length; i++)
            {
                Console.WriteLine($"\nFurniture number: {i + 1}");
                furniture[i].Print();
            }
        }

        public void ListOfFurnitureByName(string name)
        {
            bool isFound = false;
            for (int i = 0; i < furniture.Length; i++)
            {
                if (furniture[i].Name.ToUpper() == name.ToUpper())
                {
                    Console.WriteLine($"Furniture number: {i + 1}");
                    isFound = true;
                    furniture[i].Print();
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"Furniture with name {name} were not found");
            }
        }

        public void ListOfFurnitureByCost(float cost)
        {
            bool isFound = false;
            for (int i = 0; i < furniture.Length; i++)
            {
                if (furniture[i].Cost <= cost)
                {
                    Console.WriteLine($"Table number: {i + 1}");
                    isFound = true;
                    furniture[i].Print();
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"Furniture with cost below {cost} were not found");
            }
        }
    }
}