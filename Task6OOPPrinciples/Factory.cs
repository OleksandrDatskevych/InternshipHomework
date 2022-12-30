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
                furniture = new Furniture[5]
                {
                    new Table(),
                    new Chair(),
                    new Table("Epicenter", 80, 100, 150, 39.99f),
                    new Chair("New Line", 50, 60, 8.99f, false),
                    new Table("Table & Chair", 100, 100, 200, 35.99f)
                };
            }
            else
            {
                Console.WriteLine("Empty factory has been created");
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
            if (Furnitures is not null)
            {
                Console.WriteLine($"Amount of furniture in factory {Furnitures.Length}");
            }
            else
            {
                Console.WriteLine("No furniture in factory");
            }
        }

        public void ListOfFurniture()
        {
            if (Furnitures is not null)
            {
                for (var i = 0; i < Furnitures.Length; i++)
                {
                    Console.WriteLine($"\nFurniture number: {i + 1}");
                    Furnitures[i].Print();
                }
            }
            else
            {
                Console.WriteLine("No furniture in factory");
            }
        }

        public void ListOfFurnitureByName()
        {
            if (Furnitures is not null)
            {
                Console.WriteLine("\nEnter a name of furniture to get the list of furniture by name");
                var name = Console.ReadLine();
                var isFound = false;

                for (var i = 0; i < Furnitures.Length; i++)
                {
                    if (name is not null)
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
            }
            else
            {
                Console.WriteLine("No furniture in factory");
            }
        }

        public void ListOfFurnitureByCost()
        {
            if (Furnitures is not null)
            {
                Console.WriteLine("\nEnter your estimated budget");
                var cost = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("List of furniture in factory:");
                var isFound = false;

                for (var i = 0; i < Furnitures.Length; i++)
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
            }
            else
            {
                Console.WriteLine("No furniture in factory");
            }
        }

        public void AssembleTable()
        {
            if (Furnitures is not null)
            {
                Console.WriteLine("\nEnter a number of table to assemble:");
                var furnitureNumber = Convert.ToInt32(Console.ReadLine());

                if (furnitureNumber <= Furnitures.Length && furnitureNumber > 0 && Furnitures[furnitureNumber - 1] is Table tableTemp)
                {
                    Table table = tableTemp;
                    table.Assemble();
                }
                else if (Furnitures[furnitureNumber - 1] is not Table)
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
            if (Furnitures is null)
            {
                Console.WriteLine("Enter amount of furniture to fill factory:");
                var amount = Convert.ToUInt32(Console.ReadLine());
                Furnitures = new Furniture[amount];

                for (var i = 0; i < amount; i++)
                {
                    Furnitures[i] = CreateFurniture();
                }
            }
            else
            {
                Console.WriteLine("Factory is already filled with furniture");
            }
        }

        public static Furniture CreateFurniture()
        {
            var tableLength = 0;
            var chairBack = false;
            string? furnType;
            string? furnName;

            Console.WriteLine($"Enter information about item:");

            do
            {
                Console.WriteLine("Is it table or chair?");
                furnType = Console.ReadLine();
            } while (furnType is null || furnType == "");

            do
            {
                Console.WriteLine($"Enter name of {furnType}");
                furnName = Console.ReadLine();
            } while (furnName is null || furnName == "");

            Console.WriteLine($"Enter width of {furnType}");
            var furnWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter height of {furnType}");
            var furnHeight = Convert.ToInt32(Console.ReadLine());

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
            var furnCost = Convert.ToSingle(Console.ReadLine());
            Furniture furniture = furnType.ToUpper() switch
            {
                "TABLE" => furnName switch
                {
                    not null => new Table(furnName, furnWidth, furnHeight, tableLength, furnCost),
                    _ => new Table("No name", furnWidth, furnHeight, tableLength, furnCost)
                },
                "CHAIR" => furnName switch
                {
                    not null => new Chair(furnName, furnWidth, furnHeight, furnCost, chairBack),
                    _ => new Chair("No name", furnWidth, furnHeight, furnCost, chairBack)
                },
                _ => furnName switch
                {
                    not null => new Table(furnName, furnWidth, furnHeight, tableLength, furnCost),
                    _ => new Table("No name", furnWidth, furnHeight, tableLength, furnCost)
                }
            };

            return furniture;
        }

        public void AddFurniture()
        {
            if (Furnitures is not null)
            {
                Console.WriteLine("Enter amount of furniture to add to factory:");
                var amount = Convert.ToUInt32(Console.ReadLine());
                Furniture[] newFurnitures = new Furniture[Furnitures.Length + amount];

                for (var i = 0; i < Furnitures.Length; i++)
                {
                    newFurnitures[i] = Furnitures[i];
                }

                for (var i = 0; i < newFurnitures.Length - Furnitures.Length; i++)
                {
                    newFurnitures[i + Furnitures.Length] = CreateFurniture();
                }

                Furnitures = newFurnitures;
            }
            else
            {
                FillFactory();
            }
        }
    }
}