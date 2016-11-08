using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

public partial class Harjoitukset_h8_h8 : System.Web.UI.Page
{
    List<theater> finkinoTheaters = new List<theater>();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            XmlDocument xdoc = new XmlDocument();//xml doc used for xml parsing

            xdoc.Load("http://www.finnkino.fi/xml/TheatreAreas/");//loading XML in xml doc


            XmlNodeList xNodelst = xdoc.DocumentElement.SelectNodes("TheatreArea");//reading node so that we can traverse thorugh the XML

            bool first = true;
            foreach (XmlNode xNode in xNodelst)//traversing XML 
            {
                if (first)
                {
                    first = false;
                    continue;
                }

                finkinoTheaters.Add(new theater((xNode as XmlElement).ChildNodes[1].InnerText, Convert.ToInt32((xNode as XmlElement).ChildNodes[0].InnerText)));
            }

            Session["finkinoTheatersList"] = finkinoTheaters;
            theaterList.DataSource = finkinoTheaters;
            theaterList.DataBind();
        }
    }

    protected void theaterList_SelectedIndexChanged(object sender, EventArgs e)
    {
        XmlDocument xdocMovies = new XmlDocument();

        finkinoTheaters = (List<theater>)Session["finkinoTheatersList"];

        xdocMovies.Load("http://www.finnkino.fi/xml/Schedule/?area=" + finkinoTheaters[theaterList.SelectedIndex].ID + "&dt" + DateTime.Today.ToString("dd.MM.yyyy"));

        XmlNodeList xNodelist = xdocMovies.DocumentElement.SelectNodes("Shows/Show/Images/EventSmallImagePortrait");

        foreach(XmlNode xNode in xNodelist)//traversing XML 
        {
            Image NewMovieImage = new Image();
            NewMovieImage.ImageUrl = xNode.InnerText;

            movies.Controls.Add(NewMovieImage);
        }
    }
}