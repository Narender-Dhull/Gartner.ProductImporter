using Gartner.ProductImporter.Common;
using Gartner.ProductImporter.Services;
using System.IO;
using Xunit;

namespace Gartner.ProductImporter.Tests
{
    public class CapterraTest
    {
        private readonly ICapterraQuery _capterraQuery;
        private readonly IDumpFile _dumpFile;
        private readonly string _filePath;
        public CapterraTest()
        {
            //_dumpFile = A.Fake<IDumpFile>();
            _dumpFile = new DumpFile();
            _capterraQuery = new CapterraQuery(_dumpFile);
            _filePath = FilePath.CapaterraFilePth;
        }
        [Fact]
        public void Capterra_File_Exists()
        {
            Assert.True(File.Exists(_filePath));
        }
        [Fact]
        public void Capterra_File_Have_Data()
        {
            var result = _capterraQuery.Execute(_filePath);
            Assert.True(result != null && result.Count > 0);
        }
    }
}
