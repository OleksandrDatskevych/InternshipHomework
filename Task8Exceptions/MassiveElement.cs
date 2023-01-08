namespace Task8Exceptions
{
    internal class MassiveElement
    {
        public static int[] massive = { 8, 7, 1, 4, 2 };

        public MassiveElement()
        {

        }

        public static void ShowMassiveElement()
        {
            try
            {
                Console.WriteLine("Input index of element in massive:");
                var inputtedValue = Console.ReadLine();
                var checkedValue = inputtedValue.Equals(string.Empty) ? null : inputtedValue;
                var inputtedNumber = int.Parse(checkedValue);
                var massiveElement = massive[inputtedNumber];
                Console.WriteLine($"Massive element that has index {inputtedValue} has value {massiveElement}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
