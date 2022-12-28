namespace Task7AbstractClassesInterfaces
{
    internal interface IAttack
    {
        private static uint totalAttacksMade = 0;
        protected void AttackToRight(Animal animal);
        protected void AttackToLeft(Animal animal);
        protected void AttackForward(Animal animal);
        protected void AttackBackward(Animal animal);

        protected static void AddAttack()
        {
            totalAttacksMade++;
        }

        public static void PrintAttackCounter()
        {
            Console.WriteLine($"Total attacks made: {totalAttacksMade}");
        }
    }
}
