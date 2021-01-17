using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class SimpleHouseBuilder : IHouseBuilder
    {
        public IProduct Product { get; set; }

        public SimpleHouseBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.Product = new SimpleProduct();
        }

        public void BuildFloor()
        {
            Product.Add(new SimplePart { Name = "Floor" });
        }

        public void BuildWall()
        {
            Product.Add(new SimplePart { Name = "Wall" });
        }

        public void BuildWindow()
        {
            Product.Add(new SimplePart { Name = "Window" });
        }

        public void BuildDoor()
        {
            Product.Add(new SimplePart { Name = "Door" });
        }

        public void BuildRoof()
        {
            Product.Add(new SimplePart { Name = "Roof" });
        }
    }
}
