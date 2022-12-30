using TableNS;

namespace FactoryNS
{
    public class Factory
    {
        public Table[]? tables;

        public Factory()
        {
            tables = new Table[5] {
            new Table("Epicenter"),
            new Table("New Line", 250, 100, 35.99f),
            new Table() { width = 100, height = 50, cost = 15.49f },
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
            return tables.Length;
        }

        public void ListOfTables()
        {
            for (int i = 0; i < tables.Length; i++)
            {
                Console.WriteLine($"\nTable number: {i + 1}");
                tables[i].Print();
            }
        }

        public void ListOfTablesByName(string? name)
        {
            if (name is not null)
            {
                bool isFound = false;
                for (int i = 0; i < tables.Length; i++)
                {
                    if (tables[i].name.ToUpper() == name.ToUpper())
                    {
                        Console.WriteLine($"Table number: {i + 1}");
                        isFound = true;
                        tables[i].Print();
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
            bool isFound = false;
            for (int i = 0; i < tables.Length; i++)
            {
                if (tables[i].cost <= cost)
                {
                    Console.WriteLine($"Table number: {i + 1}");
                    isFound = true;
                    tables[i].Print();
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"Tables with cost below {cost} were not found");
            }
        }
    }
}