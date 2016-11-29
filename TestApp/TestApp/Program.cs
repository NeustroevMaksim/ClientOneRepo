using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientFeature client = new ClientFeature();
            var feature = new BaseFeature();
            Console.WriteLine(feature.Name);
            Console.WriteLine(client.Description);
        }
    }
}
