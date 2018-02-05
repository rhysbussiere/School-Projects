<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_016.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Working with the Calendar Server Control<br />
            <br />
            <asp:Calendar ID="myCalendar" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="256px" OnSelectionChanged="myCalendar_SelectionChanged" style="margin-top: 0px" Width="384px">
                <DayHeaderStyle BackColor="#99CCCC" BorderStyle="None" ForeColor="#336666" Height="1px" />
                <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                <WeekendDayStyle BackColor="#CCCCFF" />
            </asp:Calendar>
            <br />
            <br />
            <asp:Button ID="getButton" runat="server" OnClick="getButton_Click" Text="Get Date" />
&nbsp;
            <asp:Button ID="setButton" runat="server" OnClick="setButton_Click" style="height: 29px" Text="Set Date" />
&nbsp;
            <asp:Button ID="showButton" runat="server" OnClick="showButton_Click" Text="Show Date" />
&nbsp;
            <asp:Button ID="weekButton" runat="server" OnClick="Button4_Click" Text="Selected Week" />
            <br />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
