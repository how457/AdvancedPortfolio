using System;
using CPSC1012_AdvancedPortfolio_NamYoon; //comment this out when running in windows

namespace AdvancedPortfolioMac
{
	public class Program
	{
		[STAThread]
		public static void Main()
		{
			App myApp = new App();
			myApp.start();
		}
	}
}