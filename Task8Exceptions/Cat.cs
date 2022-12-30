﻿namespace Task8Exceptions
{
    internal class Cat
    {
        private string? _name;
        private string? _color;
        private byte _age;

        public string? Name { get => _name; private set => _name = value; }
        public string? Color { get => _color; private set => _color = value; }
        public byte Age { get => _age; private set => _age = value; }

        public Cat()
        {
            Name = "Nėra";
            Color = "Black";
            Age = 8;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Color: {Color}, Age: {Age}");
        }

        public void ChangeInfo()
        {
            try
            {
                Console.WriteLine("Enter new name: ");
                var name = Console.ReadLine();
                Console.WriteLine("Enter new color: ");
                var color = Console.ReadLine();
                Console.WriteLine("Enter new age: ");
                var age = byte.Parse(Console.ReadLine());

                if (name is null || name == string.Empty || color is null || color == string.Empty || age == 0 || age > 20)
                {
                    throw new InputException();
                }

                Name = name;
                Color = color;
                Age = age;
            }

            catch (InputException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine($"Total number of input exceptions threw: {InputException.exceptionsThrew}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
