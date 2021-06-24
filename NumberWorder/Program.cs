using Microsoft.Extensions.DependencyInjection;

namespace NumberWorder
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = Startup.ConfigureServices();
            services.GetService<EntryPoint>().Run(args);
        }
    }
}
