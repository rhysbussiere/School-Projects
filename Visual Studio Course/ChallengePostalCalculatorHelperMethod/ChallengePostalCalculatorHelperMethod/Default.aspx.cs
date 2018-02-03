using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculatorHelperMethod
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            calculatePostage();
        }

        protected void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            calculatePostage();
        }

        protected void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
            calculatePostage();
        }

        protected void groundRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            calculatePostage();
        }

        protected void airRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            calculatePostage();
        }

        protected void nextRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            calculatePostage();
        }

        private void calculatePostage()
        {
            if (!valuesExist()) return;

            int size = 0;
            if (!getSize(out size)) return;

            double postagePricing = getPostagePricing();

            double price = size * postagePricing;

            resultLabel.Text = String.Format("Your parcel will cost {0:C} to ship.", price);
        }

        private bool valuesExist()
        {
            if (!airRadioButton.Checked && !groundRadioButton.Checked && 
                !nextRadioButton.Checked)
                return false;

            if (widthTextBox.Text.Trim().Length == 0 || heightTextBox.Text.Trim().Length == 0)
                return false;

            return true;
        }

        private bool getSize(out int size)
        {
            size = 0;
            int width = 0;
            int height = 0;
            int length = 0;

            if (!int.TryParse(widthTextBox.Text.Trim(), out width)) return false;
            if (!int.TryParse(heightTextBox.Text.Trim(), out height)) return false;
            if (!int.TryParse(lengthTextBox.Text.Trim(), out length)) length = 1;

            size = width * height * length;
            return true;
        }

        private double getPostagePricing()
        {
            if (groundRadioButton.Checked) return .15;
            else if (airRadioButton.Checked) return .25;
            else if (nextRadioButton.Checked) return .45;
            else return 0;
        }
    }
}