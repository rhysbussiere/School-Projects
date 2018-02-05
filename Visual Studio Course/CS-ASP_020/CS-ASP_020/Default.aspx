<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_020.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Type a value to add it to the string:<br />
            <br />
            Server Control:<br />
            <br />
            <asp:TextBox ID="serverTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Plain &#39;ol HTML Input Text Field:<br />
            <br />
            <asp:TextBox ID="htmlTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" style="height: 29px" Text="Add" />
            <br />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
