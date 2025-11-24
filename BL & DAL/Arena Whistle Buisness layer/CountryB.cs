using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Arena_Whistle_Data_Access_Layer;

namespace Arena_Whistle_Buisness_layer
{
    public class ClsCountry
    {
        public static HashSet<string> GetContriesTable()
        {
            return ClsCountryDA.GetContriesTable();
        }

        public static async Task<HashSet<string>> GetContriesTableAsync()
        {
            return await ClsCountryDA.GetContriesTableAsync();
        }
    }
}
