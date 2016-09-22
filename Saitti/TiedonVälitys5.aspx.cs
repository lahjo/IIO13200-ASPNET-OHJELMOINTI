using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TiedonVälitys5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var propertyText = PreviousPage;
        string message = "";

        if (propertyText != null)
        {
            message = propertyText.propertyMessage;
            propertyTarget.InnerHtml = message;
        }
        else {
            propertyTarget.InnerHtml = "Ei aiempaa sivua";
        }
    }
}