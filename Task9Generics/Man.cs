namespace Task9Generics
{
    internal class Man : Human
    {
        public Man() : base()
        {
            FirstName = "Man's first name";
            LastName = "Man's last name";
        }

        public Man(string? firstName, string? lastName) : base(firstName, lastName)
        {

        }
        public override string ToString()
        {
            var info = $"First name: {FirstName}, Last name {LastName}, Sex: Man";

            return info;
        }
    }
}
