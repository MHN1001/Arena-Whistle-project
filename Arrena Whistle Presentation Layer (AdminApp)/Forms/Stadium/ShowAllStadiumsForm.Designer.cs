namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Stadium
{
    partial class ShowAllStadiumsForm
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
            this.uC_ShowStadiums1 = new ShowAllStadiums_ControlLibrary.Stadiums.UC_ShowStadiums();
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
            this.btnCloseForm.Location = new System.Drawing.Point(907, 4);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCloseForm.Size = new System.Drawing.Size(31, 31);
            this.btnCloseForm.TabIndex = 369;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // uC_ShowStadiums1
            // 
            this.uC_ShowStadiums1.BackColor = System.Drawing.Color.LightCyan;
            this.uC_ShowStadiums1.Location = new System.Drawing.Point(-2, 2);
            this.uC_ShowStadiums1.Name = "uC_ShowStadiums1";
            this.uC_ShowStadiums1.Size = new System.Drawing.Size(946, 587);
            this.uC_ShowStadiums1.TabIndex = 370;
            this.uC_ShowStadiums1.OnLoadingFailed += new System.Action(this.uC_ShowStadiums1_OnLoadingFailed);
            this.uC_ShowStadiums1.OnShowAsStadiumsAsATableButtonClicked += new System.Action<System.Data.DataView>(this.uC_ShowStadiums1_OnShowAsStadiumsAsATableButtonClicked_1);
            this.uC_ShowStadiums1.OnBookingNowButtonClicked += new System.Action<ShowAllStadiums_ControlLibrary.Stadiums.UC_ShowStadiums.TargetStadiumEventArgs>(this.uC_ShowStadiums1_OnBookingNowButtonClicked);
            this.uC_ShowStadiums1.OnReserveNowButtonClicked += new System.Action<int>(this.uC_ShowStadiums1_OnReserveNowButtonClicked);
            this.uC_ShowStadiums1.Load += new System.EventHandler(this.uC_ShowStadiums1_Load);
            // 
            // ShowAllStadiumsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(946, 587);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.uC_ShowStadiums1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowAllStadiumsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowAllStadiumsForm";
            this.Load += new System.EventHandler(this.ShowAllStadiumsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btnCloseForm;
        private ShowAllStadiums_ControlLibrary.Stadiums.UC_ShowStadiums uC_ShowStadiums1;
    }
}