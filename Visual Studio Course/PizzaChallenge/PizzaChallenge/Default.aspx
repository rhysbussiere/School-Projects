<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PizzaChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            color: #FF0000;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style3 {
            font-size: medium;
        }
        .auto-style5 {
            line-height: 100%;
        }
        .auto-style6 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style8 {
            text-decoration: underline;
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Image ID="Image1" runat="server" ImageUrl="~/PapaBob.png" />
&nbsp;</p>
            <h1 class="auto-style6">&nbsp;Papa Bob&#39;s Pizza and Software</h1>
            <h3 class="auto-style8" style="margin-left: 40px"><strong>Size: </strong>
                <asp:Label ID="sizeLabel" runat="server"></asp:Label>
            </h3>
            <p class="auto-style5">
                <asp:RadioButton ID="babyRadioButton" runat="server" GroupName="sizeGroup" Text="Baby Bob Size (10&quot;) = $10.00" />
            </p>
            <p class="auto-style5">
                <asp:RadioButton ID="mamaRadioButton" runat="server" GroupName="sizeGroup" Text="Mama Bob Size (13&quot;) = $13.00" />
            </p>
            <p class="auto-style5">
                <asp:RadioButton ID="papaRadioButton" runat="server" GroupName="sizeGroup" Text="Papa Bob Size (16&quot;) = $16.00" />
            </p>
            <h3 class="auto-style8" style="margin-left: 40px">Crust:
                <asp:Label ID="crustLabel" runat="server"></asp:Label>
            </h3>
            <p>
                <asp:RadioButton ID="thinRadioButton" runat="server" GroupName="crustGroup" Text="Thin Crust" />
            </p>
            <p>
                <asp:RadioButton ID="deepRadioButton" runat="server" GroupName="crustGroup" Text="Deep Dish (+2.00)" />
            </p>
            <h3>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style8">Toppings: </span>
                <asp:Label ID="toppingLabel" runat="server"></asp:Label>
            </h3>
            <p>
                <asp:CheckBox ID="roniCheckBox" runat="server" CssClass="auto-style3" Text="Pepperoni (+$1.50)" />
            </p>
            <p>
                <asp:CheckBox ID="onionCheckBox" runat="server" CssClass="auto-style3" Text="Onions (+$0.75)" />
            </p>
            <p>
                <asp:CheckBox ID="gpepperCheckBox" runat="server" CssClass="auto-style3" Text="Green Pepper (+$0.50)" />
            </p>
            <p>
                <asp:CheckBox ID="rpepperCheckBox" runat="server" CssClass="auto-style3" Text="Red Peppers (+$0.75)" />
            </p>
            <p>
                <asp:CheckBox ID="anchovyCheckBox" runat="server" CssClass="auto-style3" Text="Anchovies (+$2.00)" />
            </p>
            <p>
                &nbsp;</p>
            <h2><span class="auto-style6">Papa Bob&#39;s </span><span class="auto-style2">Special Deal</span></h2>
            <p>
                Save $2.00 when you add Pepperoni, Green Peppers and Anchovies OR Pepperoni, Red Peppers and Onions to your pizza!</p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Button ID="buyButton" runat="server" OnClick="buyButton_Click" Text="Purchase" />
            </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Label ID="resultLabel" runat="server"></asp:Label>
            </p>
            <p>
                &nbsp;</p>
            <p>
                Sorry, at this time you can only order one pizza online, and pick-up only......we need a better website!</p>
        </div>
    </form>
</body>
</html>
