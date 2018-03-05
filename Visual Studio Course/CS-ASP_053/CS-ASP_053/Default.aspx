<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_053.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="heroNameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:DropDownList ID="heroTypeDropDownList" runat="server">
                <asp:ListItem>Select One...</asp:ListItem>
                <asp:ListItem>Fighter</asp:ListItem>
                <asp:ListItem>Wizard</asp:ListItem>
                <asp:ListItem>Monster</asp:ListItem>
                <asp:ListItem Value="DemonHunter">Demon Hunter</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
            <br />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
