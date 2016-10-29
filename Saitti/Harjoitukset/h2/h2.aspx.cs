using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Harjoitukset_h2_h2 : System.Web.UI.Page
{
	BLLotto lotto = new BLLotto();
	
    protected void Page_Load(object sender, EventArgs e)
    {
		
    }
	
	protected void btnLotto_Click(object sender, EventArgs e)
    {
		Numbers.Items.Clear();
		
        try
            {
                int rounds = int.Parse(round.Text);

                if (dropMenuLotto.SelectedItem.Text == "SuomiLotto") {
                    for (int roundsLimit = 0; roundsLimit < rounds; roundsLimit++) {
                        Numbers.Items.Add(lotto.SuomiLotto());
                    }
                } else if(dropMenuLotto.SelectedItem.Text == "VikingLotto") {
                    for (int roundsLimit = 0; roundsLimit < rounds; roundsLimit++)
                    {
                        Numbers.Items.Add(lotto.VikingLotto());
                    }
                }
            }
		catch (Exception ex)
			{
			}
    }
}