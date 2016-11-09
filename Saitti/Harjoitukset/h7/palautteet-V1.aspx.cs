using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Harjoitukset_h7_palautteet_V1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (File.Exists(Server.MapPath("~/App_Data/Puolijaksopalaute.xml"))) { 
            using (DataSet ds = new DataSet())
            {
                ds.ReadXml(Server.MapPath("~/App_Data/Puolijaksopalaute.xml"));
                grid.DataSource = ds;
                grid.DataBind();
            }
        }
    }
}