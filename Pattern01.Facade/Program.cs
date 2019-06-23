using Pattern01.Facade.External_Services;
using System;

namespace Pattern01.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metho 1
            //var oZoneFinder = new ZoneFinder();
            //var zone = oZoneFinder.GetZone("5645646");

            //var oTempratureService = new TempratureService();
            //var temp = oTempratureService.GetTemp(zone);

            //var oTempConvertor = new TempConvertor();
            //var finalTemp = oTempConvertor.GetFarenheit(temp);

            //Method 2
            var oFacade = new Facade();
            var finalTemp = oFacade.GetTemp("5645646");

            Console.WriteLine($"{finalTemp}");

            Console.ReadLine();
        }
    }
}
