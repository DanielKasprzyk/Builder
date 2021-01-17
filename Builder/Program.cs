using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleHouseDirector simpleHouseDirector = new SimpleHouseDirector();

            Console.WriteLine("Simple House:");
            simpleHouseDirector.BuildSimpleHouse();
            Console.Write(simpleHouseDirector.Builder.Product.ListParts());

            simpleHouseDirector.Builder.Reset();

            Console.WriteLine("Fancy House:");
            simpleHouseDirector.BuildFancyHouse();
            Console.Write(simpleHouseDirector.Builder.Product.ListParts());

            simpleHouseDirector.Builder.Reset();

            var builder = new SimpleHouseBuilder();
            Console.WriteLine("Simple House:");
            builder.BuildFloor();
            builder.BuildWall();
            builder.BuildWall();
            builder.BuildWall();
            builder.BuildWall();
            builder.BuildDoor();
            builder.BuildWindow();
            builder.BuildWindow();
            builder.BuildRoof();
            Console.Write(builder.Product.ListParts());

            //Wzorzec projektowy builder sprawdza się przy tworzeniu obiektów z dużą ilościa konfigurowalnych opcji

            //Przy powyższym przykładzie możemy stworyć dom który będzie miał 4 lub 20 ścian, okien itd

            //Można używać go z lub bez klasy director
        }
    }
}
