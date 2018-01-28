using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzaChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buyButton_Click(object sender, EventArgs e)
        {
            // SIZE SELECTIONS
            decimal size;
            if (babyRadioButton.Checked)
            {
                size = Convert.ToDecimal(10.00);
            }
            else if (mamaRadioButton.Checked)
            {
                size = Convert.ToDecimal(13.00);
            }
            else if (papaRadioButton.Checked)
            {
                size = Convert.ToDecimal(16.00);
            }
            else
            {
                sizeLabel.Text = "Please select a size!";
                return;
            }

            //  CRUST SELECTIONS
            decimal crust;
            if (thinRadioButton.Checked)
            {
                crust = Convert.ToDecimal(0.00);
            }
            else if (deepRadioButton.Checked)
            {
                crust = Convert.ToDecimal(2.00);
            }
            else
            {
                crustLabel.Text = "Please select a crust!";
                return;
            }
            //  TOPPING SELECTIONS
            decimal topping = Convert.ToDecimal(0.00);
            if (roniCheckBox.Checked)
            {
                topping += Convert.ToDecimal(1.50);
            }
            if (onionCheckBox.Checked)
            {
                topping += Convert.ToDecimal(0.75);
            }
            if (gpepperCheckBox.Checked)
            {
                topping += Convert.ToDecimal(0.50);
            }
            if (rpepperCheckBox.Checked)
            {
                topping += Convert.ToDecimal(0.75);
            }
            if (anchovyCheckBox.Checked)
            {
                topping += Convert.ToDecimal(2.00);
            }
            //  SPECIAL DEAL FUNCTION
            decimal special;
            if (roniCheckBox.Checked && gpepperCheckBox.Checked && anchovyCheckBox.Checked)
            {
                special = Convert.ToDecimal(2.00);
            }
            else if (roniCheckBox.Checked && rpepperCheckBox.Checked && onionCheckBox.Checked)
            {
                special = Convert.ToDecimal(2.00);
            }
            else
            {
                special = Convert.ToDecimal(0.00);
            }
            //  RESULT TOTAL
            decimal sum = size + crust + topping - special;
            resultLabel.Text = ("Total: $" + string.Format("{0:#.00}", sum));
        }
    }
}