using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface IProduct
    {
        public List<IPart> Parts { get; set; }

        public void Add(IPart part);

        public string ListParts();
    }
}
