using System;
using System.Data;
using System.Configuration; // Web.config lukemista varten
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tyontekijat : System.Web.UI.Page
{
    string xmlFilu;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Haetaan web.config:sta xml-tiedoston nimi
        xmlFilu = ConfigurationManager.AppSettings["xmlfilu"];
        lblMessages.Text = xmlFilu;
    }

    protected void btnHae_Click(object sender, EventArgs e)
    {
        // Haetaan XML-data DataView-olioon, joka kytketään GridViewhen
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        DataView dv = new DataView();

        ds.ReadXml(Server.MapPath(xmlFilu));
        dt = ds.Tables[0];
        dv = dt.DefaultView;
        gvData.DataSource = dv;
        gvData.DataBind();
    }
}