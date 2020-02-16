using Gartner.ProductImporter.Common;
using Gartner.ProductImporter.Features.Capterra;
using Newtonsoft.Json;

namespace Gartner.ProductImporter.Services
{
    public interface ISoftwareadviceQuery
    {
        public Softwareadvice Execute(string path);
    }
    public class SoftwareadviceQuery : ISoftwareadviceQuery
    {
        private readonly IDumpFile _dumpFile;
        public SoftwareadviceQuery(IDumpFile dumpFile)
        {
            _dumpFile = dumpFile;
        }
        public Softwareadvice Execute(string path)
        {
            return JsonConvert.DeserializeObject<Softwareadvice>(_dumpFile.Read(path));
        }
    }
}
