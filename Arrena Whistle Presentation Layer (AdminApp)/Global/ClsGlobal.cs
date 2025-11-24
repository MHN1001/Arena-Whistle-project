using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arena_Whistle_Buisness_layer;

namespace Arrena_Whistle_Admin_Presentation_Layer.Global
{
    public static class ClsGlobal
    {
        public static ClsUser CurrentUser { get; set; }


        public enum Permission : int
        {
            // Special
            FullAccess = -1,

            // Stadiums
            ShowAllStadiumsTable = 1,
            ShowAllStadiums = 2,
            ShowAvailableStadiums = 4,
            AddNewStadium = 8,
            UpdateStadium = 16,

            // Matches
            ShowCurrentMatches = 32,
            ShowMatchesHistory = 64,

            // Booking
            ShowBookedStadiums = 128,
            BookingStadium = 256,

            // Reservations
            ShowReservedStadiums = 512,
            ReserveStadium = 1024,

            // Clients
            AllClients = 2048,
            ActiveClients = 4096,
            InActiveClients = 8192,

            // Employees (Values shifted to fill gaps)
            ShowAllEmployees = 16384,

            // Users (Values shifted to fill gaps)
            ShowAllUsers = 32768,
            AddNewUser = 65536,
            UpdateUser = 131072,
        }
    }

}
