using System.IO;

namespace Gartner.ProductImporter.Common
{
    public interface IDumpFile
    {
        public string Read(string path);
    }
    public class DumpFile : IDumpFile
    {
        public string Read(string path)
        {
            using var r = new StreamReader(path);
            return r.ReadToEnd();
        }
    }
}
