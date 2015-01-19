<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="GetServices.WebForm3" %>


<!DOCTYPE html>
<%@ OutputCache Duration="10" VaryByParam="None" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1 style="color: #000080; width: 370px; font-style: italic; text-decoration: underline; background-color: #808080; align-content:center; right: 200px; margin-left: 360px;">Latitude/Longitude Services</h1>
        
    </div>
        <p>
            &nbsp;</p>
        <p style="margin-left: 280px">
            &nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="Enter"></asp:Label>
&nbsp; Latitude:
            <asp:TextBox ID="TextBox1" runat="server"  Width="75px"></asp:TextBox>
&nbsp; (example: 33.12)&nbsp; Longitude:
            <asp:TextBox ID="TextBox2" runat="server"  Width="96px"></asp:TextBox>
        &nbsp;(example: -110.112)</p>
        <p style="margin-left: 280px">
            &nbsp;</p>
        <p style="margin-left: 280px">
            &nbsp;</p>
        <p style="margin-left: 82px">
            &nbsp;</p>
        <p style="margin-left: 82px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Elevation" Width="197px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Get Wind Potential" style="margin-left: 0px" Width="205px" />
        </p>
    </form>
</body>
</html>
