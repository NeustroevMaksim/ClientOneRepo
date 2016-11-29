using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    public class BaseFeature
    {
        public string Title { get; set; }
        public BaseFeature()
        {
            Title = "Changed for client";
        }
        public string ClientApp()
        {
            return "ClientApp";
        }

        public void FunFeature()
        {
            Console.WriteLine("Implemented in base");
        }

    }
}
