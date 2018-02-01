using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Defulat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Wolverine fewest battles
            //Pheonix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Phoenix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus"};
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";

            int largestNumberIndex = 0;
            int smallestNumberIndex = 0;
            //code here
            for (int i = 0; i < names.Length; i++)
            {
                if (numbers[i] > numbers[largestNumberIndex])
                {
                    largestNumberIndex = i;
                }
                if (numbers[i] < numbers[smallestNumberIndex])
                {
                    smallestNumberIndex = i;
                }
            }

            result = String.Format("Most battles belongs to: {0} (Battles: {1})", names[largestNumberIndex], numbers[largestNumberIndex]);
            result += String.Format("<br />Least battles belongs to: {0} (Battles: {1})", names[smallestNumberIndex], numbers[smallestNumberIndex]);

            resultLabel.Text = result;
        }
    }
}