using ChairNS;
using FactoryNS;
using FurnitureNS;
using TableNS;

namespace Task6OOPPriciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory factoryOfFurniture = new(false);
            // factoryOfFurniture.FillFactory();
            factoryOfFurniture.ShowAmountOfFurniture();
            factoryOfFurniture.ListOfFurniture();
            factoryOfFurniture.AddFurniture();
            factoryOfFurniture.AssembleTable();
            factoryOfFurniture.ListOfFurnitureByName();
            factoryOfFurniture.ListOfFurnitureByCost();
        }
    }
}
