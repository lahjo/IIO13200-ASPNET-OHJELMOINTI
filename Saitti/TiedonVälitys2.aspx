<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TiedonVälitys2.aspx.cs" Inherits="TiedonVälitys2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Kohde 2: HTTP POST -tapa</h1>
            <p>
                Kutsuvalta sivulta luetaan viesti:
                <%= Request.Form["txtMessage"] %>
                <br />
            </p>
    </div>
    </form>
</body>
</html>
