using StudyCases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudyCases.Services
{
    public class ChecksumValidator: IChecksumValidator
    {
        public bool IsValid(List<int> numbers)
        {
            var clone = numbers.ToList();

            clone.Reverse();

            var sum = clone.Select((value, index) => index == 0 ? value : index + 2).Sum();

            return sum % 11 == 0;
        }
    }
}
