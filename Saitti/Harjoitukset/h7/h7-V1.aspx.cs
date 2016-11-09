using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

public partial class Harjoitukset_h7_h7_V1 : System.Web.UI.Page
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
        if (Page.IsValid) { 
            if (!File.Exists(Server.MapPath("~/App_Data/Puolijaksopalaute.xml")))
            {
                string xmldocument = Server.MapPath("~/App_Data/Puolijaksopalaute.xml");

                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.Encoding = Encoding.UTF8;

                using (XmlWriter writer = XmlWriter.Create(xmldocument, settings))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("palauteet");
                    writer.WriteStartElement("palaute");
                    writer.WriteElementString("pvm", txbDate.Text);
                    writer.WriteElementString("nimi", txbName.Text);
                    writer.WriteElementString("opintojakso", txbCode.Text);
                    writer.WriteElementString("Oppinut", txbLearn.Text);
                    writer.WriteElementString("haluaaOppia", txbWantToLearn.Text);
                    writer.WriteElementString("hyvaa", txbPositive.Text);
                    writer.WriteElementString("parannettavaa", txbNegative.Text);
                    writer.WriteElementString("muuta", txbOther.Text);
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }
            }
            else
            {
                XDocument xDocument =  XDocument.Load(Server.MapPath("~/App_Data/Puolijaksopalaute.xml"));

                XElement root = xDocument.Element("palauteet");
                IEnumerable<XElement> rows = root.Descendants("palaute");
                XElement firstRow = rows.First();
                firstRow.AddBeforeSelf(
                   new XElement("palaute",
                   new XElement("pvm", txbDate.Text),
                   new XElement("nimi", txbName.Text),
                    new XElement("opintojakso", txbCode.Text),
                    new XElement("Oppinut", txbLearn.Text),
                    new XElement("haluaaOppia", txbWantToLearn.Text),
                    new XElement("hyvaa", txbPositive.Text),
                    new XElement("parannettavaa", txbNegative.Text),
                    new XElement("muuta", txbOther.Text)));
                xDocument.Save(Server.MapPath("~/App_Data/Puolijaksopalaute.xml"));

            }
        }
    }
}