<%@ Page Title="" Language="C#" MasterPageFile="~/Harjoitukset/h4/h4.master" AutoEventWireup="true" CodeFile="h4-V1.aspx.cs" Inherits="Harjoitukset_h4_h4_V1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    Versio 1
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" Runat="Server">
    <asp:SqlDataSource
        id="SqlDataSource2"
        runat="server"
        DataSourceMode="DataReader"
        ConnectionString="Data source=twelve.labranet.jamk.fi;initial catalog=DemoxOy;user=koodari;password=koodari16"
        SelectCommand="SELECT astunnus, asnimi, yhteyshlo, postitmp FROM asiakas">
    </asp:SqlDataSource>

      <asp:DataGrid
          id="Grid"
          runat="server"
          DataSourceID="SqlDataSource2">
      </asp:DataGrid>

</asp:Content>

