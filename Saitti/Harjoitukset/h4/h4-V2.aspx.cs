using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Harjoitukset_h4_h4_V2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        grid.DataSource = JAMK.IT.DBDemoxOy.GetDataReal(); ;
        grid.DataBind();
    }
}