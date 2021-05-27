using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCases.Interfaces
{
    public interface IDigitParser
    {
        List<int> GetResults(List<string> lines);
    }
}
