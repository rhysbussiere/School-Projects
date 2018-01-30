﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] assets = new string[0];
                int[] elections = new int[0];
                int[] acts = new int[0];
                ViewState.Add("Assets", assets);
                ViewState.Add("Elections", elections);
                ViewState.Add("Acts", acts);
            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            string[] assets = (string[])ViewState["Assets"];
            int[] elections = (int[])ViewState["Elections"];
            int[] acts = (int[])ViewState["Acts"];

            int newLength = assets.Length + 1;

            Array.Resize(ref assets, newLength);
            Array.Resize(ref elections, newLength);
            Array.Resize(ref acts, newLength);

            int newAddition = assets.GetUpperBound(0);

            assets[newAddition] = assetTextBox.Text;
            elections[newAddition] = int.Parse(electionsTextBox.Text);
            acts[newAddition] = int.Parse(actsTextBox.Text);

            ViewState["Assets"] = assets;
            ViewState["Elections"] = elections;
            ViewState["Acts"] = acts;

            resultLabel.Text = String.Format("Total elections rigged: {0}<br />" +
                "Average acts of subterfuge per asset: {1:N}<br />" +
                "(Last asset you added: {2})",
                elections.Sum(),
                acts.Average(),
                assets[newAddition]);

            assetTextBox.Text = "";
            electionsTextBox.Text = "";
            actsTextBox.Text = "";
        }
    }
}