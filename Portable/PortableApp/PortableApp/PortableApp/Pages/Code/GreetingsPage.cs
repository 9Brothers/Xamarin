using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PortableApp.Pages
{
	public class GreetingsPage : ContentPage
	{
		public GreetingsPage ()
		{
      Content = new Label
      {
        Text = "Greetings, Xamarin.Forms",
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center,
        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
        FontAttributes = FontAttributes.Bold | FontAttributes.Italic
        //HorizontalTextAlignment = TextAlignment.Center,
        //VerticalTextAlignment = TextAlignment.Center,
        //BackgroundColor = Color.Yellow,
        //TextColor = Color.Blue
      };

      //#if __IOS__
      //Padding = new Thickness(0, 20, 0, 0);
      //#endif

      //Padding = Device.OnPlatform<Thickness>(
      //    new Thickness(0, 20, 0, 0),
      //    new Thickness(0),
      //    new Thickness(0)
      //  );

      //Padding = Device.OnPlatform(
      //  iOS: new Thickness(0, 20, 0, 0),
      //  Android: new Thickness(0),
      //  WinPhone: new Thickness(0)
      //);

      //Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

      //Double topPadding = 0;

      //switch (Device.RuntimePlatform)
      //{
      //  case Device.Android:
      //    topPadding = 0;
      //    break;

      //  case Device.iOS:
      //    topPadding = 20;
      //    break;
      //}

      //Padding = new Thickness(0, topPadding, 0, 0);

      //Device.OnPlatform(iOS: () =>
      //{
      //  Padding = new Thickness(0, 20, 0, 0);
      //});
    }
	}
}