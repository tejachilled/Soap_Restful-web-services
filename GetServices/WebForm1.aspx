<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="GetServices.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="align-content:center">
    
    
        <h1 style="color: #000080; width: 600px; font-style: italic; text-decoration: underline; background-color: #808080; align-content:center; right: 200px; margin-left: 280px;">Zipcode &amp; Latitude/Longitude Application</h1>
        <p style="margin-left: 360px">
            &nbsp;</p>
        <p style="margin-left: 360px">
            &nbsp;</p>
        <p style="margin-left: 274px">
            &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ZipCode Services" Width="298px" ForeColor="#3333CC" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Latitude/Longitude Services" Width="300px" ForeColor="#3333CC" style="margin-left: 42px" />
        </p>
        </div>
        <p style="margin-left: 199px">
            &nbsp;</p>
        <p style="margin-left: 479px">
            <asp:Label ID="Label3" runat="server" Text="1) Cookies are used in both the services"></asp:Label>
        </p>
        <p style="margin-left: 479px">
            2) Data Cache is used in Zipcode services i.e </p>
        <p style="margin-left: 479px">
            you can avail zipcode services for every 10 secs. </p>
        <p style="margin-left: 479px">
            If you enter a new Zipcode, old value will be restored from cache</p>
        <p style="margin-left: 479px">
            &nbsp;</p>
    </form>
</body>
</html>

