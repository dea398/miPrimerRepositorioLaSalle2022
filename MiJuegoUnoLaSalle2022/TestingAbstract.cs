using System;
using System.Collections.Generic;
using System.Text;

namespace MiJuegoUnoLaSalle2022
{
    abstract class TestingAbstract
    {
        public abstract int TestMethod();

        public string CommonMethod()
        {
            return "Hello World";
        }
    }
}
