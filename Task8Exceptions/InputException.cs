namespace Task8Exceptions
{
    internal class InputException : Exception
    {
        public static int exceptionsThrew = 0;

        public InputException() : base("Wrong input exception.")
        {
            exceptionsThrew++;
        }
    }
}
