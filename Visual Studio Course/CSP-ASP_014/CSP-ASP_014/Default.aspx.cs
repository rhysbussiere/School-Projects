﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSP_ASP_014
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //DateTime myValue = DateTime.Now;
            //resultLabel.Text = myValue.ToString();
            //resultLabel.Text = myValue.ToLongDateString();
            //resultLabel.Text = myValue.ToLongTimeString();
            //resultLabel.Text = myValue.ToShortDateString();
            //resultLabel.Text = myValue.ToShortTimeString();

            //resultLabel.Text = myValue.AddDays(2).ToString();
            //resultLabel.Text = myValue.AddDays(-2).ToString();

            //resultLabel.Text = myValue.Month.ToString();
            //resultLabel.Text = myValue.IsDaylightSavingTime().ToString();
            //resultLabel.Text = myValue.DayOfWeek.ToString();
            //resultLabel.Text = myValue.DayOfYear.ToString();

            //DateTime myValue = DateTime.Parse("03/28/1987");
            DateTime myValue = new DateTime(1987, 03, 28, 3, 54, 37);
            resultLabel.Text = myValue.ToString();

        }
    }
}