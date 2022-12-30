namespace Task9Generics
{
    internal abstract class Human
    {
        protected string? _firstName;
        protected string? _lastName;

        public string? FirstName { get => _firstName; protected set => _firstName = value; }
        public string? LastName { get => _lastName; protected set => _lastName = value; }

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
