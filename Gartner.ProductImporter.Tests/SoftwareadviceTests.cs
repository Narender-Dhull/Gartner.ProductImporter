using Gartner.ProductImporter.Common;
using Gartner.ProductImporter.Services;
using System.IO;
using Xunit;

namespace Gartner.ProductImporter.Tests
{
    public class SoftwareadviceTests
    {
        private readonly ISoftwareadviceQuery _softwareadviceQuery;
        private readonly IDumpFile _dumpFile;
        private readonly string _filePath;
        public SoftwareadviceTests()
        {
            //_dumpFile = A.Fake<IDumpFile>();
            _dumpFile = new DumpFile();
            _softwareadviceQuery = new SoftwareadviceQuery(_dumpFile);
            _filePath = FilePath.SoftwareadviceFilePth;
        }
        [Fact]
        public void Softwareadvice_File_Exists()
        {
            Assert.True(File.Exists(_filePath));
        }
        [Fact]
        public void Softwareadvice_File_Have_Data()
        {
            var result = _softwareadviceQuery.Execute(_filePath);
            Assert.True(result != null);
        }
    }
}
