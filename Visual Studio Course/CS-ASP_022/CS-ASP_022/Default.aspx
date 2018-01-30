<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_022.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            From:<br />
            <br />
            <asp:RadioButton ID="fromChicagoRadio" runat="server" GroupName="fromGroup" Text="Chicago" />
            <br />
            <asp:RadioButton ID="fromNYRadio" runat="server" GroupName="fromGroup" Text="New York" />
            <br />
            <asp:RadioButton ID="fromLondonRadio" runat="server" GroupName="fromGroup" Text="London" />
            <br />
            <br />
            To:<br />
            <br />
            <asp:RadioButton ID="toChicagoRadio" runat="server" GroupName="toGroup" Text="Chicago" />
            <br />
            <asp:RadioButton ID="toNYRadio" runat="server" GroupName="toGroup" Text="New York" />
            <br />
            <asp:RadioButton ID="toLondonRadio" runat="server" GroupName="toGroup" Text="London" />
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
            <br />
            <br />
            <br />
            Ticket Price:&nbsp; <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
