using ChairNS;
using FactoryNS;
using FurnitureNS;
using TableNS;

namespace Task6OOPPriciples
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factoryOfFurniture = new(true);
            // factoryOfFurniture.FillFactory();
            factoryOfFurniture.ShowAmountOfFurniture();
            factoryOfFurniture.ListOfFurniture();
            factoryOfFurniture.AssembleTable();
            factoryOfFurniture.ListOfFurnitureByName();
            factoryOfFurniture.ListOfFurnitureByCost();
        }
    }
}
