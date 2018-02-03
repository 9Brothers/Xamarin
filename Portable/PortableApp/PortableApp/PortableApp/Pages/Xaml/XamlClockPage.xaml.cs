using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PortableApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class XamlClockPage : ContentPage
	{
		public XamlClockPage ()
		{
			InitializeComponent ();

      Device.StartTimer(TimeSpan.FromSeconds(1), () =>
      {
        DateTime dt = DateTime.Now;

        timeLabel.Text = dt.ToString("T");
        dateLabel.Text = dt.ToString("D");

        return true;
      });
		}
	}
}