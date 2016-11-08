<%@ Page Language="C#" AutoEventWireup="true" CodeFile="h8.aspx.cs" Inherits="Harjoitukset_h8_h8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Harjoitus 8</title>
    <link href="MyStyles.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListBox id="theaterList" runat="server" OnSelectedIndexChanged="theaterList_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox>
        <div id="movies" runat="server"></div>
    </div>
    </form>
</body>
</html>
