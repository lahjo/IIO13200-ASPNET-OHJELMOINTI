<%@ Page Language="C#" AutoEventWireup="true" CodeFile="h9.aspx.cs" Inherits="Harjoitukset_h9_h9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="ddlStations" runat="server"></asp:DropDownList>
        <asp:Button ID="btnGetDepartingTrains" runat="server" Text="Hae lähtevät junat" OnClick="btnGetDepartingTrains_Click" /><br />
        <asp:GridView ID="gvTrains" runat="server"></asp:GridView>
        <asp:Label ID="lblInfo" runat="server"></asp:Label>
    </div>
</form>
</body>
</html>
