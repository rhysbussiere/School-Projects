<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_006.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #FF0000;
        }
        .auto-style2 {
            width: 612px;
            height: 437px;
        }
        .auto-style3 {
            width: 100%;
        }
        .auto-style4 {
            width: 385px;
        }
        .auto-style5 {
            width: 383px;
        }
        .auto-style6 {
            width: 386px;
        }
        .auto-style7 {
            background-color: #FFFF99;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;</div>
        <h1>&nbsp;Head Line 1</h1>
        <h2>Head Line 2</h2>
        <h3>Head Line 3</h3>
        <h4>Head Line 4</h4>
        <h5>Head Line 5</h5>
        <h6>Head Line 6</h6>
        <p>
            This is some text I want to <span class="auto-style1">apply</span> a style to</p>
        <p>
            <a href="http://www.learnvisualstudios.com">Add a hyperlink</a></p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://www.google.com" Target="_blank">This is another hyperlink</asp:HyperLink>
        </p>
        <p>
            <img class="auto-style2" src="473012660.jpg" /></p>
    </form>
    <table class="auto-style3">
        <tr>
            <td class="auto-style4">Player</td>
            <td class="auto-style5">Year</td>
            <td class="auto-style6">Home Runs</td>
        </tr>
        <tr>
            <td class="auto-style4">Sammy Sosa</td>
            <td class="auto-style5">2005</td>
            <td class="auto-style6">100</td>
        </tr>
        <tr>
            <td class="auto-style4">Mark MacGuire</td>
            <td class="auto-style5">2005</td>
            <td class="auto-style6">102</td>
        </tr>
    </table>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <ol>
        <li>First Item</li>
        <li>Second Item</li>
        <li>Third Item</li>
    </ol>
    <ul>
        <li class="auto-style7"><strong>This is an idea</strong></li>
        <li class="auto-style7"><strong>This is an equally good idea</strong></li>
        <li class="auto-style7"><strong>Yet another idea to consider</strong></li>
    </ul>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
