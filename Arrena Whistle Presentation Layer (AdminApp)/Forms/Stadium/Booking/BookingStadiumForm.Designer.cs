namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Stadium
{
    partial class BookingStadiumForm
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
            this.btnCloseForm = new Guna.UI2.WinForms.Guna2ImageButton();
            this.uC_BookingStadiumProcess1 = new ShowAllStadiums_ControlLibrary.Stadiums.UC_BookingStadiumProcess();
            this.SuspendLayout();
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
            this.btnCloseForm.Location = new System.Drawing.Point(913, 3);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCloseForm.Size = new System.Drawing.Size(31, 31);
            this.btnCloseForm.TabIndex = 368;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // uC_BookingStadiumProcess1
            // 
            this.uC_BookingStadiumProcess1.BackColor = System.Drawing.Color.LightCyan;
            this.uC_BookingStadiumProcess1.Location = new System.Drawing.Point(-2, 3);
            this.uC_BookingStadiumProcess1.Name = "uC_BookingStadiumProcess1";
            this.uC_BookingStadiumProcess1.Size = new System.Drawing.Size(946, 587);
            this.uC_BookingStadiumProcess1.TabIndex = 369;
            this.uC_BookingStadiumProcess1.OnBookinButtonClicked += new System.Action(this.uC_BookingStadiumProcess1_OnBookinButtonClicked);
            this.uC_BookingStadiumProcess1.OnAddedFailed += new System.Action(this.uC_BookingStadiumProcess1_OnAddedFailed);
            this.uC_BookingStadiumProcess1.OnAddedSucessfully += new System.Action(this.uC_BookingStadiumProcess1_OnAddedSucessfully);
            // 
            // BookingStadiumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(948, 587);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.uC_BookingStadiumProcess1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookingStadiumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingStadiumForm";
            this.Load += new System.EventHandler(this.BookingStadiumForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btnCloseForm;
        private ShowAllStadiums_ControlLibrary.Stadiums.UC_BookingStadiumProcess uC_BookingStadiumProcess1;
    }
}