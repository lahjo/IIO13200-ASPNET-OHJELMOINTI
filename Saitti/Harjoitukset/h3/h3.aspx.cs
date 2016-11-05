using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Harjoitukset_h3_h3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void calender_selection_changed(object sender, EventArgs e) {
        selectedDate.Text =  Calendar1.SelectedDate.ToString("dd-MM-yyyy");

        TimeSpan i = new TimeSpan(0, 0, 0);

        DateTime startDate = Convert.ToDateTime(DateTime.Today.ToString("dd-MM-yyyy").Trim());
        DateTime endDate = Convert.ToDateTime(Calendar1.SelectedDate.ToString("dd-MM-yyyy").Trim());
        i += endDate.Subtract(startDate);
        int days = i.Days;

        dayLeft.Text =  days.ToString();
    }
    
}