using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class Harjoitukset_h6_album : System.Web.UI.Page
{
    private List<string> songTitles = new List<string>();
    protected void Page_Load(object sender, EventArgs e)
    {
        string selectedAlbum = Request.QueryString["album"];
        if (selectedAlbum != null)
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

            foreach (var child in xdocument.Descendants("song"))
            {   
                if(child.Parent.FirstAttribute.Value == selectedAlbum) {
                    songTitles.Add(child.Attribute("name").Value);
                }
            }

            System.Diagnostics.Debug.WriteLine(songTitles);

            foreach (var selectedArtist in artistList)
            {
                if (selectedArtist.ISBN == selectedAlbum)
                {
                    MyServerControlAlbumDiv.Controls.Add(new LiteralControl("<img src=" + @"levykauppaX\" + selectedArtist.ISBN + ".jpg />"));
                    MyServerControlAlbumDiv.Controls.Add(new LiteralControl("<h2>" + selectedArtist.artist + " : " + selectedArtist.title + "</h2>"));
                    MyServerControlAlbumDiv.Controls.Add(new LiteralControl("<h4>" + "ISBN: " + selectedArtist.ISBN + "</h4>"));
                    MyServerControlAlbumDiv.Controls.Add(new LiteralControl("<h4>" + "Hinta: " + selectedArtist.Price + "</h4>"));
                    MyServerControlAlbumDiv.Controls.Add(new LiteralControl("<h4>" + "raidat: " + "</h4>"));

                    foreach (var track in songTitles)
                    {
                        MyServerControlAlbumDiv.Controls.Add(new LiteralControl("<p>" + track + "</p>"));
                    }
                    }
            }
        }
    }
}