using System;
using System.Configuration;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class h1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLaske_Click(object sender, EventArgs e)
    {
        // Laske tarjous hinta
        try {
            // Käyttäjän syötteet on aina tarkistaa
            if (txtKorkeus.Text.Length * txtLeveys.Text.Length * txtKarminLeveys.Text.Length > 0) {
                double leveys = Convert.ToDouble(txtLeveys.Text);
                double korkeus = Convert.ToDouble(txtKorkeus.Text);
                double karminLeveys = Convert.ToDouble(txtKarminLeveys.Text);
                double pintaala = ((korkeus - (2 * karminLeveys)) / 1000) * ((leveys - (2 * karminLeveys)) / 1000); //m^2
                double piiri = 2 * ((leveys / 1000) + (korkeus / 1000)); //juoksumetri

                // Materiaali hinnat
                double aluHinta = Convert.ToDouble(ConfigurationManager.AppSettings["alumiini"]); // € per m^2
                double lasiHinta = 45; // € per juoksumetri
                double työmenekki = 150; // € per ikkuna
                double kate = 0.3; // Kate 30%

                // Hinta laskenta
                double hinta = (1 + kate) * ((pintaala * lasiHinta) + (piiri * aluHinta) + työmenekki);

                // Tulos UI:n
                lblHinta.Text = hinta.ToString("C2", CultureInfo.CreateSpecificCulture("fi-Fi"));
                lblKarminPiiri.Text = piiri.ToString();
                lblPintaala.Text = pintaala.ToString();

                lblMessages.Text = "";
            }
            else
            {
                lblMessages.Text = "Tarkista syötteet, jokin puuttuu....";
            }
        } catch (Exception ex) {
            lblMessages.Text = ex.Message;
        }
    }
}