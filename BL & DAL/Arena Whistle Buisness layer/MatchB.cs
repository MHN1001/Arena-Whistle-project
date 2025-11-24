using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Arena_Whistle_Data_Access_Layer;
using System.Windows;

using static Arena_Whistle_Buisness_layerm.ClsPerson;

namespace Arena_Whistle_Buisness_layer
{
    public static class ClsMatch
    {
        public static DataView GetAllMatchesTable()
        {
            return ClsMatchesDA.GetAllMatchesTableForAdmin();
        }

        public static DataView GetCurrentMatchesListForAdmin()
        {
            return ClsMatchesDA.GetCurrentMatchesListForAdmin();
        }
        public static DataView GetCurrentMatchesTableForClient()
        {
            return ClsMatchesDA.GetCurrentMatchesTableForClient();
        }

        public static DataView GetOnlyCurrentMatches(DataView AdminDataView)
        {
            DataView dt = AdminDataView;

            dt.RowFilter = "[Match Status] = 'In Progress'";

            return dt;
        }


        private static (TimeSpan? StartTime, TimeSpan? EndTime) GetTargetMatchPeriod(string StartTime, string EndTime)
        {
            if(StartTime == string.Empty || EndTime == string.Empty) return (null, null);

            return (TimeSpan.Parse(StartTime), TimeSpan.Parse(EndTime));
        }


        public static (int? Pb_MaxValue, int? Pb_Value) GetMaxValueAndValueFromTheTargetMatch(string StartTime, string EndTime)
        {
            (TimeSpan? StartTime, TimeSpan? EndTime) TimePeriod = GetTargetMatchPeriod(StartTime, EndTime);

            if(TimePeriod.StartTime == null || TimePeriod.EndTime == null)
                return (null, null);

            //get current date
            TimeSpan CurrentTime = TimeSpan.Parse(DateTime.Now.ToShortTimeString());

            //get MaxValue Of Progress bar
            double MatchPeriodTotalSeconds = ( TimePeriod.EndTime.GetValueOrDefault() - TimePeriod.StartTime.GetValueOrDefault() ).TotalSeconds;

            //check the current time if between match Time period
            //if yes we will returns both Match Value And Current Value
            //To start Counting How Many time Left For the target Match 
            if(CurrentTime <= TimePeriod.EndTime && CurrentTime > TimePeriod.StartTime)
            {
                // Instead of time left, we now get elapsed time (progress)
                double matchElapsedSeconds = ( CurrentTime - TimePeriod.StartTime.GetValueOrDefault() ).TotalSeconds;

                return ((int)MatchPeriodTotalSeconds, (int)matchElapsedSeconds);
            }

            return (null, null);

        }
    }

}

