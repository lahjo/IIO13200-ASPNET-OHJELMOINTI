using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SivunVaihto : System.Web.UI.Page
{
    public string propertyMessage
    {
        get { return txtMessage.Text; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack) { 
            dropList.Items.Add("Ping");
            dropList.Items.Add("Pong");
            dropList.Items.Add("Pung");
        }
    }

    protected void btnQueryString_Click(object sender, EventArgs e)
    {
        Response.Redirect("TiedonVälitys1.aspx?Data=" + txtMessage.Text);
    }

    protected void btnSession_Click(object sender, EventArgs e)
    {
        Session["Viesti"] = txtMessage.Text;
        Response.Redirect("TiedonVälitys3.aspx");
    }

    protected void btnCookie_Click(object sender, EventArgs e)
    {
        HttpCookie cookie = new HttpCookie("Viesti", txtMessage.Text);
        Response.Cookies.Add(cookie);

        Response.Redirect("TiedonVälitys4.aspx");
    }

    protected void btnProperty_Click(object sender, EventArgs e)
    {
        Server.Transfer("TiedonVälitys5.aspx");
    }

    protected void dropList_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtMessage.Text = dropList.SelectedItem.ToString();
    }
}