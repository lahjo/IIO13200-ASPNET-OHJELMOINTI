using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

public class BLLotto {
	private int[] suomilotto, vikinglotto, eurojackpotPaa, eurojackpotlisa;
	private string result, resultLisa;
	Random rd = new Random();

	public string SuomiLotto() {
		suomilotto = new int[7];

		for(int i=0 ;i < 7 ;i++) {
			int randomIndex = rd.Next(1, 39);
			while (suomilotto.Contains(randomIndex)) {
				randomIndex = rd.Next(1, 39);
			}
			suomilotto[i] = randomIndex;
		}

			result = string.Join(" ", suomilotto);
		return result;
	}

	public string VikingLotto() {
			vikinglotto = new int[6];

			for (int i = 0; i < 6; i++) {
				int randomIndex = rd.Next(1, 48);
				while (vikinglotto.Contains(randomIndex))
				{
					randomIndex = rd.Next(1, 48);
				}
				vikinglotto[i] = randomIndex;
			}

			result = string.Join(" ", vikinglotto);
		return result;
	}
}
