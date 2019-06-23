using Pattern01.Facade.External_Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern01.Facade
{
    public class Facade
    {
        public int GetTemp(string postalCode)
        {
            var oZoneFinder = new ZoneFinder();
            var zone = oZoneFinder.GetZone("5645646");

            var oTempratureService = new TempratureService();
            var temp = oTempratureService.GetTemp(zone);

            var oTempConvertor = new TempConvertor();
            var finalTemp = oTempConvertor.GetFarenheit(temp);

            return finalTemp;
        }

    }
}
