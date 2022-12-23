using FurnitureNS;
using TableNS;
using ChairNS;

namespace FactoryNS
{
    internal class Factory
    {
        private Furniture[]? furniture;

        public Furniture[]? Furnitures { get => furniture; private set => furniture = value; }

        public Factory(bool isFilled)
        {
            if (isFilled)
            {
                furniture = new Furniture[5] {
                    new Table(),
                    new Chair(),
                    new Table("Epicenter", 80, 100, 150, 39.99f),
                    new Chair("New Line", 50, 60, 8.99f, false),
                    new Table("Table & Chair", 100, 100, 200, 35.99f)
                };
            } else
            {
                furniture = null;
            }
        }
        public Factory(Furniture[]? furniture)
        {
            Furnitures = furniture;
        }

        public static void AssembleTable(Table table)
        {
            table.Assemble();
        }

        public void ShowAmountOfFurniture()
        {
            if (Furnitures != null)
                Console.WriteLine($"Amount of furniture in factory {Furnitures.Length}");
            else
                Console.WriteLine("No furniture in factory");
        }

        public void ListOfFurniture()
        {
            if (Furnitures != null)
            {
                for (int i = 0; i < Furnitures.Length; i++)
                {
                    Console.WriteLine($"\nFurniture number: {i + 1}");
                    Furnitures[i].Print();
                }
            } else
            {
                Console.WriteLine("No furniture in factory");
            }
        }

        public void ListOfFurnitureByName()
        {
            if (Furnitures != null)
            {
                Console.WriteLine("\nEnter a name of furniture to get the list of furniture by name");
                string? name = Console.ReadLine();
                bool isFound = false;
                for (int i = 0; i < Furnitures.Length; i++)
                {
                    if (name != null)
                    {
                        if (Furnitures[i].Name.ToUpper() == name.ToUpper())
                        {
                            Console.WriteLine($"Furniture number: {i + 1}");
                            isFound = true;
                            Furnitures[i].Print();
                        }
                    }
                    else
                    {
                        Console.WriteLine("No name entered");
                    }
                }
                if (!isFound)
                {
                    Console.WriteLine($"Furniture with name {name} were not found");
                }
            } else
            {
                Console.WriteLine("No furniture in factory");
            }
        }

        public void ListOfFurnitureByCost()
        {
            if (Furnitures != null)
            {
                Console.WriteLine("\nEnter your estimated budget");
                float cost = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("List of furniture in factory:");
                bool isFound = false;
                for (int i = 0; i < Furnitures.Length; i++)
                {
                    if (Furnitures[i].Cost <= cost)
                    {
                        Console.WriteLine($"Table number: {i + 1}");
                        isFound = true;
                        Furnitures[i].Print();
                    }
                }
                if (!isFound)
                {
                    Console.WriteLine($"Furniture with cost below {cost} were not found");
                }
            } else
            {
                Console.WriteLine("No furniture in factory");
            }
        }

        public void AssembleTable()
        {
            if (Furnitures != null)
            {
                Console.WriteLine("\nEnter a number of table to assemble:");
                int furnitureNumber = Convert.ToInt32(Console.ReadLine());
                if (furnitureNumber <= Furnitures.Length && furnitureNumber > 0 && Furnitures[furnitureNumber - 1] is Table)
                {
                    Table table = (Table)Furnitures[furnitureNumber - 1];
                    table.Assemble();
                }
                else if (this.Furnitures[furnitureNumber - 1] is not Table)
                {
                    Console.WriteLine($"This furniture is not a table and can't be assembled");
                }
            }
            else
            {
                Console.WriteLine("No furniture in factory");
            }
        }

        public void FillFactory()
        {
            if (Furnitures == null)
            {
                Console.WriteLine("Enter amount of furniture to fill factory:");
                uint amount = Convert.ToUInt32(Console.ReadLine());
                Furnitures = new Furniture[amount];
                for (int i = 0; i < amount; i++)
                    Furnitures[i] = CreateFurniture();
            }
            else
            {
                Console.WriteLine("Factory is already filled with furniture");
            }
        }

        public Furniture CreateFurniture()
        {
            int tableLength = 0;
            bool chairBack = false;
            string? furnType;
            string? furnName;
            Furniture furniture;

            Console.WriteLine($"Enter information about item:");
            do
            {
                Console.WriteLine("Is it table or chair?");
                furnType = Console.ReadLine();
            } while (furnType == null || furnType == "");
            do
            {
                Console.WriteLine($"Enter name of {furnType}");
                furnName = Console.ReadLine();
            } while (furnName == null || furnName == "");
            Console.WriteLine($"Enter width of {furnType}");
            int furnWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter height of {furnType}");
            int furnHeight = Convert.ToInt32(Console.ReadLine());
            if (furnType.ToUpper() == "TABLE")
            {
                Console.WriteLine("Enter length of table");
                tableLength = Convert.ToInt32(Console.ReadLine());
            }
            else if (furnType.ToUpper() == "CHAIR")
            {
                Console.WriteLine("Does this chair have a back? (true/false)");
                chairBack = Convert.ToBoolean(Console.ReadLine());
            }
            Console.WriteLine($"Enter cost of {furnType}");
            float furnCost = Convert.ToSingle(Console.ReadLine());

            if (furnType.ToUpper() == "TABLE")
                if (furnName != null)
                    furniture = new Table(furnName, furnWidth, furnHeight, tableLength, furnCost);
                else
                    furniture = new Table("No name", furnWidth, furnHeight, tableLength, furnCost);
            else if (furnType.ToUpper() == "CHAIR")
                if (furnName != null)
                    furniture = new Chair(furnName, furnWidth, furnHeight, furnCost, chairBack);
                else
                    furniture = new Chair("No name", furnWidth, furnHeight, furnCost, chairBack);
            else
            {
                if (furnName != null)
                    furniture = new Table(furnName, furnWidth, furnHeight, tableLength, furnCost);
                else
                    furniture = new Table("No name", furnWidth, furnHeight, tableLength, furnCost);
            }
            return furniture;
        }

        public void AddFurniture()
        {
            if (Furnitures != null) {
                Console.WriteLine("Enter amount of furniture to add to factory:");
                uint amount = Convert.ToUInt32(Console.ReadLine());
                Furniture[] newFurnitures = new Furniture[Furnitures.Length + amount];
                for (int i = 0; i < Furnitures.Length; i++)
                {
                    newFurnitures[i] = Furnitures[i];
                }
                for (int i = 0; i < newFurnitures.Length - Furnitures.Length; i++)
                    newFurnitures[i + Furnitures.Length] = CreateFurniture();
                Furnitures = newFurnitures;
            } else
                FillFactory();
        }
    }
}