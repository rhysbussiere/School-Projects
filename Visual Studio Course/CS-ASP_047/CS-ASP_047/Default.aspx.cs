using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_047
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";

            /*
            Car car1 = new Car("Honda", "NSX", 1993, "Championship White");
            Car car2 = new Car("Toyota", "4Runner", 2017, "Magnetic Gray");
            Car car3 = new Car("Mitsubishi", "Evolution VIII", 2004, "Charcoal Gray");
            */

            List<Car> cars = new List<Car>();

            cars.Add(new Car { Make = "Honda", Model = "NSX", Color = "Championship White", Year = 1993 });
            cars.Add(new Car { Make = "Toyota", Model = "4Runner", Color = "Magnetic Gray", Year = 2017 });
            cars.Add(new Car { Make = "Mitsubishi", Model = "Evolution VIII", Color = "Charcoal Gray", Year = 2004 });

            for (int i = 0; i < cars.Count; i++)
            {
                result += cars.ElementAt(i).FormatDetailsForDisplay();
            }

            /*
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
            */

            // DO STUFF //


            resultLabel.Text = result;
        }
    }
}