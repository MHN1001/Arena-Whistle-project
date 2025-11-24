using System;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static Arena_Whistle_Data_Access_Layer.ClsStadiumDA;
using System.Collections.Generic;


namespace Arena_Whistle_Data_Access_Layer
{
    public static class ClsStadiumDA
    {
        public static bool FindStadium(int StadiumID, ref string StadiumName, ref string SportType, ref string FloorType,
                                      ref DateTime Year
                                       , ref float Length, ref float Width, ref bool Lighting, ref bool ConvertedHall
                                        , ref short Capacity, ref decimal RentalPricePerHour, ref bool Available, ref byte NumberOfImages)
        {
            bool IsFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_GetStadiumByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Input parameter
                        command.Parameters.AddWithValue("@StadiumID", StadiumID);

                        // Output parameters
                        command.Parameters.Add(new SqlParameter("@StadiumName", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Year", SqlDbType.Date) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@FloorType", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@SportType", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Length", SqlDbType.Float) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Width", SqlDbType.Float) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Lighting", SqlDbType.Bit) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@ConveredHall", SqlDbType.Bit) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Capacity", SqlDbType.Int) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@RentalPricePerHour", SqlDbType.SmallMoney) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Available", SqlDbType.Bit) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@NumberOfImages", SqlDbType.Int) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@IsFound", SqlDbType.Bit) { Direction = ParameterDirection.Output });




                        connection.Open();
                        command.ExecuteNonQuery();


                        if(IsFound = (bool)command.Parameters["@IsFound"].Value) // you can use Available or add your own IsFound flag
                        {
                            StadiumName = command.Parameters["@StadiumName"].Value.ToString();
                            Year = Convert.ToDateTime(command.Parameters["@Year"].Value);
                            FloorType = command.Parameters["@FloorType"].Value.ToString();
                            SportType = command.Parameters["@SportType"].Value.ToString();
                            Length = Convert.ToSingle(command.Parameters["@Length"].Value);
                            Width = Convert.ToSingle(command.Parameters["@Width"].Value);
                            Lighting = (bool)command.Parameters["@Lighting"].Value;
                            ConvertedHall = (bool)command.Parameters["@ConveredHall"].Value;
                            Capacity = Convert.ToInt16(command.Parameters["@Capacity"].Value);
                            RentalPricePerHour = Convert.ToDecimal(command.Parameters["@RentalPricePerHour"].Value);
                            Available = (bool)command.Parameters["@Available"].Value;
                            NumberOfImages = Convert.ToByte(command.Parameters["@NumberOfImages"].Value);
                        }
                    }
                }
            }
            catch(SqlException ex)
            {

            }


            return IsFound;
        }

        public static bool FindStadiumByStadiumName(string StadiumName, ref int StadiumID, ref string SportType, ref string FoorType,
                              ref DateTime Year
                               , ref float Length, ref float Width, ref bool Lighting, ref bool ConvertedHall
                                , ref short Capacity, ref decimal RentalPricePerHour, ref bool Available, ref byte NumberOfImages)
        {
            bool IsFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_GetStadiumByName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Input parameter
                        command.Parameters.AddWithValue("@StadiumName", StadiumName);

                        // Output parameters
                        command.Parameters.Add(new SqlParameter("@StadiumID", SqlDbType.Int) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Year", SqlDbType.Date) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@FloorType", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@SportType", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Length", SqlDbType.Float) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Width", SqlDbType.Float) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Lighting", SqlDbType.Bit) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@ConveredHall", SqlDbType.Bit) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Capacity", SqlDbType.Int) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@RentalPricePerHour", SqlDbType.SmallMoney) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Available", SqlDbType.Bit) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@NumberOfImages", SqlDbType.Int) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@IsFound", SqlDbType.Bit) { Direction = ParameterDirection.Output });




                        connection.Open();
                        command.ExecuteNonQuery();


                        if(IsFound = (bool)command.Parameters["@IsFound"].Value) // you can use Available or add your own IsFound flag
                        {
                            StadiumID = Convert.ToInt32(command.Parameters["@StadiumID"].Value);
                            Year = Convert.ToDateTime(command.Parameters["@Year"].Value);
                            FoorType = command.Parameters["@FloorType"].Value.ToString();
                            SportType = command.Parameters["@SportType"].Value.ToString();
                            Length = Convert.ToSingle(command.Parameters["@Length"].Value);
                            Width = Convert.ToSingle(command.Parameters["@Width"].Value);
                            Lighting = (bool)command.Parameters["@Lighting"].Value;
                            ConvertedHall = (bool)command.Parameters["@ConveredHall"].Value;
                            Capacity = Convert.ToInt16(command.Parameters["@Capacity"].Value);
                            RentalPricePerHour = Convert.ToDecimal(command.Parameters["@RentalPricePerHour"].Value);
                            Available = (bool)command.Parameters["@Available"].Value;
                            NumberOfImages = Convert.ToByte(command.Parameters["@NumberOfImages"].Value);

                        }
                    }
                }
            }
            catch(SqlException ex)
            {

            }


            return IsFound;
        }


        public static bool FindStadiumBySportTypeName(string SportTypeName, ref int StadiumID, ref string StadiumName, ref string FloorType,
                                      ref DateTime Year
                                       , ref float Length, ref float Width, ref bool Lighting, ref bool ConvertedHall
                                        , ref short Capacity, ref decimal RentalPricePerHour, ref bool Available, ref byte NumberOfImages)
        {
            bool IsFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_GetStadiumBySportTypeName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Input parameter
                        command.Parameters.AddWithValue("@SportType", SportTypeName);

                        // Output parameters
                        command.Parameters.Add(new SqlParameter("@StadiumID", SqlDbType.Int) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Year", SqlDbType.Date) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@FloorType", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Length", SqlDbType.Float) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Width", SqlDbType.Float) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Lighting", SqlDbType.Bit) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@ConveredHall", SqlDbType.Bit) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Capacity", SqlDbType.Int) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@RentalPricePerHour", SqlDbType.SmallMoney) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Available", SqlDbType.Bit) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@NumberOfImages", SqlDbType.Int) { Direction = ParameterDirection.Output });




                        connection.Open();
                        command.ExecuteNonQuery();


                        if(IsFound = (bool)command.Parameters["@IsFound"].Value) // you can use Available or add your own IsFound flag
                        {
                            StadiumID = Convert.ToInt32(command.Parameters["@StadiumID"].Value);
                            StadiumName = command.Parameters["@StadiumName"].Value.ToString();
                            Year = Convert.ToDateTime(command.Parameters["@Year"].Value);
                            FloorType = command.Parameters["@FloorType"].Value.ToString();
                            Length = Convert.ToSingle(command.Parameters["@Length"].Value);
                            Width = Convert.ToSingle(command.Parameters["@Width"].Value);
                            Lighting = (bool)command.Parameters["@Lighting"].Value;
                            ConvertedHall = (bool)command.Parameters["@ConveredHall"].Value;
                            Capacity = Convert.ToInt16(command.Parameters["@Capacity"].Value);
                            RentalPricePerHour = Convert.ToDecimal(command.Parameters["@RentalPricePerHour"].Value);
                            Available = (bool)command.Parameters["@Available"].Value;
                            NumberOfImages = Convert.ToByte(command.Parameters["@NumberOfImages"].Value);

                        }
                    }
                }
            }
            catch(SqlException ex)
            {

            }


            return IsFound;
        }

        public static int AddingStadium(string StadiumName,
                                        string SportType, string FloorType, DateTime Year
                                      , float Length, float Width, bool Lighting, bool ConvertedHall
                                       , short Capacity, decimal RentalPricePerHour, bool Available,

                                        int ByUserID)
        {
            int NewStadiumID = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_AddNewStadium", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;


                        command.Parameters.AddWithValue("@StadiumName", StadiumName);
                        command.Parameters.AddWithValue("@Year", Year);
                        command.Parameters.AddWithValue("@FloorTypeName", FloorType);
                        command.Parameters.AddWithValue("@SportTypeName", SportType);
                        command.Parameters.AddWithValue("@Length", Length);
                        command.Parameters.AddWithValue("@Width", Width);
                        command.Parameters.AddWithValue("@Lighting", Lighting);
                        command.Parameters.AddWithValue("@ConveredHall", ConvertedHall);
                        command.Parameters.AddWithValue("@Capacity", Capacity);
                        command.Parameters.AddWithValue("@RentalPricePerHour", RentalPricePerHour);
                        command.Parameters.AddWithValue("@Available", Available);

                        command.Parameters.Add(new SqlParameter("@NewStadiumID", SqlDbType.Int) { Direction = ParameterDirection.Output });

                        connection.Open();


                        ClsUtilDA.SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(ByUserID, connection);

                        command.ExecuteNonQuery();

                        NewStadiumID = Convert.ToInt32(command.Parameters["@NewStadiumID"].Value);
                    }
                }
            }
            catch(SqlException ex)
            {

            }

            return NewStadiumID;
        }




        private static DataTable GetDataTableForTableVariableParameter_SP(List<string> imagePaths)
        {
            DataTable tvp = new DataTable();

            tvp.Columns.Add("StadiumImagePath", typeof(string));

            foreach(var path in imagePaths)
            {
                tvp.Rows.Add(path);
            }

            return tvp;
        }
        public static int AddNewStadiumWithImages(
                                                   string stadiumName,
                                                   DateTime year,
                                                   string floorType,
                                                   string sportType,
                                                   float length,
                                                   float width,
                                                   bool lighting,
                                                   bool coveredHall,
                                                   int capacity,
                                                   decimal rentalPrice,
                                                   bool available,
                                                   List<string> imagePaths,
                                                   int ByUserID)
        {
            int newStadiumID = 0;

            // 1. Prepare a DataTable for the TVP
            DataTable tvp = GetDataTableForTableVariableParameter_SP(imagePaths);

            using(SqlConnection conn = new SqlConnection(ClsSettingDA.ConnectionString))
            using(SqlCommand cmd = new SqlCommand("dbo.SP_AddNewStadiumWithImages", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@SI_StadiumName", stadiumName);
                cmd.Parameters.AddWithValue("@SI_Year", year);
                cmd.Parameters.AddWithValue("@SI_FloorTypeName", floorType);
                cmd.Parameters.AddWithValue("@SI_SportTypeName", sportType);
                cmd.Parameters.AddWithValue("@SI_Length", length);
                cmd.Parameters.AddWithValue("@SI_Width", width);
                cmd.Parameters.AddWithValue("@SI_Lighting", lighting);
                cmd.Parameters.AddWithValue("@SI_ConveredHall", coveredHall);
                cmd.Parameters.AddWithValue("@SI_Capacity", capacity);
                cmd.Parameters.AddWithValue("@SI_RentalPricePerHour", rentalPrice);
                cmd.Parameters.AddWithValue("@SI_Available", available);

                //Add TVP parameter
                var imagesParam = cmd.Parameters.AddWithValue("@Images", tvp);

                imagesParam.SqlDbType = SqlDbType.Structured;
                imagesParam.TypeName = "dbo.StadiumImageTableType"; // must match your UDTT name

                cmd.Parameters.Add(new SqlParameter("@SI_NewStadiumID", SqlDbType.Int) { Direction = ParameterDirection.Output });


                conn.Open();

                ClsUtilDA.SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(ByUserID, conn);

                cmd.ExecuteNonQuery();

                newStadiumID = Convert.ToInt32(cmd.Parameters["@SI_NewStadiumID"].Value); ;
            }

            return newStadiumID;
        }


        public static bool UpdateStadiumInfo(int StadiumID, string StadiumName,
                                        string SportType, string FloorType, DateTime Year
                                      , float Length, float Width, bool Lighting, bool ConvertedHall
                                       , short Capacity, decimal RentalPricePerHour, bool Available,

                                        int ByUserID)
        {
            int EffectedRows = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_UpdateStadium", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;



                        command.Parameters.AddWithValue("@StadiumID", StadiumID);
                        command.Parameters.AddWithValue("@StadiumName", StadiumName);
                        command.Parameters.AddWithValue("@Year", Year);
                        command.Parameters.AddWithValue("@FloorTypeName", FloorType);
                        command.Parameters.AddWithValue("@SportTypeName", SportType);
                        command.Parameters.AddWithValue("@Length", Length);
                        command.Parameters.AddWithValue("@Width", Width);
                        command.Parameters.AddWithValue("@Lighting", Lighting);
                        command.Parameters.AddWithValue("@ConveredHall", ConvertedHall);
                        command.Parameters.AddWithValue("@Capacity", Capacity);
                        command.Parameters.AddWithValue("@RentalPricePerHour", RentalPricePerHour);
                        command.Parameters.AddWithValue("@Available", Available);


                        connection.Open();


                        ClsUtilDA.SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(ByUserID, connection);

                        EffectedRows = command.ExecuteNonQuery();

                    }
                }
            }
            catch(SqlException ex)
            {

            }

            return EffectedRows > 0;
        }



        public static bool UpdateStadiumWithImages(
            int stadiumID,
            string stadiumName,
            DateTime year,
            string floorTypeName,
            string sportTypeName,
            double length,
            double width,
            bool lighting,
            bool coveredHall,
            int capacity,
            decimal rentalPricePerHour,
            bool available,
            List<string> UpdatedimagePaths,
            int ByUserID)
        {

            try
            {
                DataTable imagesTable = GetDataTableForTableVariableParameter_SP(UpdatedimagePaths);

                using(SqlConnection conn = new SqlConnection(ClsSettingDA.ConnectionString))

                using(SqlCommand cmd = new SqlCommand("SP_UpdateStadiumWithImages", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@SI_StadiumID", stadiumID);
                    cmd.Parameters.AddWithValue("@SI_StadiumName", stadiumName);
                    cmd.Parameters.AddWithValue("@SI_Year", year);
                    cmd.Parameters.AddWithValue("@SI_FloorTypeName", floorTypeName);
                    cmd.Parameters.AddWithValue("@SI_SportTypeName", sportTypeName);
                    cmd.Parameters.AddWithValue("@SI_Length", length);
                    cmd.Parameters.AddWithValue("@SI_Width", width);
                    cmd.Parameters.AddWithValue("@SI_Lighting", lighting);
                    cmd.Parameters.AddWithValue("@SI_ConveredHall", coveredHall);
                    cmd.Parameters.AddWithValue("@SI_Capacity", capacity);
                    cmd.Parameters.AddWithValue("@SI_RentalPricePerHour", rentalPricePerHour);
                    cmd.Parameters.AddWithValue("@SI_Available", available);

                    //table-Valued Parameter for images
                    SqlParameter imagesParam = cmd.Parameters.AddWithValue("@Images", imagesTable);
                    imagesParam.SqlDbType = SqlDbType.Structured;
                    imagesParam.TypeName = "dbo.StadiumImageTableType"; // the UDTT(user defined table type) name

                    conn.Open();

                    ClsUtilDA.SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(ByUserID, conn);


                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
            catch(SqlException ex)
            {
                //Console.WriteLine(": " + ex.Message);
            }
            catch(Exception ex)
            {
                //Console.WriteLine(": " + ex.Message);
            }


            return false;
        }
























        public static bool DeleteStadium(int stadiumID, int ByUserID)
        {
            byte EffectedRows = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_DeleteStadium", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;


                        command.Parameters.AddWithValue("@StadiumID", stadiumID);


                        connection.Open();


                        ClsUtilDA.SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(ByUserID, connection);

                        EffectedRows = Convert.ToByte(command.ExecuteNonQuery());

                    }
                }
            }
            catch(SqlException ex)
            {

            }

            return ( EffectedRows > 0 );
        }







        public static (DataView Stadiums, DataView StadiumsImages) GetAllStadiums()
        {
            DataTable Stadiums = new DataTable();
            DataTable StadiumsImages = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand Cmd1 = new SqlCommand("SP_GetAllStadiumsTable", connection))
                    {
                        Cmd1.CommandType = CommandType.StoredProcedure;

                        connection.Open();

                        using(SqlDataReader dataReader = Cmd1.ExecuteReader())
                        {
                            if(dataReader.HasRows)
                                Stadiums.Load(dataReader); // Loads the first table
                        }


                        using(SqlCommand Cmd2 = new SqlCommand("SP_GetAllStadiumsImagesTable", connection))
                        {

                            using(SqlDataReader dataReader = Cmd2.ExecuteReader())
                            {
                                if(dataReader.HasRows)
                                    StadiumsImages.Load(dataReader); // Loads the second table

                            }
                        }
                    }
                }
            }
            catch(SqlException ex)
            {
                //
                //
                //

            }

            return (Stadiums.DefaultView, StadiumsImages.DefaultView);
        }
        public static (DataView Stadiums, DataView StadiumsImages) GetAvailableStadiums()
        {
            DataTable Stadiums = new DataTable();
            DataTable StadiumsImages = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand Cmd1 = new SqlCommand("SP_GetAvailableStadiumsTable", connection))
                    {
                        Cmd1.CommandType = CommandType.StoredProcedure;

                        connection.Open();

                        using(SqlDataReader dataReader = Cmd1.ExecuteReader())
                        {
                            if(dataReader.HasRows)
                                Stadiums.Load(dataReader); // Loads the first table
                        }


                        using(SqlCommand Cmd2 = new SqlCommand("SP_GetAvailableStadiumsImagesTable", connection))
                        {

                            using(SqlDataReader dataReader = Cmd2.ExecuteReader())
                            {
                                if(dataReader.HasRows)
                                    StadiumsImages.Load(dataReader); // Loads the second table

                            }
                        }
                    }
                }
            }
            catch(SqlException ex)
            {
                //
                //
                //

            }

            return (Stadiums.DefaultView, StadiumsImages.DefaultView);
        }




        public static bool IsStadiumExist(int stadiumID)
        {
            bool ISFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_CheckStadiumExistenceByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@StadiumID", stadiumID);


                        connection.Open();
                        ISFound = Convert.ToBoolean(command.ExecuteScalar());

                    }
                }
            }
            catch(SqlException ex)
            {

            }


            return ISFound;
        }
        public static byte CountAvailableStadium()
        {
            byte NumberOFAvailableStadiums = 0;


            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_GetNumberOfAvailableStadiums", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();

                        NumberOFAvailableStadiums = Convert.ToByte(command.ExecuteScalar());
                    }
                }
            }
            catch(SqlException ex)
            {

            }

            return NumberOFAvailableStadiums;
        }
        public static bool IsStadiumAvailable(int stadiumID)
        {
            bool Available = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_CheckStadiumAvailabilityByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@StadiumID", stadiumID);


                        connection.Open();
                        Available = Convert.ToBoolean(command.ExecuteScalar());

                    }
                }
            }
            catch(SqlException ex)
            {

            }


            return Available;
        }

    }
}
