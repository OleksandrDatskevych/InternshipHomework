namespace Task7AbstractClassesInterfaces
{
    internal interface IAttack
    {
        private static uint totalAttacksMade = 0;
        public void AttackToRight(Animal animal);
        public void AttackToLeft(Animal animal);
        public void AttackForward(Animal animal);
        public void AttackBackward(Animal animal);

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
