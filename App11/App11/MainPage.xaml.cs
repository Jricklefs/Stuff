using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App11
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		    DoStchuff();
		}

	    public async void DoStchuff()
	    {
	        HttpClient client = new HttpClient();

	        try
	        {
	            var details = await client.GetStringAsync("http://api.josephricklefs.com/api/currentraceinfo");

	            System.Diagnostics.Debug.Write("11111111111111111" + details);
	        }
	        catch (Exception e)
	        {
	            var ooo = e;
	            throw;
	        }
	    }
	}
}
