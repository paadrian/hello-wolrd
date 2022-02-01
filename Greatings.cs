using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Greatings
    {
        private readonly Action<string> _outputProvider;

        public Greatings(Action<string> outputProvider)
        {
            _outputProvider = outputProvider;
        }

        public void SayHello()
        {
            _outputProvider("Hello, World!");
            _outputProvider("Bonjour le monde!");
            _outputProvider("Buna ziua lume!");
            _outputProvider("Hallo Welt!");
        }
    }
}
