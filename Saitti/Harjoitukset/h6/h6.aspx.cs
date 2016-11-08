using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class Harjoitukset_h6_h6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string xmlFile = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, @"App_Data\LevykauppaX.xml");
        XDocument xdocument = XDocument.Load(xmlFile);

        var artistList = from album in xdocument.Descendants("record")
                     select new
                     {
                         artist = album.Attribute("Artist").Value,
                         title = album.Attribute("Title").Value,
                         ISBN = album.Attribute("ISBN").Value,
                         Price = album.Attribute("Price").Value
                     };

        foreach (var selectedArtist in artistList)
        {

            MyServerControlDiv.Controls.Add(new LiteralControl("<img src=" + @"levykauppaX\" + selectedArtist.ISBN + ".jpg />"));
            MyServerControlDiv.Controls.Add(new LiteralControl("<h2>" + selectedArtist.artist + " : " + selectedArtist.title + "</h2>"));
            MyServerControlDiv.Controls.Add(new LiteralControl("<h4>" + "ISBN: " + "<a href='album.aspx?album=" + selectedArtist.ISBN + "'>" +  selectedArtist.ISBN + "</a>" + "</h4>"));
            MyServerControlDiv.Controls.Add(new LiteralControl("<h4>" + "Hinta: " + selectedArtist.Price + "</h4>"));
        }
    }
}