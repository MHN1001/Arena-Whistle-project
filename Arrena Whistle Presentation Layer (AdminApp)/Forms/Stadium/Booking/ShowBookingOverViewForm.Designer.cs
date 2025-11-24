namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Stadium.Booking
{
    partial class ShowBookingOverViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uC_BookingOverView1 = new ShowAllStadiums_ControlLibrary.Stadiums.UC_BookingOverView();
            this.btnCloseForm = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // uC_BookingOverView1
            // 
            this.uC_BookingOverView1.BackColor = System.Drawing.Color.LightCyan;
            this.uC_BookingOverView1.Location = new System.Drawing.Point(-4, 2);
            this.uC_BookingOverView1.Name = "uC_BookingOverView1";
            this.uC_BookingOverView1.Size = new System.Drawing.Size(946, 587);
            this.uC_BookingOverView1.TabIndex = 0;
            this.uC_BookingOverView1.OnLoadingFailed += new System.Action(this.uC_BookingOverView1_OnLoadingFailed);
            this.uC_BookingOverView1.OnShowFullDataButtonClicked_FromBookingControl += new System.Action<Arena_Whistle_Buisness_layer.ClsBooking>(this.uC_BookingOverView1_OnShowFullDataButtonClicked_FromBookingControl);
            this.uC_BookingOverView1.OnShowAllInfosButtonClick_FromPersonControl += new System.Action<Arena_Whistle_Buisness_layerm.ClsPerson>(this.uC_BookingOverView1_OnShowAllInfosButtonClick_FromPersonControl);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseForm.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCloseForm.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCloseForm.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_login_40;
            this.btnCloseForm.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCloseForm.ImageRotate = 0F;
            this.btnCloseForm.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCloseForm.Location = new System.Drawing.Point(911, 2);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCloseForm.Size = new System.Drawing.Size(31, 31);
            this.btnCloseForm.TabIndex = 369;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // ShowBookingOverViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(946, 587);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.uC_BookingOverView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowBookingOverViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowBookingOverViewForm";
            this.Load += new System.EventHandler(this.ShowBookingOverViewForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ShowAllStadiums_ControlLibrary.Stadiums.UC_BookingOverView uC_BookingOverView1;
        private Guna.UI2.WinForms.Guna2ImageButton btnCloseForm;
    }
}