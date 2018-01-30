using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PortableApp.Pages
{
	public class SizedBoxViewPage : ContentPage
	{
		public SizedBoxViewPage ()
		{
      BackgroundColor = Color.Pink;

      Content = new BoxView
      {
        Color = Color.Navy,
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center,
        WidthRequest = 200,
        HeightRequest = 100
      };
		}
	}
}