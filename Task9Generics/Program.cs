using System.ComponentModel.Design;
using Task9Generics;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            GenericArray<Human> humans = new(new Human[]
            {
                new Man("Oleksandr", "Datskevych"),
                new Woman(),
                new Man()
            });
            Console.WriteLine(humans.ToString());
            var defaultHumans = GenerateHumans<Woman>(8);
            Console.WriteLine(defaultHumans.ToString());
            foreach (var i in humans)
            {
                Console.WriteLine(i.ToString());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
        }
    }

    static GenericArray<Human> GenerateHumans<T>(int number) where T : Human, new()
    {
        GenericArray<Human> humans = new();
        
        for (var i = 0; i < number; i++)
        {
            humans.Add(new T());
        }

        return humans;
    }
}
