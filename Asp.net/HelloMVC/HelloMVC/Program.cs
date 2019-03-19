using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace HelloMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //in Visual Studio...
            // we have "IIS Express" web server
            //      web servers are software taht listen on ports for data
            //      sent over internet, especially https
            //  out applications runs inside/alongside that web server
            //  technically we have another web server that is a container
            //  directly for this application, called Kestral.
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
