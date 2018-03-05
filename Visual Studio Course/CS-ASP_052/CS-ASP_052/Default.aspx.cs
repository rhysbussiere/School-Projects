using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_052
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var myGuid = Guid.NewGuid();
            //resultLabel.Text = myGuid.ToString();

            Guid myOtherGuid;
            if (Guid.TryParse("1c9b09c8-8f7d-45c0-9e02-1cb05fcb6c6c", out myOtherGuid))
            {
                resultLabel.Text = myOtherGuid.ToString();
            }


        }
    }
}