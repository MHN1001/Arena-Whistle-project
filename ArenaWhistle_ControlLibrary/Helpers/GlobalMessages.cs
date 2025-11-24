using System;
using System.Windows.Forms;

namespace ControlLibrary.Helpers
{
    public static class GlobalMessages
    {

        public static void CancelSuccessfully(string message = "Cancel Successfully")
        {
            MessageBox.Show(message, "SUCCEEDED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void CancelFailed(string message = "Cancel Failed")
        {
            MessageBox.Show(message, "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Success message
        public static void NoData()
        {
            MessageBox.Show("There is No Data to be Loaded !", "NO DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowSavingSuccess(string message = "Saved successfully!")
        {
            MessageBox.Show(message, "SUCCEEDED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void DeletedFailed(string message = "Deleted Failed!")
        {
            MessageBox.Show(message, "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void DeletedSucessfully(string message = "Deleted Successfully!")
        {
            MessageBox.Show(message, "SUCCEEDED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void SomeThingWrong()
        {
            MessageBox.Show("Somting Wrong . Please Try Later", "WRONG", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        /// <summary>
        ///This Methode Will Show to the users 'Not Found' Message
        /// </summary>
        /// <returns>True if the user Want to Try Again, False if the user want to exit</returns>
        public static bool NotFound()
        {
            var Result = MessageBox.Show("Not Found", "NOT FOUND", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);


            return Result == DialogResult.Retry;

        }

        // Failure message
        public static bool ShowSavingFailed()
        {
            var Result = MessageBox.Show("Saved failed. Please try again.", "FAILED", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            return Result == DialogResult.OK;
        }

        // Loading failed message
        public static void ShowLoadingFailed()
        {
            MessageBox.Show("Loading data failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // General custom message
        public static void ShowCustom(string message, string title = "Message", MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }

        // Confirmation (yes/no) message
        public static bool Confirm(string message, string title = "Confirm")
        {
            var result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }


        public static void NotValid()
        {
            MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}

