<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="GetServices.WebForm2" %>
<%@ OutputCache Duration="10" VaryByParam="None" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 400px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1 style="color: #000080; width: 243px; font-style: italic; text-decoration: underline; background-color: #808080; align-content:center; right: 200px; " class="auto-style1">Zipcode&nbsp; Services</h1>
        

    </div>
        <p>
            &nbsp;</p>
        <p style="margin-left: 80px">
            Enter a valid Zipcode:
            <asp:TextBox ID="TextBox1" runat="server"  Width="179px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        </p>
        <p style="margin-left: 80px">
&nbsp;&nbsp;&nbsp; Output:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Zipcode info"></asp:Label>
        </p>
        <p style="margin-left: 80px">
            &nbsp;</p>
        <p style="margin-left: 80px">
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Weather Forecast service" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="News Focus Service" Width="196px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Get Latitude/Longitude" Width="173px" />
        </p>
    <p style="margin-left: 303px">
        &nbsp;</p>
    </form>
    <p style="margin-left: 0px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Info: User entered zipcode is used in the above services</p>
</body>
</html>
