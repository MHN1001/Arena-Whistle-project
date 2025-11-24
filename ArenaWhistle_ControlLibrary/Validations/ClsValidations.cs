using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowAllStadiums_ControlLibrary.Validations
{
    public static class clsValidation
    {
        public static bool ValidateEmail(string emailAddress)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(emailAddress);
        }

        public static bool ValidateInteger(string Number)
        {
            var pattern = @"^[0-9]*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }

        public static bool ValidateFloat(string Number)
        {
            var pattern = @"^[0-9]*(?:\.[0-9]*)?$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }

        public static bool IsNumber(string Number)
        {
            return ( ValidateInteger(Number) || ValidateFloat(Number) );
        }




        /// <summary>
        /// Retrieves the value of type T from a DataGridViewRow cell if it exists and is not null.
        /// </summary>
        /// <typeparam name="T">The type to cast the cell value to.</typeparam>
        /// <param name="row">The DataGridViewRow to read from.</param>
        /// <param name="columnName">The column name to read.</param>
        /// <returns>The value of type T if present; otherwise default(T).</returns>
        public static T GetCellValueIfNotNull<T>(DataGridViewRow row, string columnName)
        {
            if(row == null)
                return default(T);

            try
            {
                var cellValue = row.Cells[columnName]?.Value;

                if(cellValue == null)
                    return default(T);

                if(cellValue is T tValue)
                    return tValue;

                return (T)Convert.ChangeType(cellValue, typeof(T));
            }
            catch
            {
                // Column doesn't exist or conversion failed
                return default(T);
            }
        }

    }
}