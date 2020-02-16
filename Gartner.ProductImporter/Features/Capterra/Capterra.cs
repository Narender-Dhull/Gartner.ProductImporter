namespace Gartner.ProductImporter.Features.Softwareadvice
{
    public class Capterra
    {
        public string Tags { get; set; }
        public string Name { get; set; }
        public string Twitter { get; set; }


        public override string ToString()
        {
            return $"Name:{Name}; Categories:{Tags}; Twitter:{Twitter}";
        }
    }
}
