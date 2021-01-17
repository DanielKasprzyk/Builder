using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface IHouseBuilder
    {
        public void BuildFloor();
        public void BuildWall();
        public void BuildWindow();
        public void BuildDoor();
        public void BuildRoof();
        public void Reset();
    }
}
