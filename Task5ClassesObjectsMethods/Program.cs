using FactoryNS;

namespace Task5ClassesObjectsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factoryOfTables = new Factory();

            int amountOfTables = factoryOfTables.GetAmountOfTables();
            Console.WriteLine($"Amount of tables in factory {amountOfTables}");

            Console.WriteLine("List of tables in factory:");
            factoryOfTables.ListOfTables();

            Console.WriteLine("\nEnter a number of table to assemble:");
            int tableNumber = Convert.ToInt32(Console.ReadLine());
            if ((tableNumber <= amountOfTables) & (tableNumber > 0))
            {
                factoryOfTables.tables[tableNumber - 1].Assemble();
            }
            else
            {
                Console.WriteLine($"There's no table with number {tableNumber}");
            }

            Console.WriteLine("\nEnter a name of table to get the list of tables by name");
            factoryOfTables.ListOfTablesByName(Console.ReadLine());

            Console.WriteLine("\nEnter your estimated budget");
            factoryOfTables.ListOfTablesByCost(Convert.ToSingle(Console.ReadLine()));
        }
    }
}
