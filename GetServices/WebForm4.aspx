<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="GetServices.WebForm4" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p>Weather Forecast Service for Zipcode-
        <asp:Label ID="Label6" runat="server"></asp:Label>
        </p>
        
        <p class="lead">
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
        <p class="lead">
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </p>
        <p class="lead">
            <asp:Label ID="Label3" runat="server"></asp:Label>
        </p>
        <p class="lead">
            <asp:Label ID="Label4" runat="server"></asp:Label>
        </p>
        <p class="lead">
            <asp:Label ID="Label5" runat="server"></asp:Label>
        </p>
        <p class="lead">
            &nbsp;</p>
    </div>
        <div style="margin-left: 480px">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Back" />
        </div>
    </form>
</body>
</html>
