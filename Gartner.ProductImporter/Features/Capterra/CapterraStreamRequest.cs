using Gartner.ProductImporter.Common;
using Gartner.ProductImporter.Services;
using System;

namespace Gartner.ProductImporter.Features.Softwareadvice
{
    public class CapterraStreamRequest : IStreamRequest
    {
        private readonly ICapterraQuery _capterraQuery;
        private readonly string _filePath;
        public CapterraStreamRequest(ICapterraQuery capterraQuery)
        {
            _capterraQuery = capterraQuery;
            _filePath = FilePath.CapaterraFilePth;
        }

        public string Name => "Capterra";

        public void Execute()
        {
            var results = _capterraQuery.Execute(_filePath);
            foreach (var res in results)
            {
                Console.WriteLine(res.ToString());
            }
        }
    }
}
