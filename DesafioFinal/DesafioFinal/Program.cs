using Microsoft.AspNetCore.Hosting;
using System;

namespace DesafioFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebHost host = new WebHostBuilder()
               .UseKestrel()
               .UseStartup<Startup>()
               .Build();
            host.Run();
        }
    }
}
