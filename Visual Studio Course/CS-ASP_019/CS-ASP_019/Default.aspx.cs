using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_019
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            //string result = String.Format("Thank you, {0}, for your business", nameTextBox.Text);
            int social = int.Parse(socialTextBox.Text);
            long phone = long.Parse(phoneTextBox.Text);
            double salary = double.Parse(salaryTextBox.Text);
            string result = String.Format("Thank you, {0}, for your business. <br />" +
            "Your phone number is: {1:(000)-000-0000} <br />" +
            "Your Social Security Number is: {2:000-00-0000}" +
            "Your loan date is: {3:ddd -- d, M, yy} <br />" +
            "Your salary is: {4:} <br />", 
            nameTextBox.Text, 
            phone, 
            social,
            myCalendar.SelectedDate,
            salary);

            resultLabel.Text = result;
        }
    }
}