using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Arena_Whistle_Data_Access_Layer
{
    public class ClsUtilDA
    {


        public static void SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(int? ByUserID, SqlConnection connection)
        {
            using(SqlCommand session_contextCMD = new SqlCommand("sp_set_session_context", connection))
            {
                session_contextCMD.CommandType = CommandType.StoredProcedure;
                session_contextCMD.Parameters.AddWithValue("@key", "ByUserID");
                session_contextCMD.Parameters.AddWithValue("@value", ByUserID);


                session_contextCMD.ExecuteNonQuery();
            }
        }




    }

}
