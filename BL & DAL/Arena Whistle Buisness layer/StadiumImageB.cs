using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arena_Whistle_Data_Access_Layer;

namespace Arena_Whistle_Buisness_layer
{
    public class ClsStadiumImage
    {
        public static List<string> GetAllStadiumImages(int StadiumID)
        {
            return ClsStadiumImageDA.GetAllStadiumImages(StadiumID);
        }
        public static int AddingStadiumImage(int StadiumID, string StadiumImagePath, int ByUserID)
        {
            return ClsStadiumImageDA.AddingStadiumImageByStadiumID(StadiumImagePath,  StadiumID,  ByUserID);
        }
        public bool UpdateStadiumImage(int StadiumImageID, string NewImagePath, int ByUserID)
        {
            return ClsStadiumImageDA.UpdateStadiumImage(StadiumImageID, NewImagePath, ByUserID);
        }
        public static bool DeleteStadiumImage(int StadiumImageID, int ByUserID)
        {
            return ClsStadiumImageDA.DeleteImage(StadiumImageID, ByUserID);
        }

    }

}
