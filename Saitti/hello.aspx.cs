using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hello : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnTervehdi_Click(object sender, EventArgs e)
    {
        // Lueataan käyttäjän antaman syöte
        string inPut = "Terve: " + txtNimi.Text;

        // Näytetää käyttäjälle
        lblTulos.Text = inPut;
    }
}