<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Simple Calculator</h1>
            <p>
                &nbsp;</p>
            <p>
                <span class="auto-style1">First Value: </span>&nbsp;<asp:TextBox ID="firstTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <span class="auto-style1">Second Value:</span>&nbsp;
                <asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="  +  " />
&nbsp;
                <asp:Button ID="subtractButton" runat="server" OnClick="subtractButton_Click" Text="  -  " />
&nbsp;
                <asp:Button ID="multiplyButton" runat="server" OnClick="multiplyButton_Click" Text="  *  " />
&nbsp;
                <asp:Button ID="divisionButton" runat="server" OnClick="divisionButton_Click" Text="  /  " />
&nbsp;
            </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Label ID="resultLabel" runat="server" style="font-weight: 700; background-color: #0099FF"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
