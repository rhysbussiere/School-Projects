<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_019.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Loan Application Form<br />
            <br />
            Name:&nbsp;
            <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Phone Number:&nbsp;
            <asp:TextBox ID="phoneTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Social Security Number:&nbsp;
            <asp:TextBox ID="socialTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Loan Origination Date:<br />
            <asp:Calendar ID="myCalendar" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
                <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
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
            Salary:&nbsp;
            <asp:TextBox ID="salaryTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="Submit" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
