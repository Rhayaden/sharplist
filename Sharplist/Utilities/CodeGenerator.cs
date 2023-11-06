using System;

namespace Sharplist
{
    public class CodeGenerator : ICodeGenerator
    {
        private readonly Random _random = new Random();
        private readonly int _min = 0000;
        private readonly int _max = 10000;
        public int Generate()
        {
            return _random.Next(_min, _max);
        }
    }
}