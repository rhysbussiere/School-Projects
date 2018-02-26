using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConstantsExample
{
    public partial class Default : System.Web.UI.Page
    {
        const string fileExtension = ".html";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            const int hoursPerDay = 24;

            const double daysPerWeek = (double)Calendar.days / (double)Calendar.weeks;

            string result = "";

            for (int i = 1; i <= daysPerWeek; i++)
            {
                for (int j = 0; j < hoursPerDay; j++)
                {
                    result += String.Format("<p><a href='report-{0}-{1}.{2}'>Day: {0} -- Hour: {1}</a></p>", i, j, fileExtension);
                }
            }

            resultLabel.Text = result;
        }
    }
}