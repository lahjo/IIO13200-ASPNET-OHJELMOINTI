<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>IIO13200 .NET Ohjelmointi</title>
    <link href="http://www.w3schools.com/lib/w3.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>IIO13200. NET Ohjelmointi</h1>
            <h2>1.kontaktikerta</h2>
            <h3>Perus HTML kontrolleja</h3>
            <a href="testi.html">Testi html-sivu</a>

            <br />

            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/hello.aspx" >Hello sivu</asp:LinkButton>
            <p>
                Esimerkki ASP.NET DataKontrollista
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/ShowPhotos.aspx">Show Photos</asp:HyperLink>
            </p>
            <p>
                Esimerkki kuinka koodissa rakennetaan HTML:ää
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ShowCustomers.aspx">Show WineCustomers</asp:HyperLink>
            </p>
        </div>

        <hr />

        <div>
            <h2>3.kontaktikerta</h2>
            <h3>Tiedon välitys sivuittain</h3>

            <asp:HyperLink ID="hyperLink3" runat="server" NavigateUrl="~/SivunVaihto.aspx">Tiedon välitys 6 tapaa</asp:HyperLink>

        </div>

    </form>
</body>
</html>
