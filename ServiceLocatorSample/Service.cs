using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLocatorSample
{
    interface IService
    {
        string Greeting();
    }
    class TokyoService : IService
    {
        public string Greeting()
        {
            return "こんにちわ";
        }
    }

    class OsakaService : IService
    {
        public string Greeting()
        {
            return "もうかりまっか";
        }
    }
}
