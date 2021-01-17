using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class SimpleHouseDirector
    {
        public SimpleHouseBuilder Builder { get; set; }

        public SimpleHouseDirector()
        {
            Builder = new SimpleHouseBuilder();
        }
        public void BuildSimpleHouse()
        {
            Builder.BuildFloor();
            Builder.BuildWall();
            Builder.BuildWall();
            Builder.BuildWall();
            Builder.BuildWall();
            Builder.BuildDoor();
            Builder.BuildWindow();
            Builder.BuildWindow();
            Builder.BuildRoof();
        }

        public void BuildFancyHouse()
        {
            Builder.BuildFloor();
            Builder.BuildWall();
            Builder.BuildWall();
            Builder.BuildWall();
            Builder.BuildWall();
            Builder.BuildDoor();
            Builder.BuildWindow();
            Builder.BuildWindow();
            Builder.BuildFloor();
            Builder.BuildWall();
            Builder.BuildWall();
            Builder.BuildWall();
            Builder.BuildWall();
            Builder.BuildWall();
            Builder.BuildWall();
            Builder.BuildDoor();
            Builder.BuildWindow();
            Builder.BuildWindow();
            Builder.BuildRoof();
        }
    }
}
