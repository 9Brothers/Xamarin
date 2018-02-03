using PortableApp.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

using Xamarin.Forms;

namespace PortableApp.Pages
{
	public class BlackCatPage : ContentPage
	{
		public BlackCatPage ()
		{
      var mainStack = new StackLayout();
      var textStack = new StackLayout
      {
        Padding = new Thickness(5),
        Spacing = 10
      };

      var assembly = GetType().GetTypeInfo().Assembly;

      string resource = "PortableApp.Assets.Texts.TheBlackCat.txt";

      using (Stream stream = assembly.GetManifestResourceStream(resource))
      {

        using (StreamReader reader = new StreamReader(stream))
        {
          bool gotTitle = false;
          string line;

          while ((line = reader.ReadLine()) != null)
          {
            var label = new Label
            {
              Text = line,

              TextColor = Color.Black
            };

            if(!gotTitle)
            {
              label.HorizontalOptions = LayoutOptions.Center;
              label.FontSize = Device.GetNamedSize(NamedSize.Medium, label);
              label.FontAttributes = FontAttributes.Bold;
              mainStack.Children.Add(label);
              gotTitle = true;
            }
            else
            {
              textStack.Children.Add(label);
            }
          }
        }
      }

      var scrollView = new ScrollView
      {
        Content = textStack,
        VerticalOptions = LayoutOptions.FillAndExpand,
        Padding = new Thickness(5, 0)
      };

      mainStack.Children.Add(scrollView);

      Content = mainStack;

      BackgroundColor = Color.White;

      Padding = new Thickness(0, DevicePadding.Top(), 0, 0);
		}
	}
}