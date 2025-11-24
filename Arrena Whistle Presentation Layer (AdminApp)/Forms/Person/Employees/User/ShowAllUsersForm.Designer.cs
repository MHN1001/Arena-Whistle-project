namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Person.Employees.User
{
    partial class ShowAllUsersForm
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
            this.uC_DGV1 = new ShowAllStadiums_ControlLibrary.Global__User_Controls.UC_DGV();
            this.SuspendLayout();
            // 
            // uC_DGV1
            // 
            this.uC_DGV1.Location = new System.Drawing.Point(0, 0);
            this.uC_DGV1.Name = "uC_DGV1";
            this.uC_DGV1.Size = new System.Drawing.Size(914, 587);
            this.uC_DGV1.TabIndex = 0;
            this.uC_DGV1.OnAddTSMIclicked += new System.Action(this.uC_DGV1_OnAddTSMIclicked);
            this.uC_DGV1.OnUpdateTSMIclicked += new System.Action<System.Windows.Forms.DataGridViewRow>(this.uC_DGV1_OnUpdateTSMIclicked);
            this.uC_DGV1.OnDeleteTSMIclicked += new System.Action<System.Windows.Forms.DataGridViewRow>(this.uC_DGV1_OnDeleteTSMIclicked);
            this.uC_DGV1.OnCloseButtonClicked += new System.Action(this.uC_DGV1_OnCloseButtonClicked);
            this.uC_DGV1.Load += new System.EventHandler(this.uC_DGV1_Load);
            // 
            // ShowAllUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(914, 587);
            this.Controls.Add(this.uC_DGV1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowAllUsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowAllUsersForm";
            this.Load += new System.EventHandler(this.ShowAllUsersForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ShowAllStadiums_ControlLibrary.Global__User_Controls.UC_DGV uC_DGV1;
    }
}