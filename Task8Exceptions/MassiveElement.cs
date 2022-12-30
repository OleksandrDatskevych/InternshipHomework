namespace Task8Exceptions
{
    internal class MassiveElement
    {

        public MassiveElement()
        {

        }

        public static void ShowMassiveElement()
        {
            try
            {
                int[] massive = { 8, 7, 1, 4, 2 };
                Console.WriteLine("Input index of element in massive:");
                string? inputtedValue = Console.ReadLine();
                string? checkedValue = inputtedValue.Equals(string.Empty) ? null : inputtedValue;
                int inputtedNumber = Int32.Parse(checkedValue);
                int massiveElement = massive[inputtedNumber];
                Console.WriteLine($"Massive element that has index {inputtedValue} has value {massiveElement}");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
