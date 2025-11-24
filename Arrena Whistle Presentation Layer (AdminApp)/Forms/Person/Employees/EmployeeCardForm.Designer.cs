namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Employees
{
    partial class EmployeeCardForm
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
            this.lblTittle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCloseForm = new Guna.UI2.WinForms.Guna2ImageButton();
            this.uC_ShowEmployeeCard1 = new Arrena_Whistle_Admin_Presentation_Layer.Forms_and_UserControls.Employees.UC_ShowEmployeeCard();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.BackColor = System.Drawing.Color.Transparent;
            this.lblTittle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTittle.Font = new System.Drawing.Font("Calibri", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lblTittle.Location = new System.Drawing.Point(362, 12);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(219, 46);
            this.lblTittle.TabIndex = 361;
            this.lblTittle.Text = "Employee Card";
            this.lblTittle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnCloseForm.Location = new System.Drawing.Point(909, 4);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCloseForm.Size = new System.Drawing.Size(31, 31);
            this.btnCloseForm.TabIndex = 367;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // uC_ShowEmployeeCard1
            // 
            this.uC_ShowEmployeeCard1.BackColor = System.Drawing.Color.Transparent;
            this.uC_ShowEmployeeCard1.Location = new System.Drawing.Point(78, 189);
            this.uC_ShowEmployeeCard1.Name = "uC_ShowEmployeeCard1";
            this.uC_ShowEmployeeCard1.Size = new System.Drawing.Size(787, 251);
            this.uC_ShowEmployeeCard1.TabIndex = 368;
            this.uC_ShowEmployeeCard1.OnLoadingFailed += new System.Action(this.uC_ShowEmployeeCard1_OnLoadingFailed);
            this.uC_ShowEmployeeCard1.OnShowAllPersonInfosButtonClicked += new System.Action<Arena_Whistle_Buisness_layerm.ClsPerson>(this.uC_ShowEmployeeCard1_OnShowAllPersonInfosButtonClicked);
            // 
            // EmployeeCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(946, 587);
            this.Controls.Add(this.uC_ShowEmployeeCard1);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.lblTittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeCardForm";
            this.Load += new System.EventHandler(this.EmployeeCardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTittle;
        private Guna.UI2.WinForms.Guna2ImageButton btnCloseForm;
        private Forms_and_UserControls.Employees.UC_ShowEmployeeCard uC_ShowEmployeeCard1;
    }
}