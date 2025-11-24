using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Arena_Whistle_Data_Access_Layer
{
    public class VAlidationDA
    {
        public static T checkOutputParameterIfNull<T>(SqlParameter commandParam)
        {
            if(commandParam.Value == DBNull.Value)
            {
                return default(T);
            }
            return (T)commandParam.Value;
        } 

     }
}
