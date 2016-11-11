<%@ Page Language="C#" AutoEventWireup="true" CodeFile="h7-V2.aspx.cs" Inherits="Harjoitukset_h7_h7_V2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="border:solid 1px">
            <tr>
                <td style="border:solid 1px">
                    <h3>Anna palaute</h3>
                    <label>Pvm</label>
                    <asp:TextBox ID="txbDate" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator id="RequiredFieldValidatorPvm" runat="server"
                      ControlToValidate="txbDate"
                      ErrorMessage="Pvm on pakollinen kenttä."
                      ForeColor="Red">
                    </asp:RequiredFieldValidator>

                    <label>Nimi</label>
                    <asp:TextBox ID="txbName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator id="RequiredFieldValidatorName" runat="server"
                      ControlToValidate="txbName"
                      ErrorMessage="Nimi on pakollinen kenttä."
                      ForeColor="Red">
                    </asp:RequiredFieldValidator>
                    <br />

                    <label>Opintojako nimi ja koodi</label>
                    <asp:TextBox ID="txbCode" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator id="RequiredFieldValidatorCode" runat="server"
                      ControlToValidate="txbCode"
                      ErrorMessage="Opintojako nimi ja koodi on pakollinen kenttä."
                      ForeColor="Red">
                    </asp:RequiredFieldValidator>
                    <br />

                    <label>Olen oppinut</label>
                    <asp:TextBox ID="txbLearn" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator id="RequiredFieldValidatorLearn" runat="server"
                      ControlToValidate="txbName"
                      ErrorMessage="Olen oppinut on pakollinen kenttä."
                      ForeColor="Red">
                    </asp:RequiredFieldValidator>

                    <br />

                    <label>Haluan oppia</label>
                    <asp:TextBox ID="txbWantToLearn" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator id="RequiredFieldValidatorWantToLearn" runat="server"
                      ControlToValidate="txbWantToLearn"
                      ErrorMessage="Haluan oppia on pakollinen kenttä."
                      ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </td>
                <td style="border:solid 1px">
                    <h3>Palaute jatkuu</h3>
                    <label>Hyvää</label>
                    <asp:TextBox ID="txbPositive" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator id="RequiredFieldValidatorPositive" runat="server"
                      ControlToValidate="txbPositive"
                      ErrorMessage="Positiivistä kenttä on pakollinen kenttä."
                      ForeColor="Red">
                    </asp:RequiredFieldValidator>

                    <br />

                    <label>Parannettavaa</label>
                    <asp:TextBox ID="txbNegative" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator id="RequiredFieldValidatorNegative" runat="server"
                      ControlToValidate="txbNegative"
                      ErrorMessage="Negatiivistä kenttä on pakollinen kenttä."
                      ForeColor="Red">
                    </asp:RequiredFieldValidator>

                    <br />

                    <label>Muuta</label>
                    <asp:TextBox ID="txbOther" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator id="RequiredFieldValidatorOther" runat="server"
                      ControlToValidate="txbOther"
                      ErrorMessage="Muuta kenttä on pakollinen kenttä."
                      ForeColor="Red">
                    </asp:RequiredFieldValidator>

                    <br />
                    <br />

                    <asp:Button ID="btnSubmit" runat="server" Text="Lähetä palaute" OnClick="btnSubmit_Click"/>
                </td>
            </tr>
        </table>
        <asp:HyperLink NavigateUrl="palautteet-V1.aspx" Text="" runat="server" >Lue palautteet</asp:HyperLink>
    </div>
    </form>
</body>
</html>
