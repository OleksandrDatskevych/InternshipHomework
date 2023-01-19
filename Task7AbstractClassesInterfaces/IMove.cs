namespace Task7AbstractClassesInterfaces
{
    internal interface IMove
    {
        public void MoveForward();

        public void MoveForward(uint steps);

        public void MoveTo(int x, int y);
    }
}
