<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 153px;
            height: 190px;
        }
        .newStyle1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <img class="auto-style1" src="epic-spies-logo.jpg" /><br />
            <br />
            <h1><span class="newStyle1">Spy New Assignment Form</span></h1>
            Spy Code Name:&nbsp;
            <asp:TextBox ID="firstTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            New Assignment Name:&nbsp; <asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            End Date of Previous Assignment:<br />
            <asp:Calendar ID="firstCalendar" runat="server"></asp:Calendar>
            <br />
            Start Date of New Assignment:<br />
            <asp:Calendar ID="secondCalendar" runat="server"></asp:Calendar>
            <br />
            End Date of New Assignment:<br />
            <asp:Calendar ID="thirdCalendar" runat="server"></asp:Calendar>
            <br />
            <br />
            <asp:Button ID="assignButton" runat="server" OnClick="assignButton_Click" Text="Assign" />
            <br />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
