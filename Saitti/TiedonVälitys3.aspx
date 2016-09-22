<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TiedonVälitys3.aspx.cs" Inherits="TiedonVälitys3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Kohde 3: Session -tapa</h1>
            <p>
                Sessionista luettu viesti:
                <%= Session["Viesti"] %>
                <br />
            </p>
    </div>
    </form>
</body>
</html>
