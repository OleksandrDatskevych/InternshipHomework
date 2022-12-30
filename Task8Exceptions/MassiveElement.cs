namespace Task8Exceptions
{
    internal class MassiveElement
    {
        public MassiveElement() { }
        public void ShowMassiveElement()
        {
            try
            {
                int[] massive = { 8, 7, 1, 4, 2, };
                Console.WriteLine("Input index of element in massive:");
                string? inputedValue = Console.ReadLine();
                string? checkedValue = inputedValue.Equals(string.Empty) ? null : inputedValue;
                int inputedNumber = Int32.Parse(checkedValue);
                int massiveElement = massive[inputedNumber];
                Console.WriteLine($"Massive element that has index {inputedValue} has value {massiveElement}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
