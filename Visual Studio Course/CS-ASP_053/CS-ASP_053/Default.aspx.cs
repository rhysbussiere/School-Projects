using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_053
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var hero = new Character();
            hero.Name = "Rhys";
            hero.Type = CharacterType.Fighter;

            if (hero.Type == CharacterType.Fighter)
            {
                resultLabel.Text = "Our hero is a fighter!";
            }
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            var hero = new Character();
            hero.Name = heroNameTextBox.Text;

            CharacterType selection;
            if (Enum.TryParse(heroTypeDropDownList.SelectedValue, out selection))
            {
                hero.Type = selection;
            }

            if (hero.Type == CharacterType.Fighter)
            {
                resultLabel.Text = "You selected a fighter!";
            }


        }

        public class Character
        {
            public string Name { get; set; }
            public CharacterType Type { get; set; }
        }

        public enum CharacterType
        {
            Wizard,
            Fighter,
            Monster,
            DemonHunter
        }
    }
}