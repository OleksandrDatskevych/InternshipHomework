namespace Task9Generics
{
    internal class Woman : Human
    {
        public Woman() : base()
        {
            FirstName = "Woman's first name";
            LastName = "Woman's last name";
        }

        public Woman(string? firstName, string? lastName) : base(firstName, lastName)
        {

        }

        public override string ToString()
        {
            var info = $"First name: {FirstName}, Last name {LastName}, Sex: Woman";

            return info;
        }
    }
}
