using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeMegaCasino
{
    public partial class Default : System.Web.UI.Page
    {
        Random random = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                string[] reels = new string[] { placeBet(), placeBet(), placeBet(), };
                reelDisplay(reels);
                ViewState.Add("PlayersMoney", 100);
                displayMoney();
            }
        }

        protected void betButton_Click(object sender, EventArgs e)
        {
            int bet = 0;
            if (!int.TryParse(betTextBox.Text, out bet)) return;

            int winnings = pushButton(bet);
            showResult(bet, winnings);
            adjustPlayerMoney(bet, winnings);
            displayMoney();
        }

        private void adjustPlayerMoney(int bet, int winnings)
        {
            int playersMoney = int.Parse(ViewState["PlayersMoney"].ToString());
            playersMoney -= bet;
            playersMoney += winnings;
            ViewState["PlayersMoney"] = playersMoney;
        }

        private int pushButton(int bet)
        {
            string[] reels = new string[] { placeBet(), placeBet(), placeBet() };
            reelDisplay(reels);

            int multiplier = betMultiplier(reels);
            return bet * multiplier;
        }

        private int betMultiplier(string[] reels)
        {
            if (barShown(reels)) return 0;
            if (sevenShown(reels)) return 100;
            int multiplier = 0;
            if (betWin(reels, out multiplier)) return multiplier;

            return 0;
        }

        private bool barShown(string[] reels)
        {
            if (reels[0] == "Bar" || reels[1] == "Bar" || reels[2] == "Bar")
                return true;
            else
                return false;
        }

        private bool betWin(string[] reels, out int multiplier)
        {
            multiplier = getMultiplier(reels);
            if (multiplier > 0) return true;
            return false;
        }

        private int getMultiplier(string[] reels)
        {
            int cherryAmount = cherryCount(reels);
            if (cherryAmount == 1) return 2;
            if (cherryAmount == 2) return 3;
            if (cherryAmount == 3) return 4;
            return 0;
        }

        private int cherryCount(string[] reels)
        {
            int cherryAmount = 0;
            if (reels[0] == "Cherry") cherryAmount++;
            if (reels[1] == "Cherry") cherryAmount++;
            if (reels[2] == "Cherry") cherryAmount++;
            return cherryAmount;
        }

        private bool sevenShown(string[] reels)
        {
            if (reels[0] == "Seven" && reels[1] == "Seven" && reels[2] == "Seven")
                return true;
            else
                return false;
        }                             

        private string placeBet()
        {
            string[] images = new string[] {"Bar", "Bell", "Cherry", "Clover", "Diamond",
                "Horseshoe", "Lemon", "Orange", "Plum", "Seven", "Strawberry", "Watermelon"};            
            return images[random.Next(11)];
        }

        private void displayMoney()
        {
            moneyLabel.Text = String.Format("Player's Money: {0:C}", ViewState["PlayersMoney"]);
        }

        private void reelDisplay(string[] reels)
        {
            reel1.ImageUrl = "/Images/" + reels[0] + ".png";
            reel2.ImageUrl = "/Images/" + reels[1] + ".png";
            reel3.ImageUrl = "/Images/" + reels[2] + ".png";
        }

        private void showResult(int bet, int winnings)
        {
            if (winnings > 0)
            {
                resultLabel.Text = String.Format("You bet {0:C} and won {1:C}!", bet, winnings);
            }
            else
            {
                resultLabel.Text = String.Format("Sorry, you lost {0:C}. Better luck next time!", bet);
            }
        }
    }
}