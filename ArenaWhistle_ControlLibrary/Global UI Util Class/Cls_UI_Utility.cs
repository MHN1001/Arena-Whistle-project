using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowAllStadiums_ControlLibrary.Global_Util_Class
{
    public static class Cls_UI_Utility
    {
        /// <summary>
        /// Calculates the horizontal position (Left value) needed to center a label
        /// inside a given container based on their widths.
        /// </summary>
        /// <param name="LblWidth">The width of the label to be centered.</param>
        /// <param name="ContainerWidth">The total inner width of the container (Form, Panel, or UserControl).</param>
        /// <returns>
        /// The X-coordinate (Left position) at which the label should be placed
        /// to appear horizontally centered within the container.
        /// </returns>
        public static int CenterLabel(int LblWidth, int ContainerWidth)
        {
            // Return left position of the Label 
            return ( ContainerWidth - LblWidth ) / 2;
        }
    }
}
