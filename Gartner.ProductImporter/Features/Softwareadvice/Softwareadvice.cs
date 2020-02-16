using System.Collections.Generic;

namespace Gartner.ProductImporter.Features.Capterra
{
    public class Product
    {
        public List<string> Categories { get; set; }
        public string Twitter { get; set; }
        public string Title { get; set; }
        public override string ToString()
        {
            return $"Categories:{Categories.ToString()},Twitter:{Twitter},Title:{Title}";
        }
    }

    public class Softwareadvice
    {
        public List<Product> Products { get; set; }
    }

}
