using System;
using System.Net.Http;
using System.IO;
using System.Threading.Tasks;
using StudyCases.Models;
using StudyCases.Interfaces;
using System.Collections.Generic;

namespace StudyCases
{
    public class ParserService : IParserService
    {
        private readonly IDigitParser _digitParser;
        private readonly IChecksumValidator _checksumValidator;

        public ParserService(IDigitParser digitParser
            , IChecksumValidator checksumValidator)
        {
            _digitParser = digitParser;
            _checksumValidator = checksumValidator;
        }

        public string Run(List<string> lines)
        {
            var result = _digitParser.GetResults(lines);

            var isValid = _checksumValidator.IsValid(result);

            return $"=> {string.Join(' ',result)}  {(isValid ? "Valid" : "Invalid")}";
        }
    }
}
