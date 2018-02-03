<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeMegaCasino.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="reel1" runat="server" Height="150px" Width="150px" />
&nbsp;<asp:Image ID="reel2" runat="server" Height="150px" Width="150px" />
&nbsp;<asp:Image ID="reel3" runat="server" Height="150px" Width="150px" />
            <br />
            <br />
            Your Bet:&nbsp;
            <asp:TextBox ID="betTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="betButton" runat="server" OnClick="betButton_Click" Text="Pull The Lever!" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="moneyLabel" runat="server"></asp:Label>
            <br />
            <br />
            1 Cherry = Your Bet x 2<br />
            2 Cherry = Your Bet x 3<br />
            3 Cherry = Your Bet x 4<br />
            3 7&#39;s = Your Bet x 100<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; --- HOWEVER ---
            <br />
            if there is even one &quot;BAR&quot; you win nothing </div>
    </form>
</body>
</html>
