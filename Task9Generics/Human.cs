namespace Task9Generics
{
    internal abstract class Human
    {
        protected string? _firstName;
        protected string? _lastName;

        public string? FirstName { get; protected set; }
        public string? LastName { get; protected set; }

        protected Human()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
        }

        protected Human(string? firstName, string? lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public abstract override string ToString();
    }
}
