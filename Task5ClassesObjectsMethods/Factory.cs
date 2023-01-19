using TableNS;

namespace FactoryNS
{
    public class Factory
    {
        public Table[]? Tables { get; set; }

        public Factory()
        {
            Tables = new Table[5]
            {
                new Table("Epicenter"),
                new Table("New Line", 250, 100, 35.99f),
                new Table() { Width = 100, Height = 50, Cost = 15.49f },
                new Table(),
                new Table("Table & Chair", 150, 90, 19.99f)
            };
        }

        public static void AssembleTable(Table table)
        {
            table.Assemble();
        }

        public int GetAmountOfTables()
        {
            return Tables.Length;
        }

        public void ListOfTables()
        {
            for (var i = 0; i < Tables.Length; i++)
            {
                Console.WriteLine($"\nTable number: {i + 1}");
                Tables[i].Print();
            }
        }

        public void ListOfTablesByName(string? name)
        {
            if (name is not null)
            {
                var isFound = false;

                for (var i = 0; i < Tables.Length; i++)
                {
                    if (Tables[i].Name.ToUpper() == name.ToUpper())
                    {
                        Console.WriteLine($"Table number: {i + 1}");
                        isFound = true;
                        Tables[i].Print();
                    }
                }

                if (!isFound)
                {
                    Console.WriteLine($"Tables with name {name} were not found");
                }
            }
            else
            {
                Console.WriteLine("Name is null error");
            }
        }

        public void ListOfTablesByCost(float cost)
        {
            var isFound = false;

            for (var i = 0; i < Tables.Length; i++)
            {
                if (Tables[i].Cost <= cost)
                {
                    Console.WriteLine($"Table number: {i + 1}");
                    isFound = true;
                    Tables[i].Print();
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"Tables with cost below {cost} were not found");
            }
        }
    }
}