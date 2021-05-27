using StudyCases.Models;
using System.Collections.Generic;

namespace StudyCases
{
    public interface IParserService
    {
        string Run(List<string> lines);
    }
}