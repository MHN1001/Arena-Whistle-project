using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arrena_Whistle_Admin_Presentation_Layer.Forms.Clients;
using Arrena_Whistle_Admin_Presentation_Layer.Forms.Main_Menu;
using Arrena_Whistle_Admin_Presentation_Layer.Forms.Stadium;
using Arrena_Whistle_Admin_Presentation_Layer.Forms_and_UserControls;

namespace Arrena_Whistle_Admin_Presentation_Layer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
