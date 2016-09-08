<%@ Page Language="C#" AutoEventWireup="true" CodeFile="hello.aspx.cs" Inherits="hello" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:textbox ID="txtNimi" runat="server"></asp:textbox>
        <asp:Button ID="btnTervehdi" runat="server" Text="Hello" OnClick="btnTervehdi_Click" />
        <br />
        <asp:Label ID="lblTulos" runat="server" Text="---"/>
    </div>
    </form>
</body>
</html>

