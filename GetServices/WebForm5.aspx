<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="GetServices.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Below are the news focus links for the zipcode: 
        <asp:Label ID="Label1" runat="server" ForeColor="#3333CC"></asp:Label>
        </h1>
    </div>
        <asp:TextBox ID="TextBox1" runat="server" ForeColor="#6666FF" Height="194px"  ReadOnly="True" TextMode="MultiLine" Width="469px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Back" />
    </form>
</body>
</html>
