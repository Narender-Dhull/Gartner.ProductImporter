using Gartner.ProductImporter.Common;
using Gartner.ProductImporter.Services;
using System;

namespace Gartner.ProductImporter.Features.Capterra
{
    class SoftwareadviseStreamRequest : IStreamRequest
    {
        private readonly ISoftwareadviceQuery _softwareadviceQuery;
        private readonly string _filePath;
        public SoftwareadviseStreamRequest(ISoftwareadviceQuery softwareadviceQuery)
        {
            _softwareadviceQuery = softwareadviceQuery;
            _filePath = FilePath.SoftwareadviceFilePth;
        }

        public string Name => "Softwareadvice";

        public void Execute()
        {
            var results = _softwareadviceQuery.Execute(_filePath);
            Console.WriteLine(results.ToString());
        }
    }
}
