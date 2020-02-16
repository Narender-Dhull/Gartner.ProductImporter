namespace Gartner.ProductImporter.Common
{
    public interface IStreamRequest
    {
        public string Name { get; }
        public void Execute();
    }
}
