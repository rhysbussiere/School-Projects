using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void goButton_Click(object sender, EventArgs e)
        {
            /*
            int i;
            i = "3";
            */

            /*
            int i = 200000000;
            long j = i;
            */

            /* -- DOWN CAST --
            long i = 200000000;
            int j = (int)i;
            -- CAN CAUSE DATA LOSS -- */

            /*
            double k = 2.5;
            int j = (int)k;

            //resultLabel.Text = j;
            //resultLabel.Text = (string)j;
            resultLabel.Text = j.ToString();
            */

            string i = inputTextBox.Text;
            int j = int.Parse(i);
            int k = j + 1;
            resultLabel.Text = k.ToString();
        }
    }
}