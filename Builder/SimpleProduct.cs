using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class SimpleProduct : IProduct
    {
        public List<IPart> Parts { get; set; }
        public SimpleProduct()
        {
            Parts = new List<IPart>();
        }
        public void Add(IPart part)
        {
            this.Parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this.Parts.Count; i++)
            {
                str += this.Parts[i].Name + ", ";
            }

            str = str.Remove(str.Length - 2); 

            return "Product parts: " + str + "\n";
        }
    }
}
