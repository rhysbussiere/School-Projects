using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Deafult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1. Reverse your name
           
            string name = "Rhys Bussiere";
            /*
            for (int i = name.Length - 1; i >= 0; i--)
            {
                resultLabel.Text += name[i];
            }
            */

            // 2. Reverse this sequence:         
            string names = "Luke,Leia,Han,Chewbacca";

            /*
            string[] rebels = names.Split(',');
            string result = "";
            for (int i = rebels.Length - 1; i >= 0; i--)
            {
                result += rebels[i] + ",";
            }
            result = result.Remove(result.Length - 1, 1);
            resultLabel.Text = result;
            */


            // 3. Use the sequence to create ascii art:
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***

            /*
            string[] rebels = names.Split(',');
            string result = "";
            for (int i = 0; i < rebels.Length; i++)
            {
                int padLeft = (14 - rebels[i].Length) / 2;
                string temp = rebels[i].PadLeft(rebels[i].Length + padLeft, '*');
                result += temp.PadRight(14, '*');
                result += "<br />";
            }
            resultLabel.Text = result;
            */


            // 4. Solve the puzzle:


            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNTRY.";
            // needs to read: "Now is the time for all good men to come to the aid of their country."

            /*
            string removeMe = "remove-me";
            int index = puzzle.IndexOf(removeMe);
            puzzle = puzzle.Remove(index, removeMe.Length);
            puzzle = puzzle.ToLower();
            puzzle = puzzle.Replace('z', 't');
            puzzle = puzzle.Remove(0, 1);
            puzzle = puzzle.Insert(0, "N");

            resultLabel.Text = puzzle;
            */


        }
    }
}