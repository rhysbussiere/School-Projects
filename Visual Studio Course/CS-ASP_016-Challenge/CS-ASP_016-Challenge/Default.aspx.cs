using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_016_Challenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (firstCalendar.SelectedDate > secondCalendar.SelectedDate)
            {
                DateTime firstDate = Convert.ToDateTime(firstCalendar.SelectedDate.ToShortDateString());
                DateTime secondDate = Convert.ToDateTime(secondCalendar.SelectedDate.ToShortDateString());
                TimeSpan sumOfDays = (firstDate - secondDate);
                return;
            }
            else
            {
                DateTime firstDate = Convert.ToDateTime(firstCalendar.SelectedDate.ToShortDateString());
                DateTime secondDate = Convert.ToDateTime(secondCalendar.SelectedDate.ToShortDateString());
                TimeSpan sumOfDays = (secondDate - firstDate);
                resultLabel.Text = sumOfDays.TotalDays.ToString();
            }
        }
    }
}