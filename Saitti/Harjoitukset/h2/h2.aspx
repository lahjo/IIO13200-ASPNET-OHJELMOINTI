<%@ Page Language="C#" AutoEventWireup="true" CodeFile="h2.aspx.cs" Inherits="Harjoitukset_h2_h2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="dropMenuLotto" runat="server">
            <asp:ListItem Text="SuomiLotto" Value="SuomiLotto"></asp:ListItem>
            <asp:ListItem Text="VikingLotto" Value="VikingLotto"></asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="round" Text="" runat="server"></asp:TextBox>
        <asp:Button ID="btnLotto" Text="Arvo" runat="server" OnClick="btnLotto_Click" />
    </div>
    <div>
        <asp:ListBox id="Numbers" runat="server"></asp:ListBox>
    </div>
    </form>
</body>
</html>
