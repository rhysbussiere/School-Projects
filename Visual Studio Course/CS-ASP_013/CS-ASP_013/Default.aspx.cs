using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_013
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //comparisonLabel.Text = "equal to";
            //comparisonLabel.Text = "not equal to";
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //resultLabel.Text = (firstTextBox.Text == secondTextBox.Text) ? "Yes" : "No";

            //resultLabel.Text = (firstTextBox.Text != secondTextBox.Text) ? "Yes" : "No";

            //resultLabel.Text = (firstTextBox.Text > secondTextBox.Text) ? "Yes" : "No";

            //int first = int.Parse(firstTextBox.Text);
            //int second = int.Parse(secondTextBox.Text);
            //resultLabel.Text = (first > second) ? "Yes" : "No";
            //resultLabel.Text = (first < second) ? "Yes" : "No";
            //resultLabel.Text = (first >= second) ? "Yes" : "No";
            //resultLabel.Text = (first <= second) ? "Yes" : "No";

            //resultLabel.Text = (firstCheckBox.Checked) "Yes" : "No";

            /*if (firstCheckBox.Checked && 
             * firstTextBox.Text == "Rhys" 
             * && secondTextBox.Text == "Bussiere")
            {
                resultLabel.Text = "Perfect Trifecta!";
            }
            */

            /*if (firstCheckBox.Checked || firstTextBox.Text == "Bob" 
                || secondTextBox.Text == "Bussiere")
            {
                resultLabel.Text = "One out of three ain't bad!";
            }
            */

            /*
            if ((firstCheckBox.Checked || firstTextBox.Text == "Bob")
                && secondTextBox.Text == "Bussiere")
            {
                resultLabel.Text = "Two out of three ain't bad!";
            }
            */

        }
    }
}