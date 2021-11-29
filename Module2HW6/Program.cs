using Microsoft.Extensions.DependencyInjection;
using Module2HW6.Services.Abstractions;
using Module2HW6.Services;
using Module2HW6.Abstractions;

namespace Module2HW6
{
    public partial class Program
    {
       public static void Main()
        {
            var service = new ServiceCollection()
                 .AddTransient<IElectricalAppliancesService, ElectricalAppliancesService>()
                 .AddTransient<IListElectrical, ListElectrical>()
                 .AddTransient<Starter>()
                 .BuildServiceProvider();

            var starter = service.GetService<Starter>();
            starter.Run();
        }
    }
}
