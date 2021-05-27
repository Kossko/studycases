using Microsoft.Extensions.DependencyInjection;
using StudyCases;
using StudyCases.Interfaces;
using StudyCases.Services;
using System;
using System.Collections.Generic;

namespace StudyCasesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                //.AddLogging()
                .AddTransient<IChecksumValidator, ChecksumValidator>()
                .AddTransient<IDigitParser, DigitParser>()
                .AddTransient<IParserService, ParserService>()
                .BuildServiceProvider();

            var _parserService = serviceProvider
                .GetService<IParserService>();


            Console.WriteLine("Please provide input or press 'Enter' to quit");

            var showMustGoOn = true;

            //Console.ReadLine();
            //var Console.ReadLine();
            while (showMustGoOn)
            {
                var linesToProcess = new List<string>();
                for (int i = 0; i < 3; i++)
                {
                    var input = Console.ReadLine();
                    if(input== null || input.Length< 0)
                    {
                        showMustGoOn = false;
                        break;
                    } else
                    {
                        linesToProcess.Add(input);
                    }
                }

                var result = _parserService.Run(linesToProcess);

                Console.WriteLine(result);
            }
        }
    }
}
