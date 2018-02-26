using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_050
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";
           
            List<Car> cars = new List<Car>()
            {
                new Car{Make = "Honda", Model = "NSX", Color = "Championship White", Year = 1993},
                new Car{Make = "Toyota", Model = "4Runner", Color = "Magnetic Gray", Year = 2017},
                new Car{Make = "Mitsubishi", Model = "Evolution VIII", Color = "Charcoal Gray", Year = 2004},
            };

            /*
            for (int i = 0; i < cars.Count; i++)
            {
                result += cars.ElementAt(i).FormatDetailsForDisplay();
            }
            */

            foreach (Car car in cars)
            {
                result += car.FormatDetailsForDisplay();
            }

            resultLabel.Text = result;
        }
    }
}