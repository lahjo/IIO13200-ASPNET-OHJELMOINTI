using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TiedonVälitys4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Tarkistetaan että löytyykö haluttua cookieta ja jos löytyy niin tarkistetaab cookien arvo
        foreach (string cookie in Request.Cookies)
        {
            if (cookie == "Viesti") {
                cookieMessage.InnerHtml = "Cookiessa lukee " + Request.Cookies[cookie].Value;
            }
        }
    }
}