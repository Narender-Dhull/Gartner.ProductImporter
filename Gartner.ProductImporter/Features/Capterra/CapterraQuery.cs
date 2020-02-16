using Gartner.ProductImporter.Common;
using Gartner.ProductImporter.Features.Softwareadvice;
using System.Collections.Generic;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Gartner.ProductImporter.Services
{
    public interface ICapterraQuery
    {
        public List<Capterra> Execute(string path);
    }
    public class CapterraQuery : ICapterraQuery
    {
        private readonly IDumpFile _dumpFile;
        public CapterraQuery(IDumpFile dumpFile)
        {
            _dumpFile = dumpFile;
        }
        public List<Capterra> Execute(string path)
        {
            var deserializer = new DeserializerBuilder()
  .WithNamingConvention(CamelCaseNamingConvention.Instance)
  .Build();
            return deserializer.Deserialize<List<Capterra>>(_dumpFile.Read(path));
        }
    }
}
