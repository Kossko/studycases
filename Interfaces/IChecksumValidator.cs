using System;
using System.Collections.Generic;
using System.Text;

namespace StudyCases.Interfaces
{
    public interface IChecksumValidator
    {
        bool IsValid(List<int> numbers);
    }
}
