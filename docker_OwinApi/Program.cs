using Microsoft.Owin.Hosting;
using System;
using System.Net.Http;
using System.Threading;

namespace docker_OwinApi
{
    public class Program
    {
        static void Main()
        {
            string baseAddress = "http://localhost:9000/";
            WebApp.Start<Startup>(url: baseAddress);
            Console.Write("OWIN RESTful API is running");
            while (true)
            {
                //keep the web API up and running
                Thread.Sleep(1000);
                Console.Write(".");
            }

            Console.ReadLine();
        }
    }
}