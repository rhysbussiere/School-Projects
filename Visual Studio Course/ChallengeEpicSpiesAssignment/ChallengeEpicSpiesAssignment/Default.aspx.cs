using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                firstCalendar.SelectedDate = DateTime.Now.Date;
                secondCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
                thirdCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);
            }
        }

        protected void assignButton_Click(object sender, EventArgs e)
        {
            TimeSpan length = thirdCalendar.SelectedDate.Subtract(secondCalendar.SelectedDate);
            double budget = length.TotalDays * 500.0;
            if (length.TotalDays > 21)
            {
                budget += 1000;
            }
            resultLabel.Text = String.Format("Assignment of {0} to assignment {1} is authorized. Budget total: {2:C}",
            firstTextBox.Text,
            secondTextBox.Text,
            budget);

            TimeSpan restTime = secondCalendar.SelectedDate.Subtract(firstCalendar.SelectedDate);
            if (restTime.TotalDays < 14)
            {
                resultLabel.Text = "Error: must allow at least two weeks between previous assignment and new assignment.";

                DateTime earliestStartTime = firstCalendar.SelectedDate.AddDays(14);

                firstCalendar.SelectedDate = earliestStartTime;
                firstCalendar.VisibleDate = earliestStartTime;
            }
        }
    }
}