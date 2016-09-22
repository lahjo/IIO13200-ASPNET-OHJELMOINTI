<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SivunVaihto.aspx.cs" Inherits="SivunVaihto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tiedon välitys demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Source-sivu</h1>
        <p>
            Lähetettävä viesti: <asp:TextBox ID="txtMessage" runat="server" />
                                <asp:DropDownList ID="dropList" runat="server" OnSelectedIndexChanged="dropList_SelectedIndexChanged" AutoPostBack="True" />

            <br />

            <asp:Button ID="btnQueryString" runat="server" Text="Käytä queryString" OnClick="btnQueryString_Click"/>
            <asp:Button ID="btnHttpPost" runat="server" Text="Käytä POST" PostBackUrl="~/TiedonVälitys2.aspx"/>
            <asp:Button ID="btnSession" runat="server" Text="Käytä POST" OnClick="btnSession_Click"/>
            <asp:Button ID="btnCookie" runat="server" Text="Käytä Cookieta" OnClick="btnCookie_Click"/>
            <asp:Button ID="btnProperty" runat="server" Text="Käytä public property ominaisuutta" OnClick="btnProperty_Click"/>
        </p>
    </div>
    </form>
</body>
</html>
