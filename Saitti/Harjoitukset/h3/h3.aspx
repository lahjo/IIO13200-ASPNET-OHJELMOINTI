<%@ Page Language="C#" AutoEventWireup="true" CodeFile="h3.aspx.cs" Inherits="Harjoitukset_h3_h3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>Tänään on <%= DateTime.Now.ToString("dd-MM-yyyy") %></h3>
        <h3>Valitsit päivän <asp:Label ID="selectedDate" Text="" runat="server"></asp:Label></h3>
        <h3>Syntymäpäivääsi on <asp:Label ID="dayLeft" Text="" runat="server"></asp:Label> jäljellä</h3>
         <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="calender_selection_changed"></asp:Calendar>     
    </div>
    </form>
</body>
</html>
