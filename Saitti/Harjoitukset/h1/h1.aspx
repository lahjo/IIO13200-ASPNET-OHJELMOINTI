<%@ Page Language="C#" AutoEventWireup="true" CodeFile="h1.aspx.cs" Inherits="h1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="http://www.w3schools.com/lib/w3.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="w3-container w3-light-green">
        <h1>Ikkunat dimensiot</h1>
        <table>
            <tr>
                <td>Leveys (L)</td>
                <td>
                    <asp:TextBox ID="txtLeveys" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Korkeus (H)</td>
                <td>
                    <asp:TextBox ID="txtKorkeus" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Karmin Leveys (W)</td>
                <td>
                    <asp:TextBox ID="txtKarminLeveys" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>

        <asp:Button ID="btnLaske" CssClass="w3-blue" runat="server" Text="Laske tarjous" OnClick="btnLaske_Click" />

        <table>
            <tr>
                <td>Ikkunan pinta-ala</td>
                <td>
                    <asp:Label ID="lblPintaala" runat="server"></asp:Label>
                </td>
                <td>m^2</td>
            </tr>
            <tr>
                <td>Karmin piiri</td>
                <td>
                    <asp:Label ID="lblKarminPiiri" runat="server"></asp:Label>
                </td>
                <td>m</td>
            </tr>
            <tr>
                <td>Tarjoushinta (ilman ALV)</td>
                <td>
                    <asp:Label ID="lblHinta" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    <div id="footer">
        <asp:Label ID="lblMessages" runat="server"/>
    </div>
    </form>
</body>
</html>
