using System;

namespace DataGridTest
{
    internal class TestModel
    {
        public string Name { get; private set; }
        public string Code { get; private set; }

        internal TestModel Gen(string v1, string v2)
        {
            Name = v1;
            Code = v2;
            return this;    
        }
    }
}