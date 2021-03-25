using Microsoft.Edge.SeleniumTools;
using OpenQA.Selenium;
using System;
using System.IO;
using System.Reflection;

namespace SeleniumEdgeCore
{
    class Program
    {
        static void Main(string[] args)

        {

            var options = new EdgeOptions();
            options.UseChromium = true;

            IWebDriver edge = new EdgeDriver(
               Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options);

            edge.Manage().Window.Maximize();
            edge.Navigate().GoToUrl("https://www.google.com/");
            edge.Quit();

        }
    }
}
