using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Arena_Whistle_Data_Access_Layer;


namespace Arena_Whistle_Buisness_layer
{
    public class ClsStadium : ClsStadiumImage
    {

        public int StadiumID { get; set; }
        public string StadiumName { get; set; }
        public string SportType { get; set; }
        public string FloorType { get; set; }
        public DateTime Year { get; set; }
        public float Length { get; set; }
        public float Width { get; set; }
        public bool Lighting { get; set; }
        public bool ConvertedHall { get; set; }
        public short Capacity { get; set; }
        public decimal RentalPricePerHour { get; set; }
        public bool Available { get; set; }
        public List<string> StadiumImages { get; set; }

        public enum enMode { Add, Update }
        public enMode Mode;


        //Constractors
        public ClsStadium()
        {
            this.StadiumID = 0;
            this.StadiumName = "";
            this.SportType = "";
            this.Year = new DateTime();
            this.FloorType = "";
            this.Length = 0;
            this.Width = 0;
            this.Lighting = false;
            this.ConvertedHall = false;
            this.Capacity = 0;
            this.RentalPricePerHour = 0;
            this.Available = false;
            this.StadiumImages = null;

            Mode = enMode.Add;
        }
        private ClsStadium(_StadiumInfos stadium)
        {

            this.StadiumID = stadium.StadiumID;
            this.StadiumName = stadium.StadiumName;
            this.SportType = stadium.SportType;
            this.FloorType = stadium.FoorType;
            this.Year = stadium.Year;
            this.Length = stadium.Length;
            this.Width = stadium.Width;
            this.Lighting = stadium.Lighting;
            this.ConvertedHall = stadium.ConvertedHall;
            this.Capacity = stadium.Capacity;
            this.RentalPricePerHour = stadium.RentalPricePerHour;
            this.Available = stadium.Available;
            this.StadiumImages = stadium.StadiumImages;

            Mode = enMode.Update;

        }

        private struct _StadiumInfos
        {
            public int StadiumID;
            public string StadiumName;
            public string SportType;
            public string FoorType;
            public DateTime Year;
            public float Length;
            public float Width;
            public bool Lighting;
            public bool ConvertedHall;
            public short Capacity;
            public decimal RentalPricePerHour;
            public bool Available;
            public List<string> StadiumImages;

        }


        public static ClsStadium FindStadium(int StadiumID)
        {
            _StadiumInfos stadiumstruct = new _StadiumInfos();
            stadiumstruct.StadiumID = StadiumID;

            byte NumberOfImages = 0;

            if(ClsStadiumDA.FindStadium(stadiumstruct.StadiumID, ref stadiumstruct.StadiumName
                                        , ref stadiumstruct.SportType, ref stadiumstruct.FoorType,
                                         ref stadiumstruct.Year, ref stadiumstruct.Length,
                                          ref stadiumstruct.Width, ref stadiumstruct.Lighting
                                         , ref stadiumstruct.ConvertedHall, ref stadiumstruct.Capacity,
                                            ref stadiumstruct.RentalPricePerHour, ref stadiumstruct.Available, ref NumberOfImages))
            {
                if(NumberOfImages > 0)
                    stadiumstruct.StadiumImages = ClsStadiumImage.GetAllStadiumImages(stadiumstruct.StadiumID);


                return new ClsStadium(stadiumstruct);
            }
            else
                return null;
        }
        public static ClsStadium FindStadiumByStadiumName(string stadiumName)
        {
            _StadiumInfos stadium = new _StadiumInfos();

            byte NumberOfImages = 0;

            if(ClsStadiumDA.FindStadiumByStadiumName(stadiumName, ref stadium.StadiumID
                                        , ref stadium.SportType, ref stadium.FoorType,
                                         ref stadium.Year, ref stadium.Length,
                                          ref stadium.Width, ref stadium.Lighting
                                         , ref stadium.ConvertedHall, ref stadium.Capacity,
                                            ref stadium.RentalPricePerHour, ref stadium.Available, ref NumberOfImages))
            {
                stadium.StadiumName = stadiumName;

                if(NumberOfImages > 0)
                    stadium.StadiumImages = ClsStadiumImage.GetAllStadiumImages(stadium.StadiumID);

                return new ClsStadium(stadium);
            }
            else
                return null;
        }
        public static ClsStadium FindStadiumBySportTypeName(string SportType)
        {
            _StadiumInfos stadiums = new _StadiumInfos();

            byte NumberOfImages = 0;

            if(ClsStadiumDA.FindStadiumByStadiumName(SportType, ref stadiums.StadiumID, ref stadiums.StadiumName
                                                    , ref stadiums.FoorType,
                                                    ref stadiums.Year, ref stadiums.Length,
                                                    ref stadiums.Width, ref stadiums.Lighting
                                                    , ref stadiums.ConvertedHall, ref stadiums.Capacity,
                                                     ref stadiums.RentalPricePerHour, ref stadiums.Available, ref NumberOfImages))
            {
                stadiums.SportType = SportType;

                if(NumberOfImages > 0)
                    stadiums.StadiumImages = ClsStadiumImage.GetAllStadiumImages(stadiums.StadiumID);

                return new ClsStadium(stadiums);
            }
            else
                return null;
        }


        public static float CalCulateStadiumSurface(string Length, string width)
        {
            if(string.IsNullOrEmpty(Length) || string.IsNullOrEmpty(width))
                return 0;

            return Convert.ToSingle(Length) * Convert.ToSingle(width);
        }

        public bool AddNewStadium(int CreatedByUserID)
        {

            this.StadiumID = ClsStadiumDA.AddingStadium(this.StadiumName, this.SportType, this.FloorType, this.Year,
                                             this.Length, this.Width, Lighting, this.ConvertedHall
                                             , this.Capacity, this.RentalPricePerHour, this.Available, CreatedByUserID);


            return this.StadiumID > 0;
        }

        public bool AddingStadiumAndImages(int CreatedByUserID, List<string> imagePaths)
        {
            if(imagePaths.Count > 0)
            {

                this.StadiumID = ClsStadiumDA.AddNewStadiumWithImages(this.StadiumName, this.Year, this.FloorType, this.SportType,
                                                 this.Length, this.Width, Lighting, this.ConvertedHall
                                                 , this.Capacity, this.RentalPricePerHour, this.Available, imagePaths, CreatedByUserID);

                return this.StadiumID > 0;
            }
            else
            {
                return AddNewStadium(CreatedByUserID);
            }



        }

        private bool _UpdateStadium(int ModifiedByUserID)
        {

            return ClsStadiumDA.UpdateStadiumInfo(this.StadiumID, this.StadiumName, this.SportType,
                                                 this.FloorType, this.Year, this.Length, this.Width,
                                                  this.Lighting, this.ConvertedHall, this.Capacity,
                                                  this.RentalPricePerHour, this.Available, ModifiedByUserID);


        }

        public bool UpdateStadiumAndImages(int ModifiedByUserID, List<string> UpdatedimagePaths)
        {
            var original = this.StadiumImages ?? new List<string>();
            var updated = UpdatedimagePaths ?? new List<string>();

            bool fullUpdate = original.Count != updated.Count
                              || original.Except(updated).Any()
                              || updated.Except(original).Any();


            switch(fullUpdate)
            {
                case true:
                {
                    return ClsStadiumDA.UpdateStadiumWithImages(this.StadiumID, this.StadiumName, this.Year, this.FloorType, this.SportType,
                                                          this.Length, this.Width,
                                                          this.Lighting, this.ConvertedHall, this.Capacity,
                                                          this.RentalPricePerHour, this.Available, UpdatedimagePaths, ModifiedByUserID);
                }
                default:
                {
                    return _UpdateStadium(ModifiedByUserID);
                }

            }
        }

        public static bool DeleteStadium(int stadiumID, int DeletedByUserID)
        {
            return ClsStadiumDA.DeleteStadium(stadiumID, DeletedByUserID);
        }
        static public (DataView Stadiums, DataView StadiumsImages) GetAllStadiums()
        {
            (DataView Stadiums, DataView StadiumsImages) dv = ClsStadiumDA.GetAllStadiums();

            if(dv.Stadiums != null)
            {
                dv.Stadiums.Sort = "StadiumID";
                dv.StadiumsImages.Sort = "StadiumID";
            }


            return dv;
        }
        public static (DataView Stadiums, DataView StadiumsImages) GetAvailableStadiums()
        {
            (DataView Stadiums, DataView StadiumsImages) dv = ClsStadiumDA.GetAvailableStadiums();


            if(dv.Stadiums != null)
            {
                dv.Stadiums.Sort = "StadiumID";
                dv.StadiumsImages.Sort = "StadiumID";
            }


            return dv;
        }
        static public (DataRowView RowsStadiumsRow, List<string> List_StadiumsImages) IterateThrowStadiums((DataView Stadiums, DataView StadiumsImages) TupelStadiums, int Index)
        {
            //check if the gived index if out of range
            if(Index >= TupelStadiums.Stadiums.Count)
                return (null, null);
            //get the target stadiumas a DataRowView
            DataRowView StadiumsRow = TupelStadiums.Stadiums[Index];
            //Get stadiumID from StadiumsRow
            int stadiumId = Convert.ToInt32(StadiumsRow["StadiumID"]);

            //get all rows from Stadium Images Data view into Array by stadiumID
            DataRowView[] StadiumsImagesRows = TupelStadiums.StadiumsImages.FindRows(stadiumId);

            //Get only Stadium Image Paths from Array to Sorted Set
            List<string> ListimagePaths = StadiumsImagesRows.Select(Row => Row["StadiumImagePath"].ToString()).ToList();


            //Next Stadium
            //Index ++;
            //if(Index >= TupelStadiums.Stadiums.Count) Index = 0;

            return (StadiumsRow, ListimagePaths);
        }

        public static bool IsStadiumExist(int stadiumID)
        {
            return ClsStadiumDA.IsStadiumExist(stadiumID);
        }
        public static bool IsStadiumAvailable(int stadiumID)
        {
            return ClsStadiumDA.IsStadiumAvailable(stadiumID);
        }
        static public byte CountAvailableStadium()
        {
            return ClsStadiumDA.CountAvailableStadium();
        }
        public bool save(int ByUserID, List<string> UpdatedimagePaths)
        {
            switch(Mode)
            {
                case enMode.Add:
                {
                    if(AddingStadiumAndImages(ByUserID, UpdatedimagePaths))
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                }
                case enMode.Update:
                {
                    return UpdateStadiumAndImages(ByUserID, UpdatedimagePaths);
                }
            }
            return false;
        }
    }
}
