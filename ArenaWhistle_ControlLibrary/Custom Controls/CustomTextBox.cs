using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using ShowAllStadiums_ControlLibrary.Validations;

namespace ShowAllStadiums_ControlLibrary
{

    public partial class CustomTextBox : Guna2TextBox
    {
        public CustomTextBox()
        {
            InitializeComponent();

            SetUpTextBox();

        }


        //protected override void OnPaint(PaintEventArgs pe)
        //{
        //    base.OnPaint(pe);
        //}

        private void SetUpTextBox()
        {
            this.Size = new Size(225, 36);
            this.AutoRoundedCorners = true;
            this.BorderColor = Color.DarkTurquoise;
            this.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 1, false);
            this.ForeColor = Color.Black;
        }

        public bool IsRequired { get; set; }

        public enum InputTypeEnum { TextInput, NumberInput, EmailInput, PassWordInput }
        public InputTypeEnum InputType { get; set; } = InputTypeEnum.TextInput;


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



        private bool CheckTextValidation(ref CancelEventArgs e, ErrorProvider errorProvider, string errorMessage)
        {
            if(string.IsNullOrEmpty(this.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(this, "Invalide Name");
                return false;
            }
            else
            {
                if(IsNumber(this.Text))
                {
                    e.Cancel = true;
                    errorProvider.SetError(this, "The text box cannot contain numbers.");
                    return false;
                }
            }

            errorProvider.SetError(this, string.Empty);
            return true;
        }
        private bool CheckPhoneNumberValidation(ref CancelEventArgs e, ErrorProvider errorProvider, string errorMessage)
        {
            if(double.TryParse(this.Text, out double number))
            {
                if(number  >  0)
                {
                    errorProvider.SetError(this, string.Empty);
                    return true;
                }
            }
            e.Cancel = true;
            errorProvider.SetError(this, "Invalide phone number !");
            return false;
        }
        private bool CheckEmailValidation(ref CancelEventArgs e, ErrorProvider errorProvider, string errorMessage)
        {
            if(!string.IsNullOrEmpty(this.Text))
            {
                if(!clsValidation.ValidateEmail(this.Text))
                {
                    e.Cancel = true;
                    errorProvider.SetError(this, "Invalide Email Format");
                    return false;
                }
            }
            errorProvider.SetError(this, string.Empty);
            return true;
        }
        private bool CheckPasswordlValidation(ref CancelEventArgs e, ErrorProvider errorProvider, string errorMessage)
        {
            if(!string.IsNullOrEmpty(this.Text))
            {
                if(this.Text.Length < 8)
                {
                    e.Cancel = true;
                    errorProvider.SetError(this, "The minimum of Password length Should be 8 !");
                    return false;
                }
                errorProvider.SetError(this, string.Empty);
                return true;
            }
            errorProvider.SetError(this, errorMessage);
            return false;
        }
        public bool IsPasswordsMatches(string ConfirmPassText, string CorePasswordText, ErrorProvider errorProvider, string errorMessage)
        {

            if(! string.Equals(ConfirmPassText, CorePasswordText))
            {
                errorProvider.SetError(this, errorMessage);
                return false;
            }
            errorProvider.SetError(this, string.Empty);
            return true;
        }



        public bool IsValid(ref CancelEventArgs e, ErrorProvider errorProvider, string errorMessage)
        {
            if(IsRequired)
            {
                switch(InputType)
                {
                    case InputTypeEnum.TextInput:
                    {
                        return CheckTextValidation(ref e, errorProvider, errorMessage);
                    }
                    case InputTypeEnum.NumberInput:
                    {
                        return CheckPhoneNumberValidation( ref e, errorProvider, errorMessage);
                    }
                    case InputTypeEnum.EmailInput:
                    {
                        return CheckEmailValidation(ref e, errorProvider, errorMessage);
                    }
                    case InputTypeEnum.PassWordInput:
                    {
                        return CheckPasswordlValidation(ref e, errorProvider, errorMessage);
                    }

                }
            }
            errorProvider.SetError(this, string.Empty);
            return true;

        }

    }
}
