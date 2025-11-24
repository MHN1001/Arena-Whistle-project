using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arena_Whistle_Data_Access_Layer;

namespace Arena_Whistle_Buisness_layer
{
    public static class ClsUserLoginHistoryB
    {
        public static DataView GetUsersLoginHistoryDataView()
        {
            return ClsUserLoginHistoryDA.GetUsersLoginHistoryDataView();
        }
    }
}
