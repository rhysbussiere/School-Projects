using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_046
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";

            Car car1 = new Car("Honda", "NSX", 1993, "White");
            Car car2 = new Car("Toyota", "4Runner", 2017, "Gray");
            Car car3 = new Car("Mitsubishi", "Evolution VIII", 2004, "Gray");

            List<Car> cars = new List<Car>();

            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);

            //List<Car> whiteCars = cars.FindAll(p => p.Color == "White");
            //cars.ForEach(p => p.Color = "Black");
            //if (cars.Exists(p => p.Year == 2004))
            //    result += "We do have a 2004 model year in stock!<br/>";

            for (int i = 0; i < cars.Count; i++)
            {
                result += cars.ElementAt(i).FormatDetailsForDisplay();
            }


            resultLabel.Text = result;
        }
    }
}