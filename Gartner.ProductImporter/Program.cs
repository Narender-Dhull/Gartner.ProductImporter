using Gartner.ProductImporter.Common;
using Gartner.ProductImporter.Features.Capterra;
using Gartner.ProductImporter.Features.Softwareadvice;
using Gartner.ProductImporter.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gartner.ProductImporter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter command:");
                string input = Console.ReadLine();
                string[] command = input.Split(' ');
                List<IStreamRequest> streamServices = GetStreamServices();
                // we are not using Import and Path parameter
                IStreamRequest streamService = streamServices.Where(x => x.Name.ToUpper() == command[1].ToUpper()).FirstOrDefault();
                streamService.Execute();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Invalid entry: Try input in import capterra feed-products/capterra.yaml format.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error:{ex.Message}");
            }
            Console.ReadKey();
        }
        private static List<IStreamRequest> GetStreamServices()
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddTransient<IStreamRequest, SoftwareadviseStreamRequest>()
                 .AddTransient<IStreamRequest, CapterraStreamRequest>()
                .AddSingleton<ISoftwareadviceQuery, SoftwareadviceQuery>()
                .AddSingleton<ICapterraQuery, CapterraQuery>()
                .AddSingleton<ISoftwareadviceQuery, SoftwareadviceQuery>()
                .AddSingleton<IDumpFile, DumpFile>()
                .BuildServiceProvider();

            //do the actual work here
            return serviceProvider.GetServices<IStreamRequest>().ToList();
        }
    }
}
