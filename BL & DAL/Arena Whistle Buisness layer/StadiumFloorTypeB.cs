using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arena_Whistle_Data_Access_Layer;

namespace Arena_Whistle_Buisness_layer
{
    public static class ClsStadiumFloorTypeB
    {
        public static HashSet<string> GetAvailableStadiumFloors()
        {
            return ClsStadiumFloorTypeDA.GetAvailableStadiumFloors();
        }
    }
}
