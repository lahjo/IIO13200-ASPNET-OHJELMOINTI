using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Harjoitukset_h7_h7_V2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string JQueryVer = "1.7.1";
        ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
        {
            Path = "~/Scripts/jquery-" + JQueryVer + ".min.js",
            DebugPath = "~/Scripts/jquery-" + JQueryVer + ".js",
            CdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-" + JQueryVer + ".min.js",
            CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-" + JQueryVer + ".js",
            CdnSupportsSecureConnection = true,
            LoadSuccessExpression = "window.jQuery"
        });

        txbDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            string connetionString = null;
            SqlConnection cnn;

            connetionString = @"Data source=mysql.labranet.jamk.fi;Initial Catalog=salesa;user=salesa;password=Ucl7ZePhMt0sXYE5MGg1b75vcpMiuMoo;";
            cnn = new SqlConnection(connetionString);

            try {
                cnn.Open();
                System.Diagnostics.Debug.WriteLine("Connection Open ! ");
                cnn.Close();
            } catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine(ex + "Can not open connection ! ");
            }
        }
    }
}